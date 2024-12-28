namespace ProjeYonetimSistemi2
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
            label1 = new Label();
            listView1 = new ListView();
            projeAdi = new ColumnHeader();
            BaşlangıçTarihi = new ColumnHeader();
            BitişTarihi = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnGorevEkle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(246, 51);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "PROJELER";
            label1.Click += label1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { projeAdi, BaşlangıçTarihi, BitişTarihi });
            listView1.Location = new Point(12, 102);
            listView1.Name = "listView1";
            listView1.Size = new Size(559, 200);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // projeAdi
            // 
            projeAdi.Text = "ProjeAdı";
            projeAdi.Width = 150;
            // 
            // BaşlangıçTarihi
            // 
            BaşlangıçTarihi.Text = "BaşlangıçTarihi";
            BaşlangıçTarihi.Width = 150;
            // 
            // BitişTarihi
            // 
            BitişTarihi.Text = "BitişTarihi";
            BitişTarihi.Width = 100;
            // 
            // button1
            // 
            button1.Location = new Point(21, 325);
            button1.Name = "button1";
            button1.Size = new Size(138, 29);
            button1.TabIndex = 3;
            button1.Text = "Yeni Proje";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(196, 325);
            button2.Name = "button2";
            button2.Size = new Size(164, 29);
            button2.TabIndex = 4;
            button2.Text = "Çalışan Yönetimi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(380, 325);
            button3.Name = "button3";
            button3.Size = new Size(161, 29);
            button3.TabIndex = 5;
            button3.Text = "Görev Atama\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnGorevEkle
            // 
            btnGorevEkle.Location = new Point(226, 390);
            btnGorevEkle.Name = "btnGorevEkle";
            btnGorevEkle.Size = new Size(94, 29);
            btnGorevEkle.TabIndex = 6;
            btnGorevEkle.Text = "Görev Ekle";
            btnGorevEkle.UseVisualStyleBackColor = true;
            btnGorevEkle.Click += btnGorevEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(583, 450);
            Controls.Add(btnGorevEkle);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ColumnHeader projeAdi;
        private ColumnHeader BaşlangıçTarihi;
        private ColumnHeader BitişTarihi;
        private Button btnGorevEkle;
    }
}
