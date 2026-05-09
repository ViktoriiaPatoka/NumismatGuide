namespace NumismatGuide
{
    partial class mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            CoinsPage = new TabPage();
            dataGridViewCoins = new DataGridView();
            CountryCoins = new DataGridViewTextBoxColumn();
            YearCoins = new DataGridViewTextBoxColumn();
            MaterialCoins = new DataGridViewTextBoxColumn();
            CirculationCoins = new DataGridViewTextBoxColumn();
            FeaturesCoins = new DataGridViewTextBoxColumn();
            CollectorsPage = new TabPage();
            dataGridViewCollectors = new DataGridView();
            LastNameCollectors = new DataGridViewTextBoxColumn();
            NameCollectors = new DataGridViewTextBoxColumn();
            CountryCollectors = new DataGridViewTextBoxColumn();
            PhoneCollectors = new DataGridViewTextBoxColumn();
            EmailCollectors = new DataGridViewTextBoxColumn();
            RareCoins = new DataGridViewTextBoxColumn();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonSearch = new Button();
            labelFilter = new Label();
            labelCountryCoin = new Label();
            labelMaterial = new Label();
            labelYearFrom = new Label();
            labelYearTo = new Label();
            labelRareCoins = new Label();
            textBoxCountryCoin = new TextBox();
            textBoxMaterial = new TextBox();
            textBoxYearFrom = new TextBox();
            textBoxYearTo = new TextBox();
            textBoxRareCoins = new TextBox();
            buttonUse = new Button();
            buttonCancel = new Button();
            comboBoxCriterion = new ComboBox();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            buttonBack = new Button();
            textBoxCountryCollector = new TextBox();
            labelCountryCollector = new Label();
            labelForCollectors = new Label();
            labelForCoins = new Label();
            tabControl.SuspendLayout();
            CoinsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCoins).BeginInit();
            CollectorsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCollectors).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(CoinsPage);
            tabControl.Controls.Add(CollectorsPage);
            tabControl.Location = new Point(12, 68);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(960, 699);
            tabControl.TabIndex = 0;
            // 
            // CoinsPage
            // 
            CoinsPage.Controls.Add(dataGridViewCoins);
            CoinsPage.Location = new Point(4, 29);
            CoinsPage.Name = "CoinsPage";
            CoinsPage.Padding = new Padding(3);
            CoinsPage.Size = new Size(952, 666);
            CoinsPage.TabIndex = 0;
            CoinsPage.Text = "Монети";
            CoinsPage.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCoins
            // 
            dataGridViewCoins.AllowUserToAddRows = false;
            dataGridViewCoins.AllowUserToDeleteRows = false;
            dataGridViewCoins.AllowUserToResizeColumns = false;
            dataGridViewCoins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCoins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCoins.Columns.AddRange(new DataGridViewColumn[] { CountryCoins, YearCoins, MaterialCoins, CirculationCoins, FeaturesCoins });
            dataGridViewCoins.Dock = DockStyle.Fill;
            dataGridViewCoins.Location = new Point(3, 3);
            dataGridViewCoins.MultiSelect = false;
            dataGridViewCoins.Name = "dataGridViewCoins";
            dataGridViewCoins.ReadOnly = true;
            dataGridViewCoins.RowHeadersVisible = false;
            dataGridViewCoins.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCoins.Size = new Size(946, 660);
            dataGridViewCoins.TabIndex = 0;
            // 
            // CountryCoins
            // 
            CountryCoins.DataPropertyName = "Country";
            CountryCoins.HeaderText = "Країна";
            CountryCoins.Name = "CountryCoins";
            CountryCoins.ReadOnly = true;
            // 
            // YearCoins
            // 
            YearCoins.DataPropertyName = "Year";
            YearCoins.HeaderText = "Рік";
            YearCoins.Name = "YearCoins";
            YearCoins.ReadOnly = true;
            // 
            // MaterialCoins
            // 
            MaterialCoins.DataPropertyName = "Material";
            MaterialCoins.HeaderText = "Матеріал";
            MaterialCoins.Name = "MaterialCoins";
            MaterialCoins.ReadOnly = true;
            // 
            // CirculationCoins
            // 
            CirculationCoins.DataPropertyName = "Circulation";
            CirculationCoins.HeaderText = "Тираж";
            CirculationCoins.Name = "CirculationCoins";
            CirculationCoins.ReadOnly = true;
            // 
            // FeaturesCoins
            // 
            FeaturesCoins.DataPropertyName = "Features";
            FeaturesCoins.HeaderText = "Особливості";
            FeaturesCoins.Name = "FeaturesCoins";
            FeaturesCoins.ReadOnly = true;
            // 
            // CollectorsPage
            // 
            CollectorsPage.Controls.Add(dataGridViewCollectors);
            CollectorsPage.Location = new Point(4, 29);
            CollectorsPage.Name = "CollectorsPage";
            CollectorsPage.Padding = new Padding(3);
            CollectorsPage.Size = new Size(952, 666);
            CollectorsPage.TabIndex = 1;
            CollectorsPage.Text = "Колекціонери";
            CollectorsPage.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCollectors
            // 
            dataGridViewCollectors.AllowUserToAddRows = false;
            dataGridViewCollectors.AllowUserToDeleteRows = false;
            dataGridViewCollectors.AllowUserToResizeColumns = false;
            dataGridViewCollectors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCollectors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCollectors.Columns.AddRange(new DataGridViewColumn[] { LastNameCollectors, NameCollectors, CountryCollectors, PhoneCollectors, EmailCollectors, RareCoins });
            dataGridViewCollectors.Dock = DockStyle.Fill;
            dataGridViewCollectors.Location = new Point(3, 3);
            dataGridViewCollectors.MultiSelect = false;
            dataGridViewCollectors.Name = "dataGridViewCollectors";
            dataGridViewCollectors.ReadOnly = true;
            dataGridViewCollectors.RowHeadersVisible = false;
            dataGridViewCollectors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCollectors.Size = new Size(946, 660);
            dataGridViewCollectors.TabIndex = 0;
            // 
            // LastNameCollectors
            // 
            LastNameCollectors.DataPropertyName = "LastName";
            LastNameCollectors.HeaderText = "Прізвище";
            LastNameCollectors.Name = "LastNameCollectors";
            LastNameCollectors.ReadOnly = true;
            // 
            // NameCollectors
            // 
            NameCollectors.DataPropertyName = "FirstName";
            NameCollectors.HeaderText = "Ім’я";
            NameCollectors.Name = "NameCollectors";
            NameCollectors.ReadOnly = true;
            // 
            // CountryCollectors
            // 
            CountryCollectors.DataPropertyName = "Country";
            CountryCollectors.HeaderText = "Країна";
            CountryCollectors.Name = "CountryCollectors";
            CountryCollectors.ReadOnly = true;
            // 
            // PhoneCollectors
            // 
            PhoneCollectors.DataPropertyName = "PhoneNumber";
            PhoneCollectors.HeaderText = "Телефон";
            PhoneCollectors.Name = "PhoneCollectors";
            PhoneCollectors.ReadOnly = true;
            // 
            // EmailCollectors
            // 
            EmailCollectors.DataPropertyName = "Email";
            EmailCollectors.HeaderText = "Пошта";
            EmailCollectors.Name = "EmailCollectors";
            EmailCollectors.ReadOnly = true;
            // 
            // RareCoins
            // 
            RareCoins.DataPropertyName = "RareCoinsInfo";
            RareCoins.HeaderText = "Рідкісні монети";
            RareCoins.Name = "RareCoins";
            RareCoins.ReadOnly = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(805, 25);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(139, 37);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(967, 25);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(137, 37);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "Редагувати";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(1128, 25);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(129, 37);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Видалити";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(405, 25);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(100, 40);
            buttonSearch.TabIndex = 5;
            buttonSearch.Text = "Шукати";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(994, 97);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(84, 20);
            labelFilter.TabIndex = 6;
            labelFilter.Text = "Фільтрація";
            // 
            // labelCountryCoin
            // 
            labelCountryCoin.AutoSize = true;
            labelCountryCoin.Location = new Point(994, 182);
            labelCountryCoin.Name = "labelCountryCoin";
            labelCountryCoin.Size = new Size(56, 20);
            labelCountryCoin.TabIndex = 7;
            labelCountryCoin.Text = "Країна";
            // 
            // labelMaterial
            // 
            labelMaterial.AutoSize = true;
            labelMaterial.Location = new Point(994, 229);
            labelMaterial.Name = "labelMaterial";
            labelMaterial.Size = new Size(73, 20);
            labelMaterial.TabIndex = 8;
            labelMaterial.Text = "Матеріал";
            // 
            // labelYearFrom
            // 
            labelYearFrom.AutoSize = true;
            labelYearFrom.Location = new Point(994, 274);
            labelYearFrom.Name = "labelYearFrom";
            labelYearFrom.Size = new Size(52, 20);
            labelYearFrom.TabIndex = 9;
            labelYearFrom.Text = "Рік від";
            // 
            // labelYearTo
            // 
            labelYearTo.AutoSize = true;
            labelYearTo.Location = new Point(996, 320);
            labelYearTo.Name = "labelYearTo";
            labelYearTo.Size = new Size(49, 20);
            labelYearTo.TabIndex = 10;
            labelYearTo.Text = "Рік до";
            // 
            // labelRareCoins
            // 
            labelRareCoins.AutoSize = true;
            labelRareCoins.Location = new Point(994, 442);
            labelRareCoins.Name = "labelRareCoins";
            labelRareCoins.Size = new Size(116, 20);
            labelRareCoins.TabIndex = 11;
            labelRareCoins.Text = "Рідкісні монети";
            // 
            // textBoxCountryCoin
            // 
            textBoxCountryCoin.Location = new Point(1128, 179);
            textBoxCountryCoin.Name = "textBoxCountryCoin";
            textBoxCountryCoin.Size = new Size(129, 27);
            textBoxCountryCoin.TabIndex = 12;
            // 
            // textBoxMaterial
            // 
            textBoxMaterial.Location = new Point(1128, 226);
            textBoxMaterial.Name = "textBoxMaterial";
            textBoxMaterial.Size = new Size(129, 27);
            textBoxMaterial.TabIndex = 13;
            // 
            // textBoxYearFrom
            // 
            textBoxYearFrom.Location = new Point(1128, 271);
            textBoxYearFrom.Name = "textBoxYearFrom";
            textBoxYearFrom.Size = new Size(129, 27);
            textBoxYearFrom.TabIndex = 14;
            // 
            // textBoxYearTo
            // 
            textBoxYearTo.Location = new Point(1128, 317);
            textBoxYearTo.Name = "textBoxYearTo";
            textBoxYearTo.Size = new Size(129, 27);
            textBoxYearTo.TabIndex = 15;
            // 
            // textBoxRareCoins
            // 
            textBoxRareCoins.Location = new Point(996, 484);
            textBoxRareCoins.Multiline = true;
            textBoxRareCoins.Name = "textBoxRareCoins";
            textBoxRareCoins.Size = new Size(261, 91);
            textBoxRareCoins.TabIndex = 16;
            // 
            // buttonUse
            // 
            buttonUse.Location = new Point(996, 721);
            buttonUse.Name = "buttonUse";
            buttonUse.Size = new Size(124, 39);
            buttonUse.TabIndex = 17;
            buttonUse.Text = "Застосувати";
            buttonUse.UseVisualStyleBackColor = true;
            buttonUse.Click += buttonUse_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(1133, 721);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(124, 39);
            buttonCancel.TabIndex = 18;
            buttonCancel.Text = "Скинути";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // comboBoxCriterion
            // 
            comboBoxCriterion.FormattingEnabled = true;
            comboBoxCriterion.Location = new Point(254, 32);
            comboBoxCriterion.Name = "comboBoxCriterion";
            comboBoxCriterion.Size = new Size(124, 28);
            comboBoxCriterion.TabIndex = 19;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(12, 9);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(55, 20);
            labelSearch.TabIndex = 20;
            labelSearch.Text = "Пошук";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(12, 32);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(225, 27);
            textBoxSearch.TabIndex = 21;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(511, 25);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(110, 40);
            buttonBack.TabIndex = 22;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // textBoxCountryCollector
            // 
            textBoxCountryCollector.Location = new Point(1128, 598);
            textBoxCountryCollector.Name = "textBoxCountryCollector";
            textBoxCountryCollector.Size = new Size(129, 27);
            textBoxCountryCollector.TabIndex = 24;
            // 
            // labelCountryCollector
            // 
            labelCountryCollector.AutoSize = true;
            labelCountryCollector.Location = new Point(994, 601);
            labelCountryCollector.Name = "labelCountryCollector";
            labelCountryCollector.Size = new Size(56, 20);
            labelCountryCollector.TabIndex = 23;
            labelCountryCollector.Text = "Країна";
            // 
            // labelForCollectors
            // 
            labelForCollectors.AutoSize = true;
            labelForCollectors.Location = new Point(996, 405);
            labelForCollectors.Name = "labelForCollectors";
            labelForCollectors.Size = new Size(141, 20);
            labelForCollectors.TabIndex = 25;
            labelForCollectors.Text = "Для колекціонерів:";
            // 
            // labelForCoins
            // 
            labelForCoins.AutoSize = true;
            labelForCoins.Location = new Point(994, 141);
            labelForCoins.Name = "labelForCoins";
            labelForCoins.Size = new Size(85, 20);
            labelForCoins.TabIndex = 26;
            labelForCoins.Text = "Для монет:";
            // 
            // mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 779);
            Controls.Add(labelForCoins);
            Controls.Add(labelForCollectors);
            Controls.Add(textBoxCountryCollector);
            Controls.Add(labelCountryCollector);
            Controls.Add(buttonBack);
            Controls.Add(textBoxSearch);
            Controls.Add(labelSearch);
            Controls.Add(comboBoxCriterion);
            Controls.Add(buttonCancel);
            Controls.Add(buttonUse);
            Controls.Add(textBoxRareCoins);
            Controls.Add(textBoxYearTo);
            Controls.Add(textBoxYearFrom);
            Controls.Add(textBoxMaterial);
            Controls.Add(textBoxCountryCoin);
            Controls.Add(labelRareCoins);
            Controls.Add(labelYearTo);
            Controls.Add(labelYearFrom);
            Controls.Add(labelMaterial);
            Controls.Add(labelCountryCoin);
            Controls.Add(labelFilter);
            Controls.Add(buttonSearch);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(tabControl);
            Name = "mainform";
            Text = "Довідник нумізмата";
            FormClosing += mainform_Close;
            Load += mainform_Load;
            tabControl.ResumeLayout(false);
            CoinsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCoins).EndInit();
            CollectorsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCollectors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage CoinsPage;
        private TabPage CollectorsPage;
        private DataGridView dataGridViewCoins;
        private DataGridView dataGridViewCollectors;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonSearch;
        private DataGridViewTextBoxColumn CountryCoins;
        private DataGridViewTextBoxColumn YearCoins;
        private DataGridViewTextBoxColumn MaterialCoins;
        private DataGridViewTextBoxColumn CirculationCoins;
        private DataGridViewTextBoxColumn FeaturesCoins;
        private DataGridViewTextBoxColumn LastNameCollectors;
        private DataGridViewTextBoxColumn NameCollectors;
        private DataGridViewTextBoxColumn CountryCollectors;
        private DataGridViewTextBoxColumn PhoneCollectors;
        private DataGridViewTextBoxColumn EmailCollectors;
        private DataGridViewTextBoxColumn RareCoins;
        private Label labelFilter;
        private Label labelCountryCoin;
        private Label labelMaterial;
        private Label labelYearFrom;
        private Label labelYearTo;
        private Label labelRareCoins;
        private TextBox textBoxCountryCoin;
        private TextBox textBoxMaterial;
        private TextBox textBoxYearFrom;
        private TextBox textBoxYearTo;
        private TextBox textBoxRareCoins;
        private Button buttonUse;
        private Button buttonCancel;
        private ComboBox comboBoxCriterion;
        private Label labelSearch;
        private TextBox textBoxSearch;
        private Button buttonBack;
        private TextBox textBoxCountryCollector;
        private Label labelCountryCollector;
        private Label labelForCollectors;
        private Label labelForCoins;
    }
}
