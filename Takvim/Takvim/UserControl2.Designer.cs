namespace Takvim
{
    partial class UserControl2
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            labelday = new Label();
            SuspendLayout();
            // 
            // labelday
            // 
            labelday.AutoSize = true;
            labelday.Location = new Point(4, 13);
            labelday.Margin = new Padding(4, 0, 4, 0);
            labelday.Name = "labelday";
            labelday.Size = new Size(35, 30);
            labelday.TabIndex = 0;
            labelday.Text = "00";
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(labelday);
            Margin = new Padding(4, 4, 4, 4);
            Name = "UserControl2";
            Size = new Size(194, 137);
            Load += UserControl2_Load;
            Click += UserControl2_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelday;
    }
}
