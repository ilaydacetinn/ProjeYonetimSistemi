namespace ProjeYonetimSistemi2
{
    partial class FormYeniProje
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
            dtpBaslangicTarihi = new DateTimePicker();
            txtProjeAdi = new TextBox();
            label2 = new Label();
            dtpBitisTarihi = new DateTimePicker();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 65);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Proje Adı";
            // 
            // dtpBaslangicTarihi
            // 
            dtpBaslangicTarihi.Location = new Point(205, 132);
            dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            dtpBaslangicTarihi.Size = new Size(250, 27);
            dtpBaslangicTarihi.TabIndex = 1;
            dtpBaslangicTarihi.ValueChanged += dtpBaslangicTarihi_ValueChanged;
            // 
            // txtProjeAdi
            // 
            txtProjeAdi.Location = new Point(178, 65);
            txtProjeAdi.Name = "txtProjeAdi";
            txtProjeAdi.Size = new Size(288, 27);
            txtProjeAdi.TabIndex = 2;
            txtProjeAdi.TextChanged += txtProjeAdi_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 132);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 3;
            label2.Text = "Başlangıç Tarihi";
            label2.Click += label2_Click;
            // 
            // dtpBitisTarihi
            // 
            dtpBitisTarihi.Location = new Point(205, 190);
            dtpBitisTarihi.Name = "dtpBitisTarihi";
            dtpBitisTarihi.Size = new Size(250, 27);
            dtpBitisTarihi.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 195);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 5;
            label3.Text = "Bitiş Tarihi";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(372, 280);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormYeniProje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 329);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(dtpBitisTarihi);
            Controls.Add(label2);
            Controls.Add(txtProjeAdi);
            Controls.Add(dtpBaslangicTarihi);
            Controls.Add(label1);
            Name = "FormYeniProje";
            Text = "FormYeniProje";
            Load += FormYeniProje_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpBaslangic;
        private TextBox txtProjeAdi;
        private Label label2;
        private DateTimePicker dtpBitis;
        private Label label3;
        private Button button1;
        private DateTimePicker dtpBaslangicTarihi;
        
        private DateTimePicker dtpBitisTarihi;


        

    }
}