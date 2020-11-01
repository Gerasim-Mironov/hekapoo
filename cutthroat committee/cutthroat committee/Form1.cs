using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cutthroat_committee
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

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime unl = new DateTime();
                unl = DateTime.Parse(textBox1.Text);
                DateTime mtd = new DateTime();
                mtd = DateTime.Now;
                TimeSpan mz = unl - mtd;
                if(unl > mtd)
                {
                    if (yearButton.Checked == true)
                    {
                        result.Text = (mz.TotalDays / 365).ToString();
                    }
                    if (monthsButton.Checked == true)
                    {
                        result.Text = (mz.TotalDays / 30).ToString();
                    }
                    if (daysButton.Checked == true)
                    {
                        result.Text = ((int)mz.TotalDays).ToString();
                    }
                    if (minutesButton.Checked == true)
                    {
                        result.Text = ((int)mz.TotalMinutes).ToString();
                    }
                    if (yearButton.Checked == true)
                    {
                        result.Text = ((int)mz.TotalMilliseconds).ToString();
                    }
                   
                    result.Visible = true;
                }
                else
                {
                    result.Text = "этот час уже пробил.";
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Sorry to deny you a moment of primate triumph, but you'll have to go elsewhere to sound your barbaric yawp.", "your failure");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result.Clear();
            result.Visible = false;
        }
    }
}
