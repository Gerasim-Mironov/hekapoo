using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sixes_hissing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            result.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            result.Visible = true;
            if(textBox1.Text == "")
            {
                result.Text = dateTimePicker.Value.Date.ToString("dddd");
                textBox1.Text= dateTimePicker.Value.ToShortDateString();
            }
            else
            {
                try
                {
                    DateTime mtd = new DateTime();
                    mtd = DateTime.Parse(textBox1.Text);
                    result.Text = mtd.ToString("dddd");
                    dateTimePicker.Value = mtd;
                }
                catch(Exception)
                {
                    MessageBox.Show("nooooooooooo, what have you done?.", "your fault");
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result.Text = "";
            result.Visible = false;
            textBox1.BackColor = Color.White;
            dateTimePicker.Value = DateTime.Now;
        }      
    }
}
