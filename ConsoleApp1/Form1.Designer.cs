namespace ConsoleApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAsal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTujuan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBerat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbLayanan = new System.Windows.Forms.GroupBox();
            this.rbPos = new System.Windows.Forms.RadioButton();
            this.rbJne = new System.Windows.Forms.RadioButton();
            this.rbTiki = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cek Harga Ongkir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kota / Kabupaten asal";
            // 
            // tbAsal
            // 
            this.tbAsal.Location = new System.Drawing.Point(19, 101);
            this.tbAsal.Name = "tbAsal";
            this.tbAsal.Size = new System.Drawing.Size(262, 20);
            this.tbAsal.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kota / Kabupaten tujuan";
            // 
            // tbTujuan
            // 
            this.tbTujuan.Location = new System.Drawing.Point(19, 176);
            this.tbTujuan.Name = "tbTujuan";
            this.tbTujuan.Size = new System.Drawing.Size(262, 20);
            this.tbTujuan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Berat (gram)";
            // 
            // tbBerat
            // 
            this.tbBerat.Location = new System.Drawing.Point(19, 256);
            this.tbBerat.Name = "tbBerat";
            this.tbBerat.Size = new System.Drawing.Size(262, 20);
            this.tbBerat.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cek Harga Layanan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbLayanan
            // 
            this.gbLayanan.Location = new System.Drawing.Point(359, 71);
            this.gbLayanan.Name = "gbLayanan";
            this.gbLayanan.Size = new System.Drawing.Size(415, 315);
            this.gbLayanan.TabIndex = 11;
            this.gbLayanan.TabStop = false;
            this.gbLayanan.Text = "Detail Layanan";
            // 
            // rbPos
            // 
            this.rbPos.AutoSize = true;
            this.rbPos.Location = new System.Drawing.Point(19, 309);
            this.rbPos.Name = "rbPos";
            this.rbPos.Size = new System.Drawing.Size(47, 17);
            this.rbPos.TabIndex = 12;
            this.rbPos.TabStop = true;
            this.rbPos.Text = "POS";
            this.rbPos.UseVisualStyleBackColor = true;
            // 
            // rbJne
            // 
            this.rbJne.AutoSize = true;
            this.rbJne.Location = new System.Drawing.Point(110, 309);
            this.rbJne.Name = "rbJne";
            this.rbJne.Size = new System.Drawing.Size(45, 17);
            this.rbJne.TabIndex = 13;
            this.rbJne.TabStop = true;
            this.rbJne.Text = "JNE";
            this.rbJne.UseVisualStyleBackColor = true;
            // 
            // rbTiki
            // 
            this.rbTiki.AutoSize = true;
            this.rbTiki.Location = new System.Drawing.Point(201, 309);
            this.rbTiki.Name = "rbTiki";
            this.rbTiki.Size = new System.Drawing.Size(45, 17);
            this.rbTiki.TabIndex = 14;
            this.rbTiki.TabStop = true;
            this.rbTiki.Text = "TIKI";
            this.rbTiki.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbTiki);
            this.Controls.Add(this.rbJne);
            this.Controls.Add(this.rbPos);
            this.Controls.Add(this.gbLayanan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbBerat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTujuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAsal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAsal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTujuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBerat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbLayanan;
        private System.Windows.Forms.RadioButton rbPos;
        private System.Windows.Forms.RadioButton rbJne;
        private System.Windows.Forms.RadioButton rbTiki;
    }
}