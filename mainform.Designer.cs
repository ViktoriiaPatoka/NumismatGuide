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
            tabControl1 = new TabControl();
            CoinsPage = new TabPage();
            dataGridViewCoins = new DataGridView();
            CountryCoins = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Material = new DataGridViewTextBoxColumn();
            Circulation = new DataGridViewTextBoxColumn();
            Features = new DataGridViewTextBoxColumn();
            CollectorsPage = new TabPage();
            dataGridViewCollectors = new DataGridView();
            Lastname = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            CountryCollectors = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            RareCoins = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            tabControl1.SuspendLayout();
            CoinsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCoins).BeginInit();
            CollectorsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCollectors).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(CoinsPage);
            tabControl1.Controls.Add(CollectorsPage);
            tabControl1.Location = new Point(12, 68);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1264, 699);
            tabControl1.TabIndex = 0;
            // 
            // CoinsPage
            // 
            CoinsPage.Controls.Add(dataGridViewCoins);
            CoinsPage.Location = new Point(4, 29);
            CoinsPage.Name = "CoinsPage";
            CoinsPage.Padding = new Padding(3);
            CoinsPage.Size = new Size(1256, 666);
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
            dataGridViewCoins.Columns.AddRange(new DataGridViewColumn[] { CountryCoins, Year, Material, Circulation, Features });
            dataGridViewCoins.Dock = DockStyle.Fill;
            dataGridViewCoins.Location = new Point(3, 3);
            dataGridViewCoins.MultiSelect = false;
            dataGridViewCoins.Name = "dataGridViewCoins";
            dataGridViewCoins.ReadOnly = true;
            dataGridViewCoins.RowHeadersVisible = false;
            dataGridViewCoins.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCoins.Size = new Size(1250, 660);
            dataGridViewCoins.TabIndex = 0;
            // 
            // CountryCoins
            // 
            CountryCoins.HeaderText = "Країна";
            CountryCoins.Name = "CountryCoins";
            CountryCoins.ReadOnly = true;
            // 
            // Year
            // 
            Year.HeaderText = "Рік";
            Year.Name = "Year";
            Year.ReadOnly = true;
            // 
            // Material
            // 
            Material.HeaderText = "Матеріал";
            Material.Name = "Material";
            Material.ReadOnly = true;
            // 
            // Circulation
            // 
            Circulation.HeaderText = "Тираж";
            Circulation.Name = "Circulation";
            Circulation.ReadOnly = true;
            // 
            // Features
            // 
            Features.HeaderText = "Особливості";
            Features.Name = "Features";
            Features.ReadOnly = true;
            // 
            // CollectorsPage
            // 
            CollectorsPage.Controls.Add(dataGridViewCollectors);
            CollectorsPage.Location = new Point(4, 29);
            CollectorsPage.Name = "CollectorsPage";
            CollectorsPage.Padding = new Padding(3);
            CollectorsPage.Size = new Size(1256, 666);
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
            dataGridViewCollectors.Columns.AddRange(new DataGridViewColumn[] { Lastname, Name, CountryCollectors, Phone, Email, RareCoins });
            dataGridViewCollectors.Dock = DockStyle.Fill;
            dataGridViewCollectors.Location = new Point(3, 3);
            dataGridViewCollectors.MultiSelect = false;
            dataGridViewCollectors.Name = "dataGridViewCollectors";
            dataGridViewCollectors.ReadOnly = true;
            dataGridViewCollectors.RowHeadersVisible = false;
            dataGridViewCollectors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCollectors.Size = new Size(1250, 660);
            dataGridViewCollectors.TabIndex = 0;
            // 
            // Lastname
            // 
            Lastname.HeaderText = "Прізвище";
            Lastname.Name = "Lastname";
            Lastname.ReadOnly = true;
            // 
            // Name
            // 
            Name.HeaderText = "Ім’я";
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // CountryCollectors
            // 
            CountryCollectors.HeaderText = "Країна";
            CountryCollectors.Name = "CountryCollectors";
            CountryCollectors.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.HeaderText = "Телефон";
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Пошта";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // RareCoins
            // 
            RareCoins.HeaderText = "Рідкісні монети";
            RareCoins.Name = "RareCoins";
            RareCoins.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(19, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(526, 50);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пошук";
            // 
            // button1
            // 
            button1.Location = new Point(805, 25);
            button1.Name = "button1";
            button1.Size = new Size(139, 37);
            button1.TabIndex = 2;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(967, 25);
            button2.Name = "button2";
            button2.Size = new Size(137, 37);
            button2.TabIndex = 3;
            button2.Text = "Редагувати";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1128, 25);
            button3.Name = "button3";
            button3.Size = new Size(129, 37);
            button3.TabIndex = 4;
            button3.Text = "Видалити";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(563, 22);
            button4.Name = "button4";
            button4.Size = new Size(100, 40);
            button4.TabIndex = 5;
            button4.Text = "Шукати";
            button4.UseVisualStyleBackColor = true;
            // 
            // mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 779);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(tabControl1);
            Name = "mainform";
            Text = "Довідник нумізмата";
            tabControl1.ResumeLayout(false);
            CoinsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCoins).EndInit();
            CollectorsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCollectors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage CoinsPage;
        private TabPage CollectorsPage;
        private DataGridView dataGridViewCoins;
        private DataGridViewTextBoxColumn CountryCoins;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Material;
        private DataGridViewTextBoxColumn Circulation;
        private DataGridViewTextBoxColumn Features;
        private DataGridView dataGridViewCollectors;
        private DataGridViewTextBoxColumn Lastname;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn CountryCollectors;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn RareCoins;
        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
