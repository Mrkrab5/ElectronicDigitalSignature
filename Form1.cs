using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicDigitalSignature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void choiseMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (choiseMethod.SelectedIndex == 0)
                result.Text = ElGamal.Decoding(entryMassenge.Text);
            else
                result.Text = RSA.Decoding(entryMassenge.Text);
        }
    }
}
