namespace ProjeYonetimSistemi2
{
    partial class FormCalisanEkle
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
            txtAd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSoyad = new TextBox();
            btnCalisanKaydet = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(133, 116);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 0;
            txtAd.TextChanged += txtAd_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 54);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 1;
            label1.Text = "ÇALIŞAN EKLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 116);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 2;
            label2.Text = "ADI";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(133, 165);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 3;
            // 
            // btnCalisanKaydet
            // 
            btnCalisanKaydet.Location = new Point(239, 241);
            btnCalisanKaydet.Name = "btnCalisanKaydet";
            btnCalisanKaydet.Size = new Size(94, 29);
            btnCalisanKaydet.TabIndex = 4;
            btnCalisanKaydet.Text = "Kaydet";
            btnCalisanKaydet.UseVisualStyleBackColor = true;
            btnCalisanKaydet.Click += btnCalisanKaydet_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 168);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 5;
            label3.Text = "SOYADI";
            // 
            // FormCalisanEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 292);
            Controls.Add(label3);
            Controls.Add(btnCalisanKaydet);
            Controls.Add(txtSoyad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAd);
            Name = "FormCalisanEkle";
            Text = "FormCalisanEkle";
            Load += FormCalisanEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private Label label1;
        private Label label2;
        private TextBox txtSoyad;
        private Button btnCalisanKaydet;
        private Label label3;
    }
}