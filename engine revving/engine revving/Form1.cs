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

            foreach (Gas item in gas)
            {
                comboBox1.Items.Add(item.name);
            }
            comboBox1.SelectedIndex = 0;

            

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
