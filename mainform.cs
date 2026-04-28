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
                if (dataGridViewCoins.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Оберіть монету");
                    return;
                }

                Coin selectedCoin = (Coin)dataGridViewCoins.SelectedRows[0].DataBoundItem;
                int index = manager.Coins.IndexOf(selectedCoin);

                formeditcoin form = new formeditcoin(selectedCoin);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        manager.UpdateCoin(index, form.UpdatedCoin);
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
                if (dataGridViewCollectors.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Оберіть колекціонера");
                    return;
                }

                Collector selectedCollector = (Collector)dataGridViewCollectors.SelectedRows[0].DataBoundItem;
                int index = manager.Collectors.IndexOf(selectedCollector);

                formeditcollector form = new formeditcollector(selectedCollector);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        manager.UpdateCollector(index, form.UpdatedCollector);
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
                int index = manager.Coins.IndexOf(selectedCoin);

                manager.RemoveCoin(index);
                RefreshCoins();
            }
            else if (activeTable == "collectors")
            {
                if (dataGridViewCollectors.CurrentRow == null)
                {
                    MessageBox.Show("Виберіть рядок для видалення");
                    return;
                }

                Collector selectedCollector = (Collector)dataGridViewCollectors.CurrentRow.DataBoundItem;
                int index = manager.Collectors.IndexOf(selectedCollector);

                manager.RemoveCollector(index);
                RefreshCollectors();
            }
        }
    }
}
