namespace NumismatGuide
{
    public partial class mainform : Form
    {
        private CollectionManager manager = new CollectionManager();

        private string activeTable = "coins";
        public mainform()
        {
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            dataGridViewCoins.AutoGenerateColumns = false;
            dataGridViewCollectors.AutoGenerateColumns = false;
            dataGridViewCoins.DataSource = manager.Coins;
            dataGridViewCollectors.DataSource = manager.Collectors;

            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;

            UpdateCriteria();
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                activeTable = "coins";
            }
            else if (tabControl.SelectedIndex == 1)
            {
                activeTable = "collectors";
            }

            UpdateCriteria();
        }

        private void RefreshCoins()
        {
            dataGridViewCoins.DataSource = null;
            dataGridViewCoins.DataSource = manager.Coins;
        }

        private void RefreshCollectors()
        {
            dataGridViewCollectors.DataSource = null;
            dataGridViewCollectors.DataSource = manager.Collectors;
        }

        private void UpdateCriteria()
        {
            comboBoxCriterion.Items.Clear();
            comboBoxCriterion.SelectedIndex = -1;
            comboBoxCriterion.Text = "";

            if (activeTable == "coins")
            {
                comboBoxCriterion.Items.Add("Країна");
                comboBoxCriterion.Items.Add("Матеріал");
                comboBoxCriterion.Items.Add("Рік");
            }
            else if (activeTable == "collectors")
            {
                comboBoxCriterion.Items.Add("Прізвище");
                comboBoxCriterion.Items.Add("Ім'я");
                comboBoxCriterion.Items.Add("Країна");
                comboBoxCriterion.Items.Add("Телефон");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (activeTable == "coins")
                {
                    formaddcoin form = new formaddcoin();

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        manager.AddCoin(form.NewCoin);
                        RefreshCoins();
                    }
                }
                else if (activeTable == "collectors")
                {
                    formaddcollector form = new formaddcollector();

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        manager.AddCollector(form.NewCollector);
                        RefreshCollectors();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (activeTable == "coins")
            {
                if (dataGridViewCoins.CurrentRow == null)
                {
                    MessageBox.Show("Оберіть монету");
                    return;
                }

                Coin selectedCoin = dataGridViewCoins.CurrentRow.DataBoundItem as Coin;

                if (selectedCoin == null)
                {
                    MessageBox.Show("Помилка вибору монети");
                    return;
                }

                formeditcoin form = new formeditcoin(selectedCoin);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        manager.UpdateCoin(selectedCoin, form.UpdatedCoin);
                        RefreshCoins();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (activeTable == "collectors")
            {
                if (dataGridViewCollectors.CurrentRow == null)
                {
                    MessageBox.Show("Оберіть колекціонера");
                    return;
                }

                Collector selectedCollector = dataGridViewCollectors.CurrentRow.DataBoundItem as Collector;

                if (selectedCollector == null)
                {
                    MessageBox.Show("Помилка вибору колекціонера");
                    return;
                }

                formeditcollector form = new formeditcollector(selectedCollector);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        manager.UpdateCollector(selectedCollector, form.UpdatedCollector);
                        RefreshCollectors();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (activeTable == "coins")
            {
                if (dataGridViewCoins.CurrentRow == null)
                {
                    MessageBox.Show("Виберіть рядок для видалення");
                    return;
                }

                Coin selectedCoin = (Coin)dataGridViewCoins.CurrentRow.DataBoundItem;

                if (selectedCoin == null)
                {
                    MessageBox.Show("Помилка при виборі монети. Спробуйте ще раз.");
                    return;
                }

                var result = MessageBox.Show(
                    "Ви точно хочете видалити цю монету?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                try
                {
                    manager.Coins.Remove(selectedCoin);
                    RefreshCoins();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (activeTable == "collectors")
            {
                if (dataGridViewCollectors.CurrentRow == null)
                {
                    MessageBox.Show("Виберіть рядок для видалення");
                    return;
                }

                Collector selectedCollector = (Collector)dataGridViewCollectors.CurrentRow.DataBoundItem;

                if (selectedCollector == null)
                {
                    MessageBox.Show("Помилка при виборі колекціонера. Спробуйте ще раз.");
                    return;
                }

                var result = MessageBox.Show(
                    "Ви точно хочете видалити цього колекціонера?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                try
                {
                    manager.Collectors.Remove(selectedCollector);
                    RefreshCollectors();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonUse_Click(object sender, EventArgs e)
        {
            try
            {
                var filtered = manager.FilterCoins(
                    textBoxCountry.Text,
                    textBoxMaterial.Text,
                    textBoxYearFrom.Text,
                    textBoxYearTo.Text
                );

                dataGridViewCoins.DataSource = null;
                dataGridViewCoins.DataSource = filtered;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxCountry.Text = "";
            textBoxMaterial.Text = "";
            textBoxYearFrom.Text = "";
            textBoxYearTo.Text = "";

            dataGridViewCoins.DataSource = null;
            dataGridViewCoins.DataSource = manager.Coins;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (activeTable == "coins")
            {
                string criterion = comboBoxCriterion.SelectedItem?.ToString();
                string query = textBoxSearch.Text;

                if (string.IsNullOrEmpty(criterion))
                {
                    MessageBox.Show("Оберіть критерій пошуку");
                    return;
                }

                try
                {
                    List<Coin> results = manager.SearchCoins(criterion, query);

                    dataGridViewCoins.DataSource = null;
                    dataGridViewCoins.DataSource = results;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (activeTable == "collectors")
            {
                string criterion = comboBoxCriterion.SelectedItem?.ToString();
                string query = textBoxSearch.Text;

                if (string.IsNullOrEmpty(criterion))
                {
                    MessageBox.Show("Оберіть критерій пошуку");
                    return;
                }

                try
                {
                    List<Collector> results = manager.SearchCollectors(criterion, query);

                    dataGridViewCollectors.DataSource = null;
                    dataGridViewCollectors.DataSource = results;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
