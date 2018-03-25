using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Угадай число";
        }

        int a = 0;
        int b = 0;
        int x = 0;

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        int y = 0; 
        private void Play_btn_Click(object sender, EventArgs e)
        {
            if (Number_a_UpDown.Value>Number_b_UpDown.Value)
            {
                MessageBox.Show("Введите корректный интервал", "Ошибка");
            }
            else if (Search_Number_UpDown.Value > Number_b_UpDown.Value || Search_Number_UpDown.Value < Number_a_UpDown.Value)
            {
                MessageBox.Show("Загадайте число в рамках интервала", "Ошибка");
            }
            else
            {
                y = (int)((Number_a_UpDown.Value + Number_b_UpDown.Value) / 2);
                Answer_lbl.Text = y.ToString();
                N_lbl.Text = (int.Parse(N_lbl.Text) + 1).ToString();
            }
        }

        private void Win_lbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ура! Игра завершена", "Число угадано!");
            Close();
        }

        private void Over_btn_Click(object sender, EventArgs e)
        {
            Number_a_UpDown.Value = y;
            y = (int)((Number_a_UpDown.Value + Number_b_UpDown.Value) / 2);
            Answer_lbl.Text = y.ToString();
            N_lbl.Text = (int.Parse(N_lbl.Text) + 1).ToString();
        }

        private void Under_btn_Click(object sender, EventArgs e)
        {
            Number_b_UpDown.Value = y;
            y = (int)((Number_a_UpDown.Value + Number_b_UpDown.Value) / 2);
            Answer_lbl.Text = y.ToString();
            N_lbl.Text = (int.Parse(N_lbl.Text) + 1).ToString();
        }
    }
}
