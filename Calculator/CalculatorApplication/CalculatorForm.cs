using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;

namespace CalculatorApplication
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
            CalculatorHelper = new CalculatorHelper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculatorHelper.HandleButton1();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            DisplayTextBox.Text = CalculatorHelper.DisplayText;
        }

        protected CalculatorHelper CalculatorHelper { get; set; }
    }
}
