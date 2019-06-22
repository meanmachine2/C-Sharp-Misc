using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Currency_Converter
{
    public partial class CurrencyConverter : Form
    {
        public CurrencyConverter()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal bgn = this.numericUpDown.Value;
            decimal eur = bgn / 1.95583m;
            this.labelResult.Text = bgn + " BGN = " + Math.Round(eur,2) + " EUR";
        }

        private void LabelResult_Click(object sender, EventArgs e)
        {

        }
    }
}
