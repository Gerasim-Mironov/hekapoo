using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mount_sinai
{
    public partial class Form1 : Form
    {
        int x { get; set; }
        int y { get; set; }
        int staticNum { get; set; } = 1;

        public Form1()
        {
            InitializeComponent();
            this.MouseUp += MyMouseUp;
            this.MouseDown += MyMouseDown;
        }

        private void MyMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
        }
        private void MyMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label lang = new Label();
                lang.BorderStyle = BorderStyle.Fixed3D;
                if (e.X > x && e.Y > y)
                {
                    lang.Location = new Point(x, y);
                }
                else if (e.X > x && e.Y < y)
                {
                    lang.Location = new Point(x, e.Y);
                }
                else if (e.X < x && e.Y < y)
                {
                    lang.Location = new Point(e.X, e.Y);
                }
                else
                {
                    lang.Location = new Point(e.X, y);
                }

                if (Math.Abs(e.X - x) <= 10 || Math.Abs(e.Y - y) <= 10)
                {
                    MessageBox.Show("поле не может быть меньше чем 10x 10.", "your first error");
                }
                else
                {
                    lang.Size = new Size(Math.Abs(e.X - x), Math.Abs(e.Y - y));
                    lang.Text = $"{staticNum}";
                    lang.ForeColor = Color.Blue;
                    lang.BackColor = Color.Yellow;
                    Controls.Add(lang);
                    lang.MouseClick += langMouseClick;
                    lang.MouseDoubleClick += langlMouseDoubleClick;

                    staticNum++;
                }
            }
            else
            {
                MessageBox.Show("зажми левую кнопку мыши чтобы создать поле.", "your new error");
            }
        }

        private void langMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (Label item in Controls)
                {
                    Point spot = item.PointToScreen(Point.Empty);
                    if (MousePosition.X > spot.X && MousePosition.X < spot.X + item.Width && MousePosition.Y > spot.Y && MousePosition.Y < spot.Y + item.Height)
                    {
                        Text = $"статическое поле номер {item.Text}, площадь- {item.Width * item.Height}, координаты: x= {item.Location.X}, y= {item.Location.Y}";
                    }
                }
            }
        }

        private void langlMouseDoubleClick(object sender, MouseEventArgs e)
        {
            int mtd = staticNum;
            if (e.Button == MouseButtons.Left)
            {
                foreach (Label item in Controls)
                {
                    Point location = item.PointToScreen(Point.Empty);
                    if (MousePosition.X > location.X && MousePosition.X < location.X + item.Width && MousePosition.Y > location.Y && MousePosition.Y < location.Y + item.Height)
                    {
                        if (mtd > Convert.ToInt32(item.Text))
                        {
                            mtd = Convert.ToInt32(item.Text);
                        }
                    }
                }
                foreach (Label item in Controls)
                {
                    if (mtd == Convert.ToInt32(item.Text))
                    {
                        Text = $"статическое поле номер {item.Text} удалено.";
                        Controls.Remove(item);
                        item.MouseClick -= langMouseClick;
                        item.MouseDoubleClick -= langlMouseDoubleClick;
                    }
                }
            }
        }
    }
}
