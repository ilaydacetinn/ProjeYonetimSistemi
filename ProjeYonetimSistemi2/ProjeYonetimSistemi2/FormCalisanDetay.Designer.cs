namespace ProjeYonetimSistemi2
{
    partial class FormCalisanDetay
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
            label1 = new Label();
            lblCalisanAdi = new Label();
            lblCalisanSoyadi = new Label();
            lblGorevIstatistikleri = new Label();
            listViewGorevler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnKapat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(223, 9);
            label1.Name = "label1";
            label1.Size = new Size(235, 31);
            label1.TabIndex = 0;
            label1.Text = "ÇALIŞAN DETAYLARI";
            // 
            // lblCalisanAdi
            // 
            lblCalisanAdi.AutoSize = true;
            lblCalisanAdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCalisanAdi.Location = new Point(20, 32);
            lblCalisanAdi.Name = "lblCalisanAdi";
            lblCalisanAdi.Size = new Size(46, 28);
            lblCalisanAdi.TabIndex = 1;
            lblCalisanAdi.Text = "Ad: ";
            // 
            // lblCalisanSoyadi
            // 
            lblCalisanSoyadi.AutoSize = true;
            lblCalisanSoyadi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCalisanSoyadi.Location = new Point(20, 72);
            lblCalisanSoyadi.Name = "lblCalisanSoyadi";
            lblCalisanSoyadi.Size = new Size(76, 28);
            lblCalisanSoyadi.TabIndex = 2;
            lblCalisanSoyadi.Text = "Soyad: ";
            // 
            // lblGorevIstatistikleri
            // 
            lblGorevIstatistikleri.AutoSize = true;
            lblGorevIstatistikleri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblGorevIstatistikleri.Location = new Point(20, 110);
            lblGorevIstatistikleri.Name = "lblGorevIstatistikleri";
            lblGorevIstatistikleri.Size = new Size(178, 28);
            lblGorevIstatistikleri.TabIndex = 3;
            lblGorevIstatistikleri.Text = "Görev İstatistikleri: ";
            // 
            // listViewGorevler
            // 
            listViewGorevler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewGorevler.FullRowSelect = true;
            listViewGorevler.GridLines = true;
            listViewGorevler.Location = new Point(20, 150);
            listViewGorevler.Name = "listViewGorevler";
            listViewGorevler.Size = new Size(610, 250);
            listViewGorevler.TabIndex = 4;
            listViewGorevler.UseCompatibleStateImageBehavior = false;
            listViewGorevler.View = View.Details;
            listViewGorevler.SelectedIndexChanged += listViewGorevler_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Proje Adı";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Görev Adı";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Başlangıç Tarihi\n";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Bitiş Tarihi";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Görev Durumu";
            columnHeader5.Width = 110;
            // 
            // btnKapat
            // 
            btnKapat.Location = new Point(536, 406);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(94, 29);
            btnKapat.TabIndex = 5;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Click;
            // 
            // FormCalisanDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 443);
            Controls.Add(btnKapat);
            Controls.Add(listViewGorevler);
            Controls.Add(lblGorevIstatistikleri);
            Controls.Add(lblCalisanSoyadi);
            Controls.Add(lblCalisanAdi);
            Controls.Add(label1);
            Name = "FormCalisanDetay";
            Text = "FormCalisanDetay";
            Load += FormCalisanDetay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCalisanAdi;
        private Label lblCalisanSoyadi;
        private Label lblGorevIstatistikleri;
        private ListView listViewGorevler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btnKapat;
    }
}