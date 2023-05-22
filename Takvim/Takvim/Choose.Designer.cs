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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(90, 463);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(134, 41);
            button1.TabIndex = 0;
            button1.Text = "Yeni Kayıt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(400, 463);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(134, 41);
            button2.TabIndex = 1;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(700, 463);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(134, 41);
            button3.TabIndex = 2;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 128);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 3;
            // 
            // Choose
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(960, 540);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4);
            Name = "Choose";
            Text = "Choose";
            Load += Choose_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}