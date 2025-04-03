using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_assignment_2
{
    public partial class FormCalculations : Form
    {
        
        public FormCalculations()
        {
            InitializeComponent();
        }

        //Not sure why this is here. Not sure how to get rid of it without everything breaking
        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblExpression.Text = "7 + 7 = " + (7 + 7);
            btnPlus.Enabled = false;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lblExpression.Text = "7 - 7 = " + (7 - 7);
            btnMinus.Enabled = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblExpression.Text = "7 * 7 = " + (7 * 7);
            btnMultiply.Enabled = false;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            lblExpression.Text = "7 / 7 = " + (7 / 7);
            btnDivide.Enabled = false;
        }
    }
}
