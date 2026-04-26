namespace NumismatGuide
{
    partial class formeditcoin
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
            buttonExit = new Button();
            buttonSave = new Button();
            textBoxFeatures = new TextBox();
            textBoxCirculation = new TextBox();
            textBoxMaterial = new TextBox();
            textBoxYear = new TextBox();
            textBoxCountry = new TextBox();
            labelFeatures = new Label();
            labelCirculation = new Label();
            labelMaterial = new Label();
            labelYear = new Label();
            labelCountry = new Label();
            SuspendLayout();
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(181, 305);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(103, 40);
            buttonExit.TabIndex = 23;
            buttonExit.Text = "Скасувати";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(30, 305);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(107, 40);
            buttonSave.TabIndex = 22;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxFeatures
            // 
            textBoxFeatures.Location = new Point(142, 243);
            textBoxFeatures.Name = "textBoxFeatures";
            textBoxFeatures.Size = new Size(269, 27);
            textBoxFeatures.TabIndex = 21;
            // 
            // textBoxCirculation
            // 
            textBoxCirculation.Location = new Point(142, 191);
            textBoxCirculation.Name = "textBoxCirculation";
            textBoxCirculation.Size = new Size(269, 27);
            textBoxCirculation.TabIndex = 20;
            // 
            // textBoxMaterial
            // 
            textBoxMaterial.Location = new Point(142, 136);
            textBoxMaterial.Name = "textBoxMaterial";
            textBoxMaterial.Size = new Size(269, 27);
            textBoxMaterial.TabIndex = 19;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(142, 82);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(269, 27);
            textBoxYear.TabIndex = 18;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(142, 33);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(269, 27);
            textBoxCountry.TabIndex = 17;
            // 
            // labelFeatures
            // 
            labelFeatures.AutoSize = true;
            labelFeatures.Location = new Point(30, 246);
            labelFeatures.Name = "labelFeatures";
            labelFeatures.Size = new Size(96, 20);
            labelFeatures.TabIndex = 16;
            labelFeatures.Text = "Особливості";
            // 
            // labelCirculation
            // 
            labelCirculation.AutoSize = true;
            labelCirculation.Location = new Point(30, 194);
            labelCirculation.Name = "labelCirculation";
            labelCirculation.Size = new Size(54, 20);
            labelCirculation.TabIndex = 15;
            labelCirculation.Text = "Тираж";
            // 
            // labelMaterial
            // 
            labelMaterial.AutoSize = true;
            labelMaterial.Location = new Point(30, 139);
            labelMaterial.Name = "labelMaterial";
            labelMaterial.Size = new Size(73, 20);
            labelMaterial.TabIndex = 14;
            labelMaterial.Text = "Матеріал";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(30, 85);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(86, 20);
            labelYear.TabIndex = 13;
            labelYear.Text = "Рік випуску";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(30, 36);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(56, 20);
            labelCountry.TabIndex = 12;
            labelCountry.Text = "Країна";
            // 
            // formeditcoin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 402);
            Controls.Add(buttonExit);
            Controls.Add(buttonSave);
            Controls.Add(textBoxFeatures);
            Controls.Add(textBoxCirculation);
            Controls.Add(textBoxMaterial);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxCountry);
            Controls.Add(labelFeatures);
            Controls.Add(labelCirculation);
            Controls.Add(labelMaterial);
            Controls.Add(labelYear);
            Controls.Add(labelCountry);
            Name = "formeditcoin";
            Text = "Редагування монети";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonExit;
        private Button buttonSave;
        private TextBox textBoxFeatures;
        private TextBox textBoxCirculation;
        private TextBox textBoxMaterial;
        private TextBox textBoxYear;
        private TextBox textBoxCountry;
        private Label labelFeatures;
        private Label labelCirculation;
        private Label labelMaterial;
        private Label labelYear;
        private Label labelCountry;
    }
}