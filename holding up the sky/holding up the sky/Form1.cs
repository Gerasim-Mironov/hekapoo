using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace holding_up_the_sky
{
    public partial class Form1 : Form
    {
        Label lang;
        public Form1()
        {
            InitializeComponent();
            lang = new Label();
            this.Load += overcast;
            this.MouseMove += mouseMove;
        }

        private void overcast(object sender, EventArgs e)
        {
            lang.BorderStyle = BorderStyle.Fixed3D;
            lang.Size = new Size(60, 60);
            lang.Text = "static meadow";
            lang.TextAlign = ContentAlignment.MiddleCenter;
            lang.AutoSize = false;
            lang.ForeColor = Color.White;
            lang.BackColor = Color.Violet;
            Controls.Add(lang);
            langCenter(lang);
        }
        private void mouseMove(object sender, MouseEventArgs e)
        {
            if((e.X > lang.Location.X - 20 && e.X < lang.Location.X + lang.Width + 20) && (e.Y > lang.Location.Y - 20 && e.Y < lang.Location.Y + lang.Height + 20))
            {
                if(e.X > lang.Location.X - 20 && e.X < lang.Location.X)
                {
                    lang.Left += 10;
                }
                else if (e.X < lang.Location.X + lang.Width + 20 && e.X > lang.Location.X + lang.Width)
                {
                    lang.Left -= 10;
                }
                else if (e.Y > lang.Location.Y - 20 && e.Y < lang.Location.Y)
                {
                    lang.Top += 10;
                }
                else if (e.Y < lang.Location.Y + lang.Height + 20 && e.Y > lang.Location.Y + lang.Height)
                {
                    lang.Top -= 10;
                }
                if((lang.Location.X < 0 || lang.Location.X > ClientSize.Width - lang.Width) || (lang.Location.Y < 0 || lang.Location.Y > ClientSize.Height - lang.Height))
                {
                    langCenter(lang);
                }
            }
        }

        private void langCenter(Label lang)
        {
            lang.Left = (ClientSize.Width - lang.Size.Width) / 2;
            lang.Top = (ClientSize.Height - lang.Size.Height) / 2;
        }
    }
}
