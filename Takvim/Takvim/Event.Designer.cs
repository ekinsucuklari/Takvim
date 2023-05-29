namespace Takvim
{
    partial class EventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            textBoxDate = new TextBox();
            textBoxStart = new TextBox();
            textBoxEnd = new TextBox();
            textBoxDescp = new TextBox();
            label1 = new Label();
            buttonSave = new Button();
            textBoxEventType = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxDate
            // 
            textBoxDate.BackColor = SystemColors.GradientInactiveCaption;
            textBoxDate.Location = new Point(68, 78);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(157, 35);
            textBoxDate.TabIndex = 0;
            // 
            // textBoxStart
            // 
            textBoxStart.BackColor = SystemColors.GradientInactiveCaption;
            textBoxStart.Location = new Point(68, 182);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(155, 35);
            textBoxStart.TabIndex = 1;
            // 
            // textBoxEnd
            // 
            textBoxEnd.BackColor = SystemColors.GradientInactiveCaption;
            textBoxEnd.Location = new Point(346, 182);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(155, 35);
            textBoxEnd.TabIndex = 2;
            // 
            // textBoxDescp
            // 
            textBoxDescp.BackColor = SystemColors.GradientInactiveCaption;
            textBoxDescp.Location = new Point(57, 279);
            textBoxDescp.Multiline = true;
            textBoxDescp.Name = "textBoxDescp";
            textBoxDescp.Size = new Size(535, 113);
            textBoxDescp.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(540, 43);
            label1.Name = "label1";
            label1.Size = new Size(210, 33);
            label1.TabIndex = 5;
            label1.Text = "Etkinlik Türü";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.AntiqueWhite;
            buttonSave.Font = new Font("Consolas", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.DimGray;
            buttonSave.Location = new Point(635, 352);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(131, 40);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Kaydet";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += button1_Click;
            // 
            // textBoxEventType
            // 
            textBoxEventType.BackColor = SystemColors.GradientInactiveCaption;
            textBoxEventType.Location = new Point(540, 78);
            textBoxEventType.Name = "textBoxEventType";
            textBoxEventType.Size = new Size(208, 35);
            textBoxEventType.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(68, 43);
            label2.Name = "label2";
            label2.Size = new Size(210, 33);
            label2.TabIndex = 8;
            label2.Text = "Etkinlik Günü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(68, 146);
            label3.Name = "label3";
            label3.Size = new Size(240, 33);
            label3.TabIndex = 9;
            label3.Text = "Başlangıç Saati";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(346, 146);
            label4.Name = "label4";
            label4.Size = new Size(180, 33);
            label4.TabIndex = 10;
            label4.Text = "Bitiş Saati";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(57, 243);
            label5.Name = "label5";
            label5.Size = new Size(135, 33);
            label5.TabIndex = 11;
            label5.Text = "Açıklama";
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxEventType);
            Controls.Add(buttonSave);
            Controls.Add(label1);
            Controls.Add(textBoxDescp);
            Controls.Add(textBoxEnd);
            Controls.Add(textBoxStart);
            Controls.Add(textBoxDate);
            Name = "EventForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Etkinlik";
            Load += Event_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDate;
        private TextBox textBoxStart;
        private TextBox textBoxEnd;
        private TextBox textBoxDescp;
        private Label label1;
        private Button buttonSave;
        private TextBox textBoxEventType;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}