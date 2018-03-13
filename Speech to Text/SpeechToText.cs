using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace Speech_to_Text
{
    public partial class SpeechToText : Form
    {
        SpeechRecognitionEngine recognitionEngine;
        Grammar dictionaryGrammar;
        RecognitionResult result;

        public SpeechToText()
        {
            InitializeComponent();
        }

        private void SpeechToText_Load(object sender, EventArgs e)
        {

        }

        private void speechButton_Click(object sender, EventArgs e)
        {
            recognitionEngine = new SpeechRecognitionEngine();
            dictionaryGrammar = new DictationGrammar();
            recognitionEngine.LoadGrammar(dictionaryGrammar);

            try
            {
                recognitionEngine.SetInputToDefaultAudioDevice();
                result = recognitionEngine.Recognize();
                outputTextBox.Text = result.Text;
            }
            catch (InvalidOperationException exception)
            {
                MessageBox.Show("Could not recognize input from default aduio device. Is a microphone or sound card available?\r\n " + exception.Source + " - " + exception.Message);
            }
            finally
            {
                recognitionEngine.UnloadAllGrammars();
            }
        }
    }
}
