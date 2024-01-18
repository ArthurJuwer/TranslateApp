using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// adicionar using
// instalar pacote nuGet
using Newtonsoft.Json;


namespace Translate
{
    public partial class Translate : Form
    {
        private const string baseUrl = "http://api.mymemory.translated.net";
        private HttpClient httpClient;
        public Translate()
        {
            InitializeComponent();
            httpClient= new HttpClient();  
        }
        private async Task<string> TranslateAsync(string text, string sourceLang, string targetLang)
        {
            string url = $"{baseUrl}/get?q={Uri.EscapeDataString(text)}&langpair={sourceLang}|{targetLang}";

            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            var translationResult = JsonConvert.DeserializeObject<TranslationReponse>(responseJson);

            if (translationResult.ResponseStatus == 200)
            {
                return translationResult.TranslatedText;
            }
            return string.Empty;
        }
        private void Translate_Load(object sender, EventArgs e)
        {
            cmbSourceLanguage.Items.AddRange(new string[] {"english", "french", "italian", "portuguese", "spanish", "russian"});
            cmbTargetLanguage.Items.AddRange(new string[] {"english", "french", "italian", "portuguese", "spanish", "russian" });
            cmbSourceLanguage.SelectedIndex = 0;
            cmbTargetLanguage.SelectedIndex = 3;
        }
        
        public class TranslationReponse
        {
            [JsonProperty("responseStatus")]
            public int ResponseStatus {  get; set; }
            [JsonProperty("responseData")]
            public TranslationData ResponseData { get; set; }
            public string TranslatedText => ResponseData?.TranslatedText;
        }
        public class TranslationData
        {
            [JsonProperty("translatedText")]
            public string TranslatedText { get; set; }
        }
        private async void btnTraduzir_Click(object sender, EventArgs e)
        {
            try
            {
                string translatedText = await TranslateAsync(textInput.Text, cmbSourceLanguage.SelectedItem.ToString(), cmbTargetLanguage.SelectedItem.ToString());

                textOutput.Text = translatedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
                throw;
            }
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int sourceAtual = cmbSourceLanguage.SelectedIndex;
            int targetAtual = cmbTargetLanguage.SelectedIndex;
            string invertInput = textInput.Text;
            string invertOutput = textOutput.Text;
            // salvar em variantes e armazenar os dados

            if (textInput.Text == "Digite Aqui...")
            {
                MessageBox.Show("Digite algo primeiro para inverter");
                return;
            }


            cmbSourceLanguage.SelectedIndex = targetAtual;
            cmbTargetLanguage.SelectedIndex = sourceAtual;
            textInput.Text = invertOutput;
            textOutput.Text = invertInput;
        }
    }
}
