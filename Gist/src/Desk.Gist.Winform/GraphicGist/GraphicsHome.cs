using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desk.Gist.Winform.GraphicGist
{
    public partial class GraphicsHome : Form
    {
        System.Timers.Timer timer;
        private int maxX;
        private int maxY;
        public GraphicsHome()
        {
            InitializeComponent();
        }


        private void GraphicsHome_Load(object sender, EventArgs e)
        {
            maxX = pnlCanvas.Width;
            maxY = pnlCanvas.Height;
        }

        public void TimeOut(object source, System.Timers.ElapsedEventArgs e)
        {
            Draw2();
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            //timer = new System.Timers.Timer();
            //timer.Interval = 3000;
            //timer.Elapsed += new System.Timers.ElapsedEventHandler(TimeOut);
            //timer.AutoReset = true;
            //timer.Enabled = true;

            timer1.Interval = 3000;
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Draw2();
        }

        private void Draw()
        {
            Graphics g = pnlCanvas.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            Point p1 = new Point(new Random().Next(maxX), new Random().Next(maxY));
            Point p2 = new Point(new Random().Next(maxX), new Random().Next(maxY));
            g.DrawLine(pen, p1, p2);
        }

        private void Draw2()
        {
            Point p = new Point(new Random().Next(maxX), new Random().Next(maxY));
            var random = new Random().Next(5, 50);
            Size size = new Size(random, random);

            SolidBrush myBrush = new SolidBrush(Color.FromArgb(new Random().Next(0, 255), new Random().Next(0, 255), new Random().Next(0, 255)));
            Graphics formGraphics;
            formGraphics = pnlCanvas.CreateGraphics();
            formGraphics.FillEllipse(myBrush, new Rectangle(p, size));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void pnlCanvas_Resize(object sender, EventArgs e)
        {
            maxX = pnlCanvas.Width;
            maxY = pnlCanvas.Height;
        }
    }
}
