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
            label8 = new Label();
            SuspendLayout();
            // 
            // daycontainer
            // 
            daycontainer.BackColor = Color.Transparent;
            daycontainer.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point);
            daycontainer.ForeColor = SystemColors.ControlText;
            daycontainer.Location = new Point(27, 188);
            daycontainer.Margin = new Padding(3, 4, 3, 4);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(1575, 874);
            daycontainer.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(730, 1076);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(134, 40);
            button1.TabIndex = 1;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(550, 1076);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(134, 40);
            button2.TabIndex = 2;
            button2.Text = "Previous";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(92, 159);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 3;
            label1.Text = "Pazartesi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(331, 159);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 4;
            label2.Text = "Salı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(478, 159);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 5;
            label3.Text = "Çarşamba";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(730, 159);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 6;
            label4.Text = "Perşembe";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(977, 159);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 7;
            label5.Text = "Cuma";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1168, 159);
            label6.Name = "label6";
            label6.Size = new Size(127, 25);
            label6.TabIndex = 8;
            label6.Text = "Cumartesi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(1407, 159);
            label7.Name = "label7";
            label7.Size = new Size(74, 25);
            label7.TabIndex = 9;
            label7.Text = "Pazar";
            // 
            // LBLDATE
            // 
            LBLDATE.BackColor = Color.Transparent;
            LBLDATE.Font = new Font("Lucida Sans Unicode", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point);
            LBLDATE.Location = new Point(550, 42);
            LBLDATE.Name = "LBLDATE";
            LBLDATE.Size = new Size(490, 72);
            LBLDATE.TabIndex = 10;
            LBLDATE.Text = "month year";
            LBLDATE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(114, 57);
            label8.Name = "label8";
            label8.Size = new Size(0, 30);
            label8.TabIndex = 11;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1608, 1224);
            Controls.Add(label8);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label8;
    }
}