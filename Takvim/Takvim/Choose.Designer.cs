namespace Takvim
{
    partial class Choose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(295, 106);
            label1.Name = "label1";
            label1.Size = new Size(0, 38);
            label1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Font = new Font("Consolas", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(125, 418);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 1;
            button1.Text = "Yeni Kayıt";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSeaGreen;
            button2.Font = new Font("Consolas", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(407, 418);
            button2.Name = "button2";
            button2.Size = new Size(131, 40);
            button2.TabIndex = 2;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSeaGreen;
            button3.Font = new Font("Consolas", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(696, 418);
            button3.Name = "button3";
            button3.Size = new Size(131, 40);
            button3.TabIndex = 3;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Choose
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(960, 540);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Choose";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bugün Neler Var?";
            Load += Choose_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}