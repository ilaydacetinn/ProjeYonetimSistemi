namespace ProjeYonetimSistemi2
{
    partial class FormCalısanYonetimi
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
            listViewCalisanlar = new ListView();
            Ad = new ColumnHeader();
            Soyad = new ColumnHeader();
            btnYeniCalisan = new Button();
            btnCalisanSil = new Button();
            btnCalisanGuncelle = new Button();
            SuspendLayout();
            // 
            // listViewCalisanlar
            // 
            listViewCalisanlar.Columns.AddRange(new ColumnHeader[] { Ad, Soyad });
            listViewCalisanlar.Location = new Point(89, 70);
            listViewCalisanlar.Name = "listViewCalisanlar";
            listViewCalisanlar.Size = new Size(290, 121);
            listViewCalisanlar.TabIndex = 0;
            listViewCalisanlar.UseCompatibleStateImageBehavior = false;
            listViewCalisanlar.View = View.Details;
            listViewCalisanlar.SelectedIndexChanged += listViewCalisanlar_SelectedIndexChanged;
            // 
            // Ad
            // 
            Ad.Text = "Ad";
            // 
            // Soyad
            // 
            Soyad.Text = "Soyad";
            // 
            // btnYeniCalisan
            // 
            btnYeniCalisan.Location = new Point(100, 232);
            btnYeniCalisan.Name = "btnYeniCalisan";
            btnYeniCalisan.Size = new Size(131, 29);
            btnYeniCalisan.TabIndex = 1;
            btnYeniCalisan.Text = "Çalışan Ekle";
            btnYeniCalisan.UseVisualStyleBackColor = true;
            btnYeniCalisan.Click += btnYeniCalisan_Click;
            // 
            // btnCalisanSil
            // 
            btnCalisanSil.Location = new Point(237, 232);
            btnCalisanSil.Name = "btnCalisanSil";
            btnCalisanSil.Size = new Size(129, 29);
            btnCalisanSil.TabIndex = 2;
            btnCalisanSil.Text = "Çalışan Sil";
            btnCalisanSil.UseVisualStyleBackColor = true;
            btnCalisanSil.Click += btnCalisanSil_Click;
            // 
            // btnCalisanGuncelle
            // 
            btnCalisanGuncelle.Location = new Point(175, 320);
            btnCalisanGuncelle.Name = "btnCalisanGuncelle";
            btnCalisanGuncelle.Size = new Size(94, 29);
            btnCalisanGuncelle.TabIndex = 3;
            btnCalisanGuncelle.Text = "Güncelle";
            btnCalisanGuncelle.UseVisualStyleBackColor = true;
            btnCalisanGuncelle.Click += btnCalisanGuncelle_Click;
            // 
            // FormCalısanYonetimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalisanGuncelle);
            Controls.Add(btnCalisanSil);
            Controls.Add(btnYeniCalisan);
            Controls.Add(listViewCalisanlar);
            Name = "FormCalısanYonetimi";
            Text = "FormCalısanYonetimi";
            Load += FormCalısanYonetimi_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewCalisanlar;
        private Button btnYeniCalisan;
        private Button btnCalisanSil;
        private Button btnCalisanGuncelle;
        private ColumnHeader Ad;
        private ColumnHeader Soyad;
    }
}