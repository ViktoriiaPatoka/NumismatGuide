namespace NumismatGuide
{
    partial class formeditcollector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCancel = new Button();
            buttonSave = new Button();
            labelRareCoin = new Label();
            textBoxRareCoin = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            textBoxCountry = new TextBox();
            textBoxName = new TextBox();
            textBoxLastName = new TextBox();
            labelEmail = new Label();
            labelPhone = new Label();
            labelCountry = new Label();
            labelName = new Label();
            labelLastName = new Label();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(176, 488);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(111, 44);
            buttonCancel.TabIndex = 27;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(27, 488);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 43);
            buttonSave.TabIndex = 26;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelRareCoin
            // 
            labelRareCoin.AutoSize = true;
            labelRareCoin.Location = new Point(27, 332);
            labelRareCoin.Name = "labelRareCoin";
            labelRareCoin.Size = new Size(193, 20);
            labelRareCoin.TabIndex = 25;
            labelRareCoin.Text = "Наявність рідкісних монет";
            // 
            // textBoxRareCoin
            // 
            textBoxRareCoin.Location = new Point(246, 329);
            textBoxRareCoin.Multiline = true;
            textBoxRareCoin.Name = "textBoxRareCoin";
            textBoxRareCoin.Size = new Size(316, 97);
            textBoxRareCoin.TabIndex = 24;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(176, 270);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(248, 27);
            textBoxEmail.TabIndex = 23;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(176, 211);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(248, 27);
            textBoxPhone.TabIndex = 22;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(176, 147);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(248, 27);
            textBoxCountry.TabIndex = 21;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(176, 85);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(248, 27);
            textBoxName.TabIndex = 20;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(176, 33);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(248, 27);
            textBoxLastName.TabIndex = 19;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(27, 273);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(138, 20);
            labelEmail.TabIndex = 18;
            labelEmail.Text = "Електронна пошта";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(27, 214);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(127, 20);
            labelPhone.TabIndex = 17;
            labelPhone.Text = "Номер телефона";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(27, 154);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(56, 20);
            labelCountry.TabIndex = 16;
            labelCountry.Text = "Країна";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(27, 92);
            labelName.Name = "labelName";
            labelName.Size = new Size(35, 20);
            labelName.TabIndex = 15;
            labelName.Text = "Ім'я";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(27, 36);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(77, 20);
            labelLastName.TabIndex = 14;
            labelLastName.Text = "Прізвище";
            // 
            // formeditcollector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 642);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(labelRareCoin);
            Controls.Add(textBoxRareCoin);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxCountry);
            Controls.Add(textBoxName);
            Controls.Add(textBoxLastName);
            Controls.Add(labelEmail);
            Controls.Add(labelPhone);
            Controls.Add(labelCountry);
            Controls.Add(labelName);
            Controls.Add(labelLastName);
            Name = "formeditcollector";
            Text = "Редагувати колекціонера";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonSave;
        private Label labelRareCoin;
        private TextBox textBoxRareCoin;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private TextBox textBoxCountry;
        private TextBox textBoxName;
        private TextBox textBoxLastName;
        private Label labelEmail;
        private Label labelPhone;
        private Label labelCountry;
        private Label labelName;
        private Label labelLastName;
    }
}