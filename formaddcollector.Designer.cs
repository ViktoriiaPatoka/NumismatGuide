namespace NumismatGuide
{
    partial class formaddcollector
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
            labelLastName = new Label();
            labelName = new Label();
            labelCountry = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            textBoxLastName = new TextBox();
            textBoxName = new TextBox();
            textBoxCountry = new TextBox();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            textBoxRareCoin = new TextBox();
            labelRareCoin = new Label();
            buttonSave = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(28, 33);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(77, 20);
            labelLastName.TabIndex = 0;
            labelLastName.Text = "Прізвище";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(28, 89);
            labelName.Name = "labelName";
            labelName.Size = new Size(35, 20);
            labelName.TabIndex = 1;
            labelName.Text = "Ім'я";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(28, 151);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(56, 20);
            labelCountry.TabIndex = 2;
            labelCountry.Text = "Країна";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(28, 211);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(127, 20);
            labelPhone.TabIndex = 3;
            labelPhone.Text = "Номер телефона";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(28, 270);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(138, 20);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Електронна пошта";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(177, 30);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(248, 27);
            textBoxLastName.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(177, 82);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(248, 27);
            textBoxName.TabIndex = 6;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(177, 144);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(248, 27);
            textBoxCountry.TabIndex = 7;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(177, 208);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(248, 27);
            textBoxPhone.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(177, 267);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(248, 27);
            textBoxEmail.TabIndex = 9;
            // 
            // textBoxRareCoin
            // 
            textBoxRareCoin.Location = new Point(247, 326);
            textBoxRareCoin.Multiline = true;
            textBoxRareCoin.Name = "textBoxRareCoin";
            textBoxRareCoin.Size = new Size(316, 97);
            textBoxRareCoin.TabIndex = 10;
            // 
            // labelRareCoin
            // 
            labelRareCoin.AutoSize = true;
            labelRareCoin.Location = new Point(28, 329);
            labelRareCoin.Name = "labelRareCoin";
            labelRareCoin.Size = new Size(193, 20);
            labelRareCoin.TabIndex = 11;
            labelRareCoin.Text = "Наявність рідкісних монет";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(28, 485);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 43);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(177, 485);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(111, 44);
            buttonExit.TabIndex = 13;
            buttonExit.Text = "Скасувати";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // formaddcollector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 597);
            Controls.Add(buttonExit);
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
            Name = "formaddcollector";
            Text = "Додавання колекціонера";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLastName;
        private Label labelName;
        private Label labelCountry;
        private Label labelPhone;
        private Label labelEmail;
        private TextBox textBoxLastName;
        private TextBox textBoxName;
        private TextBox textBoxCountry;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxRareCoin;
        private Label labelRareCoin;
        private Button buttonSave;
        private Button buttonExit;
    }
}