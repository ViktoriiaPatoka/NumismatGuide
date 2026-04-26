namespace NumismatGuide
{
    partial class formaddcoin
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
            labelCountry = new Label();
            labelYear = new Label();
            labelMaterial = new Label();
            labelCirculation = new Label();
            labelFeatures = new Label();
            textBoxCountry = new TextBox();
            textBoxYear = new TextBox();
            textBoxMaterial = new TextBox();
            textBoxCirculation = new TextBox();
            textBoxFeatures = new TextBox();
            buttonSave = new Button();
            buttonEdit = new Button();
            SuspendLayout();
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(35, 37);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(56, 20);
            labelCountry.TabIndex = 0;
            labelCountry.Text = "Країна";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(35, 86);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(86, 20);
            labelYear.TabIndex = 1;
            labelYear.Text = "Рік випуску";
            // 
            // labelMaterial
            // 
            labelMaterial.AutoSize = true;
            labelMaterial.Location = new Point(35, 140);
            labelMaterial.Name = "labelMaterial";
            labelMaterial.Size = new Size(73, 20);
            labelMaterial.TabIndex = 2;
            labelMaterial.Text = "Матеріал";
            // 
            // labelCirculation
            // 
            labelCirculation.AutoSize = true;
            labelCirculation.Location = new Point(35, 195);
            labelCirculation.Name = "labelCirculation";
            labelCirculation.Size = new Size(54, 20);
            labelCirculation.TabIndex = 3;
            labelCirculation.Text = "Тираж";
            // 
            // labelFeatures
            // 
            labelFeatures.AutoSize = true;
            labelFeatures.Location = new Point(35, 247);
            labelFeatures.Name = "labelFeatures";
            labelFeatures.Size = new Size(96, 20);
            labelFeatures.TabIndex = 4;
            labelFeatures.Text = "Особливості";
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(147, 34);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(269, 27);
            textBoxCountry.TabIndex = 5;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(147, 83);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(269, 27);
            textBoxYear.TabIndex = 6;
            // 
            // textBoxMaterial
            // 
            textBoxMaterial.Location = new Point(147, 137);
            textBoxMaterial.Name = "textBoxMaterial";
            textBoxMaterial.Size = new Size(269, 27);
            textBoxMaterial.TabIndex = 7;
            // 
            // textBoxCirculation
            // 
            textBoxCirculation.Location = new Point(147, 192);
            textBoxCirculation.Name = "textBoxCirculation";
            textBoxCirculation.Size = new Size(269, 27);
            textBoxCirculation.TabIndex = 8;
            // 
            // textBoxFeatures
            // 
            textBoxFeatures.Location = new Point(147, 244);
            textBoxFeatures.Name = "textBoxFeatures";
            textBoxFeatures.Size = new Size(269, 27);
            textBoxFeatures.TabIndex = 9;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(35, 306);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(107, 40);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(186, 306);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(103, 40);
            buttonEdit.TabIndex = 11;
            buttonEdit.Text = "Скасувати";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // formaddcoin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 412);
            Controls.Add(buttonEdit);
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
            Name = "formaddcoin";
            Text = "Додавання монети";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCountry;
        private Label labelYear;
        private Label labelMaterial;
        private Label labelCirculation;
        private Label labelFeatures;
        private TextBox textBoxCountry;
        private TextBox textBoxYear;
        private TextBox textBoxMaterial;
        private TextBox textBoxCirculation;
        private TextBox textBoxFeatures;
        private Button buttonSave;
        private Button buttonEdit;
    }
}