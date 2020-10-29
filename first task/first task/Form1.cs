using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_task
{
    public partial class FormingHorns : Form
    {
        public FormingHorns()
        {
            InitializeComponent();
        }

        private void hell_o_Click(object sender, EventArgs e)
        {
            string firstMsg = "Я- Александр Тимченко.";
            string secondMsg = "мне 16 лет.";
            string thirdMsg = "я со скрипом учусь в шаге почти 11 месяцев";

            int divineNum = (firstMsg.Length + secondMsg.Length + thirdMsg.Length)/3;
            MessageBox.Show(null, firstMsg, $"lang is {divineNum}", 0);
            MessageBox.Show(null, secondMsg, $"lang is {divineNum}", 0);
            MessageBox.Show(null, thirdMsg, $"lang is {divineNum}", 0);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int number = rnd.Next(1, 2000);
                DialogResult mt = MessageBox.Show($"это {number}?.", "akinator ha- ha", MessageBoxButtons.YesNo);
                if(mt==DialogResult.Yes)
                {
                    MessageBox.Show("хахахаха, я так и знал", "akinator ha- ha");
                    break;
                }
            }
            MessageBox.Show("хватит врать!.", "akinator ha- ha");
        }
    }
}
