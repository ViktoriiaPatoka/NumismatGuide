using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NumismatGuide
{
    public partial class formeditcollector : Form
    {

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Collector UpdatedCollector { get; set; }

        public formeditcollector(Collector collector)
        {
            InitializeComponent();

            textBoxLastName.Text = collector.LastName;
            textBoxName.Text = collector.FirstName;
            textBoxCountry.Text = collector.Country;
            textBoxPhone.Text = collector.PhoneNumber;
            textBoxEmail.Text = collector.Email;
            textBoxRareCoin.Text = collector.RareCoinsInfo;
        }
        public formeditcollector()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UpdatedCollector = new Collector
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
