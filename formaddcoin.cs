using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NumismatGuide
{
    public partial class formaddcoin : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Coin NewCoin { get; set; }
        public formaddcoin()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            NewCoin = new Coin
            {
                Country = textBoxCountry.Text,
                Year = Convert.ToInt32(textBoxYear.Text),
                Material = textBoxMaterial.Text,
                Circulation = Convert.ToInt32(textBoxCirculation.Text),
                Features = textBoxFeatures.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
