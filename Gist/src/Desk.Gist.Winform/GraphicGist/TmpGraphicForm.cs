using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desk.Gist.Winform.GraphicGist
{
    public partial class TmpGraphicForm : Form
    {
        private static Point lineStartPoint;
        private static Point lineEndPoint;
        Graphics graphic;

        public TmpGraphicForm()
        {
            InitializeComponent();

            //BindEvent();

            pnlMain.BackColor = Color.White;
        }

        private void BindEvent()
        {
            //pnlMain.MouseDown += PnlMain_MouseDown;
            //pnlMain.MouseUp += PnlMain_MouseUp;

        }
        private void PnlMain_MouseUp(object sender, MouseEventArgs e)
        {
            pnlMain.MouseMove -= PnlMain_MouseMove;
            lineStartPoint = new Point(-1, -1);
        }

        private void PnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            //pnlMain.Invalidate();
            graphic = pnlMain.CreateGraphics();
            lineStartPoint.X = e.X;
            lineStartPoint.Y = e.Y;
            pnlMain.MouseMove += PnlMain_MouseMove;
        }

        private void PnlMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (graphic == null)
            {
                return;
            }
            if (lineStartPoint.X < 0 || lineStartPoint.Y < 0)
            {
                return;
            }

            DrawLine(lineStartPoint, new Point(e.X, e.Y));
        }


        public void DrawLine(Point start, Point end)
        {

            Pen pen = new Pen(Color.Red, 3);
            if (graphic != null)
            {
                //pnlMain.Invalidate();
                //graphic.Clear(pnlMain.BackColor);
            }

            graphic.DrawLine(pen, start, end);
        }



        private void TmpGraphicForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDrawLine_Click(object sender, EventArgs e)
        {
            //graphic = pnlMain.CreateGraphics();
            lineStartPoint = new Point(-1, -1);

            pnlMain.MouseDown += PnlMain_MouseDown;
            pnlMain.MouseUp += PnlMain_MouseUp;
            //pnlMain.MouseMove += PnlMain_MouseMove;
        }

        private void btnChar_Click(object sender, EventArgs e)
        {
            graphic = pnlMain.CreateGraphics();
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            graphic.DrawString("啊", drawFont, drawBrush, 100, 100);
            graphic.DrawLine(new Pen(Color.Red, 3), new Point(100, 100), new Point(200, 200));
            graphic.DrawLine(new Pen(Color.Red, 3), new Point(300, 100), new Point(400, 400));
        }
    }
}
