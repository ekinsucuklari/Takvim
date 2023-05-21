namespace Takvim
{
    partial class Form3
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
            daycontainer = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            LBLDATE = new Label();
            SuspendLayout();
            // 
            // daycontainer
            // 
            daycontainer.Location = new Point(16, 94);
            daycontainer.Margin = new Padding(2);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(825, 437);
            daycontainer.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(426, 538);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 1;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(321, 538);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(78, 20);
            button2.TabIndex = 2;
            button2.Text = "Previous";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poor Richard", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 79);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 18);
            label1.TabIndex = 3;
            label1.Text = "Pazartesi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poor Richard", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(167, 79);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(30, 18);
            label2.TabIndex = 4;
            label2.Text = "Salı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poor Richard", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(279, 79);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 18);
            label3.TabIndex = 5;
            label3.Text = "Çarşamba";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poor Richard", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(403, 79);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 18);
            label4.TabIndex = 6;
            label4.Text = "Perşembe";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poor Richard", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(523, 79);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 18);
            label5.TabIndex = 7;
            label5.Text = "Cuma";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poor Richard", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(638, 79);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 18);
            label6.TabIndex = 8;
            label6.Text = "Cumartesi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poor Richard", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(758, 79);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(38, 18);
            label7.TabIndex = 9;
            label7.Text = "Pazar";
            // 
            // LBLDATE
            // 
            LBLDATE.Font = new Font("Poor Richard", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            LBLDATE.Location = new Point(279, 18);
            LBLDATE.Margin = new Padding(2, 0, 2, 0);
            LBLDATE.Name = "LBLDATE";
            LBLDATE.Size = new Size(286, 36);
            LBLDATE.TabIndex = 10;
            LBLDATE.Text = "month year";
            LBLDATE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 565);
            Controls.Add(LBLDATE);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(daycontainer);
            Margin = new Padding(2);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel daycontainer;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label LBLDATE;
    }
}