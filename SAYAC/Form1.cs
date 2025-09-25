using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace SAYAC
{
    public partial class Form1 : Form
    {
        private Stopwatch swUst;
        private Stopwatch swAlt;
        private TimeSpan hedefSure = TimeSpan.FromMinutes(1); // 1 dakika

        public Form1()
        {
            InitializeComponent();

            // Stopwatch'lar
            swUst = new Stopwatch();
            swAlt = new Stopwatch();

            // Timer ayarlar� (UI g�ncelleme i�in)
            timerUst.Interval = 10; // 10 ms -> salise (centisecond) g�r�n�m� i�in iyi
            timerUst.Tick += TimerUst_Tick;

            timerAlt.Interval = 10;
            timerAlt.Tick += TimerAlt_Tick;

            // Ba�lang�� label'lar�
            lblUstSaat.Text = "00";
            lblUstDakika.Text = "00";
            lblUstSaniye.Text = "00";
            lblUstSalise.Text = "00";

            lblAltSaat.Text = "00";
            lblAltDakika.Text = "00";
            lblAltSaniye.Text = "00";
            lblAltSalise.Text = "00";
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            // Ba�lat: �st kronometre gibi ba�lar
            swUst.Restart();
            timerUst.Start();

            btnBasla.Enabled = false;
            btnBasla.BackColor = SystemColors.Control; // ba�lang��ta normal renk
        }

        private void TimerUst_Tick(object sender, EventArgs e)
        {
            var elapsed = swUst.Elapsed;

            // �st (ileri) saya� - kronometre gibi
            lblUstSaat.Text = elapsed.Hours.ToString("00");
            lblUstDakika.Text = elapsed.Minutes.ToString("00");
            lblUstSaniye.Text = elapsed.Seconds.ToString("00");
            // Centiseconds (salise i�in 0-99)
            lblUstSalise.Text = (elapsed.Milliseconds / 10).ToString("00");

            // 1 dakika (hedef) dolduysa �st� durdur, alt geri say�m� ba�lat
            if (elapsed >= hedefSure)
            {
                timerUst.Stop();
                swUst.Stop();

                // Alt i�in saya� ba�lat (geri say�m)
                swAlt.Restart();
                timerAlt.Start();

                // Butonu ye�ile boyayal�m (istedi�in gibi)
                btnBasla.BackColor = Color.Green;
            }
        }

        private void TimerAlt_Tick(object sender, EventArgs e)
        {
            var remaining = hedefSure - swAlt.Elapsed;

            if (remaining <= TimeSpan.Zero)
            {
                // Geri say�m bitti
                timerAlt.Stop();
                swAlt.Stop();
                remaining = TimeSpan.Zero;

                // �stersen butonu tekrar aktif yap
                btnBasla.Enabled = true;
                btnBasla.BackColor = SystemColors.Control;
            }

            // Alt (geri) saya� - kalan s�reyi g�ster
            lblAltSaat.Text = remaining.Hours.ToString("00");
            lblAltDakika.Text = remaining.Minutes.ToString("00");
            lblAltSaniye.Text = remaining.Seconds.ToString("00");
            lblAltSalise.Text = (remaining.Milliseconds / 10).ToString("00");
        }
    }
}
