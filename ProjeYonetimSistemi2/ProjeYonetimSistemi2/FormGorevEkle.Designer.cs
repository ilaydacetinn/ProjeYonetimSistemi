namespace ProjeYonetimSistemi2
{
    partial class FormGorevEkle
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
            txtGorevAdi = new TextBox();
            cmbCalisanSec = new ComboBox();
            dtpGorevBaslangic = new DateTimePicker();
            nudAdamGun = new NumericUpDown();
            btnKaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpGorevBitis = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            labelProjeAdi = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAdamGun).BeginInit();
            SuspendLayout();
            // 
            // txtGorevAdi
            // 
            txtGorevAdi.Location = new Point(104, 60);
            txtGorevAdi.Name = "txtGorevAdi";
            txtGorevAdi.Size = new Size(125, 27);
            txtGorevAdi.TabIndex = 0;
            // 
            // cmbCalisanSec
            // 
            cmbCalisanSec.FormattingEnabled = true;
            cmbCalisanSec.Location = new Point(127, 264);
            cmbCalisanSec.Name = "cmbCalisanSec";
            cmbCalisanSec.Size = new Size(151, 28);
            cmbCalisanSec.TabIndex = 1;
            // 
            // dtpGorevBaslangic
            // 
            dtpGorevBaslangic.Location = new Point(140, 109);
            dtpGorevBaslangic.Name = "dtpGorevBaslangic";
            dtpGorevBaslangic.Size = new Size(250, 27);
            dtpGorevBaslangic.TabIndex = 2;
            // 
            // nudAdamGun
            // 
            nudAdamGun.Location = new Point(156, 220);
            nudAdamGun.Name = "nudAdamGun";
            nudAdamGun.Size = new Size(150, 27);
            nudAdamGun.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(356, 299);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += button1btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 116);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 5;
            label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 63);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 6;
            label2.Text = "Görev Adı";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 222);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 7;
            label3.Text = "Adam Gün Değeri";
            // 
            // dtpGorevBitis
            // 
            dtpGorevBitis.Location = new Point(140, 153);
            dtpGorevBitis.Name = "dtpGorevBitis";
            dtpGorevBitis.Size = new Size(250, 27);
            dtpGorevBitis.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 153);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 9;
            label4.Text = "Bitiş Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 264);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 10;
            label5.Text = "Çalışan Seç";
            // 
            // labelProjeAdi
            // 
            labelProjeAdi.AutoSize = true;
            labelProjeAdi.Location = new Point(127, 23);
            labelProjeAdi.Name = "labelProjeAdi";
            labelProjeAdi.Size = new Size(50, 20);
            labelProjeAdi.TabIndex = 11;
            labelProjeAdi.Text = "label6";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(23, 18);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 12;
            label6.Text = "Proje Adı:";
            // 
            // FormGorevEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 353);
            Controls.Add(label6);
            Controls.Add(labelProjeAdi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpGorevBitis);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Controls.Add(nudAdamGun);
            Controls.Add(dtpGorevBaslangic);
            Controls.Add(cmbCalisanSec);
            Controls.Add(txtGorevAdi);
            Name = "FormGorevEkle";
            Text = "FormGorevEkle";
            Load += FormGorevEkle_Load;
            ((System.ComponentModel.ISupportInitialize)nudAdamGun).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGorevAdi;
        private ComboBox cmbCalisanSec;
        private DateTimePicker dtpGorevBaslangic;
        private NumericUpDown nudAdamGun;
        private Button btnKaydet;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpGorevBitis;
        private Label label4;
        private Label label5;
        private Label labelProjeAdi;
        private Label label6;
    }
}