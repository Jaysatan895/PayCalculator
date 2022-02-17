using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayCalculator
{
    public partial class Form1 : Form
    {
        double hours = 0;
        double payRate = 0;
        double pretax = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            hours = Convert.ToDouble(hoursInput.Text);
            payRate = Convert.ToDouble(payInput.Text);

            pretax = hours * payRate;

            pretaxOutput.Text = $"${pretax}";
        }
    }
}
