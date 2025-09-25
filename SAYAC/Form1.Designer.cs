namespace SAYAC
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        #region Designer fields
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label lblUstSaat;
        private System.Windows.Forms.Label lblAltSaat;
        private System.Windows.Forms.Label lblUstDakika;
        private System.Windows.Forms.Label lblAltDakika;
        private System.Windows.Forms.Label lblUstSaniye;
        private System.Windows.Forms.Label lblAltSaniye;
        private System.Windows.Forms.Label lblUstSalise;
        private System.Windows.Forms.Label lblAltSalise;
        private System.Windows.Forms.Timer timerUst;
        private System.Windows.Forms.Timer timerAlt;
        #endregion

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnBasla = new System.Windows.Forms.Button();
            lblUstSaat = new System.Windows.Forms.Label();
            lblAltSaat = new System.Windows.Forms.Label();
            lblUstDakika = new System.Windows.Forms.Label();
            lblAltDakika = new System.Windows.Forms.Label();
            lblUstSaniye = new System.Windows.Forms.Label();
            lblAltSaniye = new System.Windows.Forms.Label();
            lblUstSalise = new System.Windows.Forms.Label();
            lblAltSalise = new System.Windows.Forms.Label();
            timerUst = new System.Windows.Forms.Timer(components);
            timerAlt = new System.Windows.Forms.Timer(components);

            SuspendLayout();
            // 
            // btnBasla
            // 
            btnBasla.Location = new System.Drawing.Point(369, 92);
            btnBasla.Name = "btnBasla";
            btnBasla.Size = new System.Drawing.Size(94, 29);
            btnBasla.TabIndex = 0;
            btnBasla.Text = "BAŞLA";
            btnBasla.UseVisualStyleBackColor = true;
            btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // lblUstSaat
            // 
            lblUstSaat.AutoSize = true;
            lblUstSaat.Location = new System.Drawing.Point(55, 67);
            lblUstSaat.Name = "lblUstSaat";
            lblUstSaat.Size = new System.Drawing.Size(26, 20);
            lblUstSaat.TabIndex = 1;
            lblUstSaat.Text = "00";
            // 
            // lblAltSaat
            // 
            lblAltSaat.AutoSize = true;
            lblAltSaat.Location = new System.Drawing.Point(55, 123);
            lblAltSaat.Name = "lblAltSaat";
            lblAltSaat.Size = new System.Drawing.Size(26, 20);
            lblAltSaat.TabIndex = 2;
            lblAltSaat.Text = "00";
            // 
            // lblUstDakika
            // 
            lblUstDakika.AutoSize = true;
            lblUstDakika.Location = new System.Drawing.Point(125, 67);
            lblUstDakika.Name = "lblUstDakika";
            lblUstDakika.Size = new System.Drawing.Size(26, 20);
            lblUstDakika.TabIndex = 3;
            lblUstDakika.Text = "00";
            // 
            // lblAltDakika
            // 
            lblAltDakika.AutoSize = true;
            lblAltDakika.Location = new System.Drawing.Point(125, 123);
            lblAltDakika.Name = "lblAltDakika";
            lblAltDakika.Size = new System.Drawing.Size(26, 20);
            lblAltDakika.TabIndex = 4;
            lblAltDakika.Text = "00";
            // 
            // lblUstSaniye
            // 
            lblUstSaniye.AutoSize = true;
            lblUstSaniye.Location = new System.Drawing.Point(201, 67);
            lblUstSaniye.Name = "lblUstSaniye";
            lblUstSaniye.Size = new System.Drawing.Size(26, 20);
            lblUstSaniye.TabIndex = 5;
            lblUstSaniye.Text = "00";
            // 
            // lblAltSaniye
            // 
            lblAltSaniye.AutoSize = true;
            lblAltSaniye.Location = new System.Drawing.Point(201, 123);
            lblAltSaniye.Name = "lblAltSaniye";
            lblAltSaniye.Size = new System.Drawing.Size(26, 20);
            lblAltSaniye.TabIndex = 6;
            lblAltSaniye.Text = "00";
            // 
            // lblUstSalise
            // 
            lblUstSalise.AutoSize = true;
            lblUstSalise.Location = new System.Drawing.Point(271, 67);
            lblUstSalise.Name = "lblUstSalise";
            lblUstSalise.Size = new System.Drawing.Size(26, 20);
            lblUstSalise.TabIndex = 7;
            lblUstSalise.Text = "00";
            // 
            // lblAltSalise
            // 
            lblAltSalise.AutoSize = true;
            lblAltSalise.Location = new System.Drawing.Point(271, 123);
            lblAltSalise.Name = "lblAltSalise";
            lblAltSalise.Size = new System.Drawing.Size(26, 20);
            lblAltSalise.TabIndex = 8;
            lblAltSalise.Text = "00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblAltSalise);
            Controls.Add(lblUstSalise);
            Controls.Add(lblAltSaniye);
            Controls.Add(lblUstSaniye);
            Controls.Add(lblAltDakika);
            Controls.Add(lblUstDakika);
            Controls.Add(lblAltSaat);
            Controls.Add(lblUstSaat);
            Controls.Add(btnBasla);
            Name = "Form1";
            Text = "Sayaç";
            ResumeLayout(false);
            PerformLayout();
        }

        //ÇALIŞAN SON KOD//

        #endregion
    }
}
