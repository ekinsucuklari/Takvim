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
            textBoxDate = new TextBox();
            textBoxStart = new TextBox();
            textBoxEnd = new TextBox();
            textBoxDescp = new TextBox();
            label1 = new Label();
            buttonSave = new Button();
            textBoxEventType = new TextBox();
            SuspendLayout();
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(68, 78);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(157, 35);
            textBoxDate.TabIndex = 0;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(68, 182);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(155, 35);
            textBoxStart.TabIndex = 1;
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(280, 182);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(155, 35);
            textBoxEnd.TabIndex = 2;
            // 
            // textBoxDescp
            // 
            textBoxDescp.Location = new Point(57, 279);
            textBoxDescp.Multiline = true;
            textBoxDescp.Name = "textBoxDescp";
            textBoxDescp.Size = new Size(535, 113);
            textBoxDescp.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(540, 34);
            label1.Name = "label1";
            label1.Size = new Size(126, 30);
            label1.TabIndex = 5;
            label1.Text = "Etkinlik Türü";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(617, 308);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(131, 40);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Kaydet";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += button1_Click;
            // 
            // textBoxEventType
            // 
            textBoxEventType.Location = new Point(540, 78);
            textBoxEventType.Name = "textBoxEventType";
            textBoxEventType.Size = new Size(208, 35);
            textBoxEventType.TabIndex = 7;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxEventType);
            Controls.Add(buttonSave);
            Controls.Add(label1);
            Controls.Add(textBoxDescp);
            Controls.Add(textBoxEnd);
            Controls.Add(textBoxStart);
            Controls.Add(textBoxDate);
            Name = "EventForm";
            Text = "Event";
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
    }
}