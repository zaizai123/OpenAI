using OpenAILibrary;

namespace OpenAI
{
    public partial class Form1 : Form
    {
        OpenAILib openAI;
        float temperature = 0.0f;
        public Form1()
        {
            InitializeComponent();
            openAI = new OpenAILib();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {

                richTextBoxAnswer.Text = "...";
                string answer = openAI.OpenAIPrompt(question: richTextBoxHumanQuestion.Text, temperature);
                richTextBoxAnswer.Text = answer;
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBarTemperature_ValueChanged(object sender, EventArgs e)
        {
            temperature = (float)trackBarTemperature.Value / 10.0f;
            labelTemperature.Text = $"Tempture: {temperature.ToString("0.0")}";
        }

        private void createImageBtn_Click(object sender, EventArgs e)
        {
            richTextBoxAnswer.Text = ".....";           
            richTextBoxAnswer.Text = openAI.CreateImage(prompt: richTextBoxHumanQuestion.Text);
        }
    }
}