using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelieveOrNotBelieve
{
    public partial class Form2 : Form
    {
        TrueFalse database;

        public Form2()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                lbl_QValue.Text = "1";
                lbl_QMax.Text = database.Count.ToString();
                rtb_Question.Text = database[Int32.Parse(lbl_QValue.Text)-1].Text;
            }
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(lbl_QValue.Text) <= Int32.Parse(lbl_QMax.Text))
            {
                if (database[Int32.Parse(lbl_QValue.Text) - 1].TrueFalse == true)
                {
                    lbl_True.Text = (Int32.Parse(lbl_True.Text) + 1).ToString();
                }
                else
                {
                    lbl_False.Text = (Int32.Parse(lbl_False.Text) + 1).ToString();
                }
            }                       

            if (Int32.Parse(lbl_QValue.Text)+1 > Int32.Parse(lbl_QMax.Text))
            {
                MessageBox.Show($"Игра завершена! Правильных ответов: {lbl_True.Text} из {lbl_QValue.Text}.", "Конец");
                lbl_True.Text = "0";
                lbl_False.Text = "0";
                lbl_QValue.Text = "1";
                lbl_QMax.Text = database.Count.ToString();
                rtb_Question.Text = database[Int32.Parse(lbl_QValue.Text) - 1].Text;
            }
            else
            {
                lbl_QValue.Text = (Int32.Parse(lbl_QValue.Text) + 1).ToString();
                rtb_Question.Text = database[Int32.Parse(lbl_QValue.Text) - 1].Text;
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(lbl_QValue.Text) <= Int32.Parse(lbl_QMax.Text))
            {
                if (database[Int32.Parse(lbl_QValue.Text) - 1].TrueFalse == false)
                {
                    lbl_True.Text = (Int32.Parse(lbl_True.Text) + 1).ToString();
                }
                else
                {
                    lbl_False.Text = (Int32.Parse(lbl_False.Text) + 1).ToString();
                }
            }

            if (Int32.Parse(lbl_QValue.Text) + 1 > Int32.Parse(lbl_QMax.Text))
            {                
                MessageBox.Show($"Игра завершена! Правильных ответов: {lbl_True.Text} из {lbl_QValue.Text}.", "Конец");
                lbl_True.Text = "0";
                lbl_False.Text = "0";
                lbl_QValue.Text = "1";
                lbl_QMax.Text = database.Count.ToString();
                rtb_Question.Text = database[Int32.Parse(lbl_QValue.Text) - 1].Text;             
            }
            else
            {
                lbl_QValue.Text = (Int32.Parse(lbl_QValue.Text) + 1).ToString();
                rtb_Question.Text = database[Int32.Parse(lbl_QValue.Text) - 1].Text;
            }
        }
    }
}
