using JenkinsTEst.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JenkinsTEst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // added a minor change.
            label1.Text = "Version 1.5.3";
        }

        private void btAddition_Click(object sender, EventArgs e)
        {
            int iOperant1 = Int32.Parse(tbOperant1.Text);
            int iOperant2 = Int32.Parse(tbOperant2.Text);

            tbResultat.Text = new MathModel().doAddition(iOperant1, iOperant2).ToString();
        }

        private void btSubtraktion_Click(object sender, EventArgs e)
        {
            int iOperant1 = Int32.Parse(tbOperant1.Text);
            int iOperant2 = Int32.Parse(tbOperant2.Text);

            tbResultat.Text = new MathModel().doSubtraktion(iOperant1, iOperant2).ToString();
        }

        private void btMultiplikation_Click(object sender, EventArgs e)
        {
            int iOperant1 = Int32.Parse(tbOperant1.Text);
            int iOperant2 = Int32.Parse(tbOperant2.Text);

            tbResultat.Text = new MathModel().doMultiplikation(iOperant1, iOperant2).ToString();

        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            int iOperant1 = Int32.Parse(tbOperant1.Text);
            int iOperant2 = Int32.Parse(tbOperant2.Text);

            tbResultat.Text = new MathModel().doDivision(iOperant1, iOperant2).ToString();
        }
    }
}
