using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udvoitel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Удвоитель";
        }

        int result = 0;
        int n = 0;

        private void btnCmd1_Click(object sender, EventArgs e)
        {
            result = int.Parse(lblNumber.Text);
            n = int.Parse(lbl_N.Text);
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            lbl_N.Text = (int.Parse(lbl_N.Text) + 1).ToString();
        }

        private void btnCmd2_Click(object sender, EventArgs e)
        {
            result = int.Parse(lblNumber.Text);
            n = int.Parse(lbl_N.Text);
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            lbl_N.Text = (int.Parse(lbl_N.Text) + 1).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            result = 0;
            n = 0;
            lblNumber.Text = "0";
            lbl_N.Text = "0";
        }

        private void Play_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string msg = (rnd.Next(1, 100)).ToString();
            MessageBox.Show(msg, "Цель");
            Target_lbl.Text = msg;
            lblNumber.Text = "0";
            lbl_N.Text = "0";
            result = 0;
            n = 0;
        }

        private void Back_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblNumber.Text = result.ToString();
            lbl_N.Text = n.ToString();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
