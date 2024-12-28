namespace ProjeYonetimSistemi2
{
    partial class FormGorevAtama
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
            cmbDurum = new ComboBox();
            btnDurumGuncelle = new Button();
            listViewGorevler = new ListView();
            GorevAdı = new ColumnHeader();
            BaslangicTarihi = new ColumnHeader();
            BitisTarihi = new ColumnHeader();
            Durum = new ColumnHeader();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbDurum
            // 
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Items.AddRange(new object[] { "Tamamlanacak", "Devam Ediyor", "Tamamlandı" });
            cmbDurum.Location = new Point(146, 218);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(151, 28);
            cmbDurum.TabIndex = 7;
            cmbDurum.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnDurumGuncelle
            // 
            btnDurumGuncelle.Location = new Point(390, 357);
            btnDurumGuncelle.Name = "btnDurumGuncelle";
            btnDurumGuncelle.Size = new Size(94, 29);
            btnDurumGuncelle.TabIndex = 8;
            btnDurumGuncelle.Text = "Güncelle";
            btnDurumGuncelle.UseVisualStyleBackColor = true;
            btnDurumGuncelle.Click += btnDurumGuncelle_Click;
            // 
            // listViewGorevler
            // 
            listViewGorevler.Columns.AddRange(new ColumnHeader[] { GorevAdı, BaslangicTarihi, BitisTarihi, Durum });
            listViewGorevler.Location = new Point(9, 70);
            listViewGorevler.Name = "listViewGorevler";
            listViewGorevler.Size = new Size(501, 121);
            listViewGorevler.TabIndex = 9;
            listViewGorevler.UseCompatibleStateImageBehavior = false;
            listViewGorevler.View = View.Details;
            // 
            // GorevAdı
            // 
            GorevAdı.Text = "Görev Adı";
            GorevAdı.Width = 100;
            // 
            // BaslangicTarihi
            // 
            BaslangicTarihi.Text = "Başlangıç Tarihi";
            BaslangicTarihi.Width = 140;
            // 
            // BitisTarihi
            // 
            BitisTarihi.Text = "Bitiş Tarihi";
            BitisTarihi.Width = 140;
            // 
            // Durum
            // 
            Durum.Text = "Durum";
            Durum.Width = 140;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 226);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 10;
            label1.Text = "Görev Durumu";
            // 
            // FormGorevAtama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 431);
            Controls.Add(label1);
            Controls.Add(listViewGorevler);
            Controls.Add(btnDurumGuncelle);
            Controls.Add(cmbDurum);
            Name = "FormGorevAtama";
            Text = "FormGorevAtama";
            Load += FormGorevAtama_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbDurum;
        private Button btnDurumGuncelle;
        private ListView listViewGorevler;
        private ColumnHeader GorevAdı;
        private ColumnHeader BaslangicTarihi;
        private ColumnHeader BitisTarihi;
        private ColumnHeader Durum;
        private Label label1;
    }
}