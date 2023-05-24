using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DrawingApp
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point previousPoint;

        public Form1()
        {
            InitializeComponent();
            canvasPictureBox.Paint += CanvasPictureBox_Paint;
            canvasPictureBox.MouseDown += CanvasPictureBox_MouseDown;
            canvasPictureBox.MouseMove += CanvasPictureBox_MouseMove;
            canvasPictureBox.MouseUp += CanvasPictureBox_MouseUp;
        }

        private void CanvasPictureBox_Paint(object sender, PaintEventArgs e)
        {
            // Çizim işlemleri burada gerçekleştirilir
            // Örneğin, fırça rengini, kalınlığını veya diğer çizim ayarlarını belirleyebilirsiniz
        }

        private void CanvasPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            previousPoint = e.Location;
        }

        private void CanvasPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = canvasPictureBox.CreateGraphics())
                {
                    // Çizgi çizme işlemi
                    g.DrawLine(Pens.Black, previousPoint, e.Location);
                    previousPoint = e.Location;
                }
            }
        }

        private void CanvasPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
    }
}