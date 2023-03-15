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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonSend = new Button();
            labelHuman = new Label();
            richTextBoxHumanQuestion = new RichTextBox();
            labelBot = new Label();
            richTextBoxAnswer = new RichTextBox();
            trackBarTemperature = new TrackBar();
            labelTemperature = new Label();
            label2 = new Label();
            createImageBtn = new Button();
            comboBoxModel = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)trackBarTemperature).BeginInit();
            SuspendLayout();
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(972, 637);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(75, 23);
            buttonSend.TabIndex = 0;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // labelHuman
            // 
            labelHuman.AutoSize = true;
            labelHuman.Location = new Point(39, 637);
            labelHuman.Name = "labelHuman";
            labelHuman.Size = new Size(50, 15);
            labelHuman.TabIndex = 1;
            labelHuman.Text = "Human:";
            // 
            // richTextBoxHumanQuestion
            // 
            richTextBoxHumanQuestion.Location = new Point(95, 637);
            richTextBoxHumanQuestion.Name = "richTextBoxHumanQuestion";
            richTextBoxHumanQuestion.Size = new Size(859, 87);
            richTextBoxHumanQuestion.TabIndex = 3;
            richTextBoxHumanQuestion.Text = "";
            // 
            // labelBot
            // 
            labelBot.AutoSize = true;
            labelBot.Location = new Point(61, 38);
            labelBot.MaximumSize = new Size(700, 0);
            labelBot.Name = "labelBot";
            labelBot.Size = new Size(28, 15);
            labelBot.TabIndex = 4;
            labelBot.Text = "Bot:";
            // 
            // richTextBoxAnswer
            // 
            richTextBoxAnswer.Location = new Point(95, 20);
            richTextBoxAnswer.Name = "richTextBoxAnswer";
            richTextBoxAnswer.ReadOnly = true;
            richTextBoxAnswer.Size = new Size(859, 599);
            richTextBoxAnswer.TabIndex = 5;
            richTextBoxAnswer.Text = "";
            // 
            // trackBarTemperature
            // 
            trackBarTemperature.LargeChange = 3;
            trackBarTemperature.Location = new Point(960, 548);
            trackBarTemperature.Name = "trackBarTemperature";
            trackBarTemperature.Size = new Size(104, 45);
            trackBarTemperature.TabIndex = 6;
            trackBarTemperature.ValueChanged += trackBarTemperature_ValueChanged;
            // 
            // labelTemperature
            // 
            labelTemperature.AutoSize = true;
            labelTemperature.Location = new Point(970, 530);
            labelTemperature.Name = "labelTemperature";
            labelTemperature.Size = new Size(78, 15);
            labelTemperature.TabIndex = 7;
            labelTemperature.Text = "Tempture: 0.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(968, 578);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 8;
            label2.Text = "0                        1";
            // 
            // createImageBtn
            // 
            createImageBtn.Location = new Point(970, 689);
            createImageBtn.Name = "createImageBtn";
            createImageBtn.Size = new Size(103, 23);
            createImageBtn.TabIndex = 9;
            createImageBtn.Text = "Create Image";
            createImageBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            createImageBtn.UseVisualStyleBackColor = true;
            createImageBtn.Click += createImageBtn_Click;
            // 
            // comboBoxModel
            // 
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.Items.AddRange(new object[] { "gpt-3.5-turbo", "gpt-4", "text-davinci-003", "code-davinci-002" });
            comboBoxModel.Location = new Point(968, 487);
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(121, 23);
            comboBoxModel.TabIndex = 10;
            comboBoxModel.Text = "text-davinci-003";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 736);
            Controls.Add(comboBoxModel);
            Controls.Add(createImageBtn);
            Controls.Add(label2);
            Controls.Add(labelTemperature);
            Controls.Add(trackBarTemperature);
            Controls.Add(richTextBoxAnswer);
            Controls.Add(labelBot);
            Controls.Add(richTextBoxHumanQuestion);
            Controls.Add(labelHuman);
            Controls.Add(buttonSend);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Chat AI";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarTemperature).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button createImageBtn;
        private ComboBox comboBoxModel;
    }
}