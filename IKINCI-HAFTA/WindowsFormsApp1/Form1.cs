using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public Form1()
        {
            InitializeComponent(); // Designer’ın oluşturduğu UI’yı yükler
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = e.Location;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                button1.Left += e.X - startPoint.X;
                button1.Top += e.Y - startPoint.Y;
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}