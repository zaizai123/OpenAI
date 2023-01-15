using OpenAILibrary;

namespace OpenAI
{
    public partial class Form1 : Form
    {
        OpenAILib openAI;
        public Form1()
        {
            InitializeComponent();
            openAI = new OpenAILib();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            openAI.OpenAIPrompt(textBoxHumanQuestion.Text);
        }
    }
}