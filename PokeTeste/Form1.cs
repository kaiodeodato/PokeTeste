using RestSharp;
using Newtonsoft.Json;
using System.Net;
using ClassLibrary1;


namespace PokeTeste
{
    public partial class Form1 : Form
    {
        private Class1.RootCall1 result;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();

                if (numericUpDown1.Value > 0)
                {
                    var amount = numericUpDown1.Value;
                    var client = new RestClient("https://pokeapi.co/api/v2/");
                    var request = new RestRequest($"pokemon?limit={amount}&offset=0");
                    var response = client.Execute(request);

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        label5.Text = response.StatusCode.ToString();
                        string rawResponse = response.Content;
                        result = JsonConvert.DeserializeObject<Class1.RootCall1>(rawResponse);

                        if (result != null)
                        {
                            foreach (var obj in result.results)
                            {
                                listBox1.Items.Add(obj.name);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Erro na chamada da API. STATUS:{response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedPokemonName = listBox1.SelectedItem.ToString();
                var client = new RestClient("https://pokeapi.co/api/v2/");
                var request = new RestRequest($"pokemon/{selectedPokemonName}");
                var response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string rawResponse = response.Content;
                    var pokemomDetails = JsonConvert.DeserializeObject<Class1.RootCall2>(rawResponse);

                    if (pokemomDetails != null)
                    {

                        if (pokemomDetails.sprites.other.home.front_default != null)
                        {
                            Image loadedImage1 = LoadImageFromUrl(pokemomDetails.sprites.other.home.front_default);
                            Image loadedImage2 = LoadImageFromUrl(pokemomDetails.sprites.front_default);

                            if (loadedImage1 != null)
                            {
                                pictureBox1.Image = ResizeImage(loadedImage1, 200, 200);
                            }
                            if (loadedImage2 != null)
                            {
                                pictureBox2.Image = ResizeImage(loadedImage2, 200, 200);
                            }
                        }

                        if (!string.IsNullOrEmpty(selectedPokemonName))
                        {
                            textBox1.Text = selectedPokemonName;
                        }

                        if (pokemomDetails.abilities.Length > 0)
                        {
                            List<string> abilitiesList = new List<string>();

                            foreach (var item in pokemomDetails.abilities)
                            {
                                abilitiesList.Add(item.ability.name);
                            }

                            string joinedAbilities = string.Join(", ", abilitiesList);

                            textBox2.Text = joinedAbilities;
                        }

                        if (pokemomDetails.base_experience != 0)
                        {
                            textBox3.Text = pokemomDetails.base_experience.ToString();
                        }



                        //habilidades



                    }

                }


            }
        }

        private Image LoadImageFromUrl(string url)
        {
            try
            {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead(url);
                Bitmap bitmapl = new Bitmap(stream);
                stream.Close();
                return bitmapl;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar imagem:{ex}");
                return null;
            }
        }
        private Image ResizeImage(Image image, int width, int height)
        {
            try
            {
                return new Bitmap(image, new Size(width, height));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao redimensionar imagem: {ex}");
                return null;
            }
        }
    }
}