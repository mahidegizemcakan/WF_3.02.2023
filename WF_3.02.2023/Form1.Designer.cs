namespace WF_3._02._2023
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.soyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.ekle2 = new System.Windows.Forms.Button();
            this.sil2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(42, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 0;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(42, 71);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "isim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(339, 20);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(100, 23);
            this.isim.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyisim";
            // 
            // soyisim
            // 
            this.soyisim.Location = new System.Drawing.Point(339, 71);
            this.soyisim.Name = "soyisim";
            this.soyisim.Size = new System.Drawing.Size(100, 23);
            this.soyisim.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefon";
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(339, 128);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(100, 23);
            this.telefon.TabIndex = 4;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(146, 70);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 5;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // ekle2
            // 
            this.ekle2.Location = new System.Drawing.Point(339, 168);
            this.ekle2.Name = "ekle2";
            this.ekle2.Size = new System.Drawing.Size(75, 23);
            this.ekle2.TabIndex = 6;
            this.ekle2.Text = "ekle2";
            this.ekle2.UseVisualStyleBackColor = true;
            this.ekle2.Click += new System.EventHandler(this.ekle2_Click);
            // 
            // sil2
            // 
            this.sil2.Location = new System.Drawing.Point(339, 208);
            this.sil2.Name = "sil2";
            this.sil2.Size = new System.Drawing.Size(75, 23);
            this.sil2.TabIndex = 7;
            this.sil2.Text = "sil2";
            this.sil2.UseVisualStyleBackColor = true;
            this.sil2.Click += new System.EventHandler(this.sil2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(319, 273);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 94);
            this.listBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.sil2);
            this.Controls.Add(this.ekle2);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.soyisim);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox soyisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button ekle2;
        private System.Windows.Forms.Button sil2;
        private System.Windows.Forms.ListBox listBox2;
    }
}
