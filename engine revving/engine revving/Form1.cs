using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace engine_revving
{
    public partial class Form1 : Form
    {
        private List<Gas> gas;
        private List<Food> food;

        private List<CheckBox> checkBoxes;
        private List<TextBox> textBoxes;
        private List<TextBox> amountTextBoxes;
        public Form1()
        {
            InitializeComponent();
            gas = new List<Gas>
            {
                new Gas{name= "A- 95", value=22.40m},
                new Gas{name= "A- 98", value= 25.30m},
                new Gas{name= "DIEsel", value=19.60m},
                new Gas{name= "Gasoline", value= 6.20m}
            };
            food = new List<Food>
            {
                new Food{name= "Hot dog", value= 12.00m},
                new Food{name= "Cupcake", value= 14.00m},
                new Food{name= "Tea", value= 8.00m},
                new Food{name= "Coffee", value=6.50m}
            };

            checkBoxes = new List<CheckBox>
            {
                checkBox1, checkBox2, checkBox3, checkBox4
            };
            textBoxes = new List<TextBox>
            {
                textBox4, textBox7, textBox9, textBox11
            };
            amountTextBoxes = new List<TextBox>
            {
                textBox5, textBox6, textBox8, textBox10
            };


            foreach (Gas item in gas)
            {
                comboBox1.Items.Add(item.name);
            }
            comboBox1.SelectedIndex = 0;

            for (int i = 0; i < food.Count; i++)
            {
                checkBoxes[i].Text = food[i].name;
                textBoxes[i].Text = Convert.ToString(food[i].value);
            }

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Gas item in gas)
            {
                if(comboBox1.Text == item.name)
                {
                    textBox1.Text = Convert.ToString(item.value);
                }
            }
        }

        private void costButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                decimal price = Convert.ToDecimal(textBox1.Text) * Convert.ToDecimal(textBox2.Text);
                label3.Text = Convert.ToString(price);
                label3.Visible = true;
            }
            catch(Exception)
            {
                MessageBox.Show("No need to roam where you are not asked to.", "Notice");
            }
        }

        private void amountButton_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                textBox5.ReadOnly = false;
            }
            else
            {
                textBox5.ReadOnly= true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox6.ReadOnly = false;
            }
            else
            {
                textBox6.ReadOnly = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox8.ReadOnly = false;
            }
            else
            {
                textBox8.ReadOnly = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox10.ReadOnly = false;
            }
            else
            {
                textBox10.ReadOnly = true;
            }
        }

        private void getCheck_Click(object sender, EventArgs e)
        {
            if(costButton.Checked == false)
            {
                decimal price = Convert.ToDecimal(textBox1.Text) * Convert.ToDecimal(textBox2.Text);
                label3.Text = Convert.ToString(price);
                label3.Visible = true;
            }

            decimal labelNum = Convert.ToDecimal(label4.Text);

            List<decimal> mio = new List<decimal>();
            for (int i = 0; i < textBoxes.Count; i++)
            {
                mio.Add((Convert.ToDecimal(textBoxes[i].Text) * Convert.ToDecimal(amountTextBoxes[i].Text)));
                labelNum += mio[i];
            }

            label4.Text = Convert.ToString(labelNum);
            label4.Visible = true;

            decimal mtd = Convert.ToDecimal(label3.Text);
            labelNum += mtd;
            totalPrice.Text = Convert.ToString(labelNum);
        }
    }


    class Gas
    {
        public string name { get; set; }
        public decimal value { get; set; }
    }
    class Food
    {
        public string name { get; set; }
        public decimal value { get; set; }
    }
}
