using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cut_up_in_the_thirds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            this.MouseMove += MyMouseMove;
            this.MouseClick += MyMouseClick;
        }

        private void MyMouseClick(object sender, MouseEventArgs e)
        {
            string text;
            if (e.Button == MouseButtons.Left)
            {
                if (ModifierKeys == Keys.Control)
                {
                    Close();
                }

                if ((e.X < 10 || e.X > ClientSize.Width - 10) || (e.Y < 10 || e.Y > ClientSize.Height - 10))
                {
                    text = "нажал мимо прямоугольника.";
                }
                else if ((e.X == 10 || e.X == ClientSize.Width - 10) || (e.Y == 10 || e.Y == ClientSize.Height - 10))
                {
                    text = "нажал на грань прямоугольника.";
                }
                else
                {
                    text = "нажал на прямогольник.";
                }
                MessageBox.Show(text, "Info");
            }
            if (e.Button == MouseButtons.Right)
            {
                Text = $"размер клиентской области окна: ширина= {ClientSize.Width}, высота= {ClientSize.Height}";
                Thread.Sleep(3200);
            }
        }
        private void MyMouseMove(object sender, MouseEventArgs e)
        {
            Text = $"x= {e.X}, y= {e.Y}";
        }
    }
}
