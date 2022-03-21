using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBoxInput.Items.Contains(txtBoxInput.Text))
            {
                string kembar = "Input Kembar!";
                MessageBox.Show(kembar);
            }
            listBoxInput.Items.Add(txtBoxInput.Text);
        }

        private void listBoxInput_Click(object sender, EventArgs e)
        {
            labelOutputBeneran.Text = listBoxInput.Text;
        }
        private void radButtMerah_CheckedChanged(object sender, EventArgs e)
        {
            if (chckAktif.Checked)
            {
                if (radButtMerah.Checked)
                {
                    labelOutputBeneran.ForeColor = Color.Red;
                }
                else if (radButtBiru.Checked)
                {
                    labelOutputBeneran.ForeColor = Color.Blue;
                }
            }
        }
        private void radButtBiru_CheckedChanged(object sender, EventArgs e)
        {
            if (chckAktif.Checked)
            {
                if (radButtMerah.Checked)
                {
                    labelOutputBeneran.ForeColor = Color.Red;
                }
                else if (radButtBiru.Checked)
                {
                    labelOutputBeneran.ForeColor = Color.Blue;
                }
            }
        }
        private void chckAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (chckAktif.Checked)
            {
                if (radButtMerah.Checked)
                {
                    labelOutputBeneran.ForeColor = Color.Red;
                }
                else if (radButtBiru.Checked)
                {
                    labelOutputBeneran.ForeColor = Color.Blue;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxInput.Items.Clear();
            txtBoxInput.Clear();
        }
    }
}
