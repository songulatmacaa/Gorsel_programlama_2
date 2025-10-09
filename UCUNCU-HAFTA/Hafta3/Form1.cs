using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta3
{
    public partial class Form1 : Form
    {
        private Timer animationTimer;
        private Point button1Start, button2Start, button3Start, button4Start;
        private Point button1Target, button2Target, button3Target, button4Target;
        private bool movingToCenter = true;
        private int step = 0;
        private int totalSteps = 50; // Animasyon adım sayısı

        public Form1()
        {
            InitializeComponent();
            InitializeAnimation();
        }

        private void InitializeAnimation()
        {
            // Başlangıç pozisyonlarını kaydet
            button1Start = button1.Location;
            button2Start = button2.Location;
            button3Start = button3.Location;
            button4Start = button4.Location;

            // Butonlar arasındaki boşluk
            int spacing = 5;

            // Karenin toplam genişliği ve yüksekliği
            int totalWidth = button1.Width * 2 + spacing * 2;
            int totalHeight = button1.Height * 2 + spacing * 2;

            // Karenin sol üst köşesinin merkeze göre konumu
            int squareLeft = (this.ClientSize.Width - totalWidth) / 2;
            int squareTop = (this.ClientSize.Height - totalHeight) / 2;

            // Sol üst buton
            button1Target = new Point(squareLeft, squareTop);

            // Sağ üst buton
            button2Target = new Point(
                squareLeft + button1.Width + spacing * 2,
                squareTop
            );

            // Sol alt buton
            button3Target = new Point(
                squareLeft,
                squareTop + button1.Height + spacing * 2
            );

            // Sağ alt buton
            button4Target = new Point(
                squareLeft + button1.Width + spacing * 2,
                squareTop + button1.Height + spacing * 2
            );

            // Timer'ı oluştur
            animationTimer = new Timer();
            animationTimer.Interval = 20; // 20ms = yaklaşık 50 FPS
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            step++;

            if (step <= totalSteps)
            {
                // Animasyon devam ediyor
                float progress = (float)step / totalSteps;

                if (movingToCenter)
                {
                    // Merkeze doğru hareket
                    button1.Location = Lerp(button1Start, button1Target, progress);
                    button2.Location = Lerp(button2Start, button2Target, progress);
                    button3.Location = Lerp(button3Start, button3Target, progress);
                    button4.Location = Lerp(button4Start, button4Target, progress);
                }
                else
                {
                    // Başlangıç pozisyonlarına dön
                    button1.Location = Lerp(button1Target, button1Start, progress);
                    button2.Location = Lerp(button2Target, button2Start, progress);
                    button3.Location = Lerp(button3Target, button3Start, progress);
                    button4.Location = Lerp(button4Target, button4Start, progress);
                }
            }
            else
            {
                // Animasyon tamamlandı
                step = 0;

                if (movingToCenter)
                {
                    // Merkeze ulaştık, biraz bekle
                    animationTimer.Stop();
                    Timer delayTimer = new Timer();
                    delayTimer.Interval = 500;
                    delayTimer.Tick += (s, ev) =>
                    {
                        delayTimer.Stop();
                        delayTimer.Dispose();
                        movingToCenter = false;
                        animationTimer.Start();
                    };
                    delayTimer.Start();
                }
                else
                {
                    // Başlangıca döndük, biraz bekle ve tekrar başla
                    animationTimer.Stop();
                    Timer delayTimer = new Timer();
                    delayTimer.Interval = 500;
                    delayTimer.Tick += (s, ev) =>
                    {
                        delayTimer.Stop();
                        delayTimer.Dispose();
                        movingToCenter = true;
                        animationTimer.Start();
                    };
                    delayTimer.Start();
                }
            }
        }

        // Linear interpolation (doğrusal enterpolasyon)
        private Point Lerp(Point start, Point end, float t)
        {
            return new Point(
                (int)(start.X + (end.X - start.X) * t),
                (int)(start.Y + (end.Y - start.Y) * t)
            );
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (animationTimer != null)
            {
                animationTimer.Stop();
                animationTimer.Dispose();
            }
            base.OnFormClosing(e);
        }
    }
}