namespace OpenAI
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
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelHuman = new System.Windows.Forms.Label();
            this.richTextBoxHumanQuestion = new System.Windows.Forms.RichTextBox();
            this.labelBot = new System.Windows.Forms.Label();
            this.richTextBoxAnswer = new System.Windows.Forms.RichTextBox();
            this.trackBarTemperature = new System.Windows.Forms.TrackBar();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(972, 637);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelHuman
            // 
            this.labelHuman.AutoSize = true;
            this.labelHuman.Location = new System.Drawing.Point(39, 637);
            this.labelHuman.Name = "labelHuman";
            this.labelHuman.Size = new System.Drawing.Size(50, 15);
            this.labelHuman.TabIndex = 1;
            this.labelHuman.Text = "Human:";
            // 
            // richTextBoxHumanQuestion
            // 
            this.richTextBoxHumanQuestion.Location = new System.Drawing.Point(95, 637);
            this.richTextBoxHumanQuestion.Name = "richTextBoxHumanQuestion";
            this.richTextBoxHumanQuestion.Size = new System.Drawing.Size(859, 87);
            this.richTextBoxHumanQuestion.TabIndex = 3;
            this.richTextBoxHumanQuestion.Text = "";
            // 
            // labelBot
            // 
            this.labelBot.AutoSize = true;
            this.labelBot.Location = new System.Drawing.Point(61, 38);
            this.labelBot.MaximumSize = new System.Drawing.Size(700, 0);
            this.labelBot.Name = "labelBot";
            this.labelBot.Size = new System.Drawing.Size(28, 15);
            this.labelBot.TabIndex = 4;
            this.labelBot.Text = "Bot:";
            // 
            // richTextBoxAnswer
            // 
            this.richTextBoxAnswer.Location = new System.Drawing.Point(95, 20);
            this.richTextBoxAnswer.Name = "richTextBoxAnswer";
            this.richTextBoxAnswer.ReadOnly = true;
            this.richTextBoxAnswer.Size = new System.Drawing.Size(859, 599);
            this.richTextBoxAnswer.TabIndex = 5;
            this.richTextBoxAnswer.Text = "";
            // 
            // trackBarTempture
            // 
            this.trackBarTemperature.LargeChange = 3;
            this.trackBarTemperature.Location = new System.Drawing.Point(960, 548);
            this.trackBarTemperature.Name = "trackBarTempture";
            this.trackBarTemperature.Size = new System.Drawing.Size(104, 45);
            this.trackBarTemperature.TabIndex = 6;
            this.trackBarTemperature.ValueChanged += new System.EventHandler(this.trackBarTemperature_ValueChanged);
            // 
            // labelTempture
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(970, 530);
            this.labelTemperature.Name = "labelTempture";
            this.labelTemperature.Size = new System.Drawing.Size(78, 15);
            this.labelTemperature.TabIndex = 7;
            this.labelTemperature.Text = "Tempture: 0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(968, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "0                        1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 736);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.trackBarTemperature);
            this.Controls.Add(this.richTextBoxAnswer);
            this.Controls.Add(this.labelBot);
            this.Controls.Add(this.richTextBoxHumanQuestion);
            this.Controls.Add(this.labelHuman);
            this.Controls.Add(this.buttonSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSend;
        private Label labelHuman;
        private RichTextBox richTextBoxHumanQuestion;
        private Label labelBot;
        private RichTextBox richTextBoxAnswer;
        private TrackBar trackBarTemperature;
        private Label labelTemperature;
        private Label label2;
    }
}