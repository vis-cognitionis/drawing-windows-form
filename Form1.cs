using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point previousPoint;
        private int thickness = 2; // Varsayılan kalınlık değeri
        private Color color = Color.Green; // Varsayılan renk değeri

        public Form1()
        {
            InitializeComponent();
            canvasPictureBox.Paint += CanvasPictureBox_Paint;
            canvasPictureBox.MouseDown += CanvasPictureBox_MouseDown;
            canvasPictureBox.MouseMove += CanvasPictureBox_MouseMove;
            canvasPictureBox.MouseUp += CanvasPictureBox_MouseUp;
            btnErase.Click += BtnErase_Click;
            red.Click += Red_Click;
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
                    DrawLineWithParameters(g, thickness, color, previousPoint, e.Location);
                    previousPoint = e.Location;
                }
            }
        }


        private void CanvasPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void BtnErase_Click(object sender, EventArgs e)
        {
            canvasPictureBox.Refresh();
        }

        private void DrawLineWithParameters(Graphics g, int thickness, Color color, Point startPoint, Point endPoint)
        {
            using (Pen pen = new Pen(color, thickness))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawLine(pen, startPoint, endPoint);
            }
        }

        private void Red_Click(object sender, EventArgs e)
        {
            color = Color.Red;

        }
    }
}