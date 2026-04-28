using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NumismatGuide
{
    public partial class formaddcollector : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Collector NewCollector { get; set; }

        public formaddcollector()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            NewCollector = new Collector
            {
                LastName = textBoxLastName.Text,
                FirstName = textBoxName.Text,
                Country = textBoxCountry.Text,
                PhoneNumber = textBoxPhone.Text,
                Email = textBoxEmail.Text,
                RareCoinsInfo = textBoxRareCoin.Text
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
