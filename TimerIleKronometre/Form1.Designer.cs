namespace TimerIleKronometre
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txt = new System.Windows.Forms.TextBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDakika = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.txtGeriSayim = new System.Windows.Forms.TextBox();
            this.btnGeriSayimBaşla = new System.Windows.Forms.Button();
            this.tmrGeriSayim = new System.Windows.Forms.Timer(this.components);
            this.txtGeriSayimGösterge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(59, 275);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(466, 29);
            this.progressBar.TabIndex = 0;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(12, 75);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(199, 27);
            this.txt.TabIndex = 2;
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.Lime;
            this.btnBasla.Location = new System.Drawing.Point(249, 21);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(94, 29);
            this.btnBasla.TabIndex = 3;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.BackColor = System.Drawing.Color.Blue;
            this.btnSifirla.Location = new System.Drawing.Point(249, 91);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(94, 29);
            this.btnSifirla.TabIndex = 4;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = false;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDurdur.Location = new System.Drawing.Point(249, 56);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(94, 29);
            this.btnDurdur.TabIndex = 5;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = false;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 27);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Kronometre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(59, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Geri Sayım";
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDakika.Location = new System.Drawing.Point(241, 180);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(21, 20);
            this.lblDakika.TabIndex = 8;
            this.lblDakika.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(286, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = ":";
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaniye.Location = new System.Drawing.Point(322, 180);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(21, 20);
            this.lblSaniye.TabIndex = 10;
            this.lblSaniye.Text = "--";
            // 
            // txtGeriSayim
            // 
            this.txtGeriSayim.Location = new System.Drawing.Point(59, 204);
            this.txtGeriSayim.Name = "txtGeriSayim";
            this.txtGeriSayim.Size = new System.Drawing.Size(125, 27);
            this.txtGeriSayim.TabIndex = 11;
            // 
            // btnGeriSayimBaşla
            // 
            this.btnGeriSayimBaşla.Location = new System.Drawing.Point(420, 180);
            this.btnGeriSayimBaşla.Name = "btnGeriSayimBaşla";
            this.btnGeriSayimBaşla.Size = new System.Drawing.Size(94, 29);
            this.btnGeriSayimBaşla.TabIndex = 12;
            this.btnGeriSayimBaşla.Text = "Başla";
            this.btnGeriSayimBaşla.UseVisualStyleBackColor = true;
            this.btnGeriSayimBaşla.Click += new System.EventHandler(this.btnGeriSayimBaşla_Click);
            // 
            // tmrGeriSayim
            // 
            this.tmrGeriSayim.Interval = 1000;
            this.tmrGeriSayim.Tick += new System.EventHandler(this.tmrGeriSayim_Tick);
            // 
            // txtGeriSayimGösterge
            // 
            this.txtGeriSayimGösterge.Location = new System.Drawing.Point(241, 204);
            this.txtGeriSayimGösterge.Name = "txtGeriSayimGösterge";
            this.txtGeriSayimGösterge.Size = new System.Drawing.Size(125, 27);
            this.txtGeriSayimGösterge.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.txtGeriSayimGösterge);
            this.Controls.Add(this.btnGeriSayimBaşla);
            this.Controls.Add(this.txtGeriSayim);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.progressBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private ProgressBar progressBar;
        private TextBox txt;
        private Button btnBasla;
        private Button btnSifirla;
        private Button btnDurdur;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblDakika;
        private Label label2;
        private Label lblSaniye;
        private TextBox txtGeriSayim;
        private Button btnGeriSayimBaşla;
        private System.Windows.Forms.Timer tmrGeriSayim;
        private TextBox txtGeriSayimGösterge;
    }
}