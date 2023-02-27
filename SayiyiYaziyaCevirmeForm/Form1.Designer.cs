namespace SayiyiYaziyaCevirmeForm
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
            this.btnCevir = new System.Windows.Forms.Button();
            this.lblSayiGiriniz = new System.Windows.Forms.Label();
            this.txtSayiGiriniz = new System.Windows.Forms.TextBox();
            this.ltsSayOkunusu = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCevir
            // 
            this.btnCevir.Location = new System.Drawing.Point(249, 320);
            this.btnCevir.Name = "btnCevir";
            this.btnCevir.Size = new System.Drawing.Size(94, 29);
            this.btnCevir.TabIndex = 0;
            this.btnCevir.Text = "Çevir";
            this.btnCevir.UseVisualStyleBackColor = true;
            this.btnCevir.Click += new System.EventHandler(this.btnCevir_Click);
            // 
            // lblSayiGiriniz
            // 
            this.lblSayiGiriniz.AutoSize = true;
            this.lblSayiGiriniz.Location = new System.Drawing.Point(76, 117);
            this.lblSayiGiriniz.Name = "lblSayiGiriniz";
            this.lblSayiGiriniz.Size = new System.Drawing.Size(89, 20);
            this.lblSayiGiriniz.TabIndex = 1;
            this.lblSayiGiriniz.Text = "Sayi Giriniz :";
            this.lblSayiGiriniz.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSayiGiriniz
            // 
            this.txtSayiGiriniz.Location = new System.Drawing.Point(171, 110);
            this.txtSayiGiriniz.Name = "txtSayiGiriniz";
            this.txtSayiGiriniz.Size = new System.Drawing.Size(125, 27);
            this.txtSayiGiriniz.TabIndex = 2;
            // 
            // ltsSayOkunusu
            // 
            this.ltsSayOkunusu.FormattingEnabled = true;
            this.ltsSayOkunusu.ItemHeight = 20;
            this.ltsSayOkunusu.Location = new System.Drawing.Point(346, 95);
            this.ltsSayOkunusu.Name = "ltsSayOkunusu";
            this.ltsSayOkunusu.Size = new System.Drawing.Size(379, 104);
            this.ltsSayOkunusu.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ltsSayOkunusu);
            this.Controls.Add(this.txtSayiGiriniz);
            this.Controls.Add(this.lblSayiGiriniz);
            this.Controls.Add(this.btnCevir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCevir;
        private Label lblSayiGiriniz;
        private TextBox txtSayiGiriniz;
        private ListBox ltsSayOkunusu;
    }
}