namespace Takvim
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 172);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 35);
            textBox1.TabIndex = 0;
            textBox1.Text = "Name";
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 238);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 35);
            textBox2.TabIndex = 1;
            textBox2.Text = "Surname";
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(199, 306);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 35);
            textBox3.TabIndex = 2;
            textBox3.Text = "Username";
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Font = new Font("Constantia", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(199, 812);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(133, 40);
            button1.TabIndex = 3;
            button1.Text = "Kaydol";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(199, 378);
            textBox4.Margin = new Padding(4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(213, 35);
            textBox4.TabIndex = 4;
            textBox4.Text = "Password";
            textBox4.Enter += textBox4_Enter;
            textBox4.Leave += textBox4_Leave;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(199, 450);
            textBox5.Margin = new Padding(4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(213, 35);
            textBox5.TabIndex = 5;
            textBox5.Text = "TCKN";
            textBox5.Enter += textBox5_Enter;
            textBox5.Leave += textBox5_Leave;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(199, 522);
            textBox6.Margin = new Padding(4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(213, 35);
            textBox6.TabIndex = 6;
            textBox6.Text = "Phone Number";
            textBox6.Enter += textBox6_Enter;
            textBox6.Leave += textBox6_Leave;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(199, 594);
            textBox7.Margin = new Padding(4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(213, 35);
            textBox7.TabIndex = 7;
            textBox7.Text = "E-Mail";
            textBox7.Enter += textBox7_Enter;
            textBox7.Leave += textBox7_Leave;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(199, 668);
            textBox8.Margin = new Padding(4);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(425, 112);
            textBox8.TabIndex = 8;
            textBox8.Text = "Adress";
            textBox8.Enter += textBox8_Enter;
            textBox8.Leave += textBox8_Leave;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(700, 908);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(4);
            Name = "SignUp";
            Text = "Kayıt Ekranı";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
    }
}