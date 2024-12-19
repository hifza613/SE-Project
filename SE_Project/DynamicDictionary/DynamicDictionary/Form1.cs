using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace DynamicDictionary
{
    public partial class Form1 : Form
    {
        private List<NewsElement> newsList;
        private ToolTip wordToolTip;

        public Form1()
        {
            InitializeComponent();
            newsList = new List<NewsElement>();
            wordToolTip = new ToolTip();
            Form1_Load(null, null);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var endpoint = new Uri("https://gnews.io/api/v4/search?q=Nawaz%20Sharif&lang=en&country=pk&max=10&apikey=dce548478d8c155a018fb50fe1a12e7e");

                try
                {
                    var result = await client.GetAsync(endpoint);
                    string json = await result.Content.ReadAsStringAsync();
                    var jsonObject = JObject.Parse(json);
                    var articles = jsonObject["articles"];

                    newsList.Clear();

                    if (articles != null)
                    {
                        foreach (var element in articles)
                        {
                            NewsElement newsElement = new NewsElement
                            {
                                Title = element["title"].ToString(),
                                Description = element["description"].ToString(),
                                Content = element["content"].ToString(),
                                Image = element["image"].ToString()
                            };
                            newsList.Add(newsElement);
                        }
                    }

                    dataGridView1.DataSource = newsList;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching news: {ex.Message}");
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var newsElement = selectedRow.DataBoundItem as NewsElement;

                if (newsElement != null)
                {
                    richTextBox1.Text = $"{newsElement.Title}\n\n{newsElement.Description}\n\n{newsElement.Content}";
                }
            }
        }

        private async void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
       
            string selectedWord = GetSelectedWord();
            if (string.IsNullOrEmpty(selectedWord))
            {
                MessageBox.Show("No word selected.");
                return;
            }

            try
            {
                string definition = await DictionaryService.GetWordDefinitionAsync(selectedWord);

                if (string.IsNullOrEmpty(definition))
                {
                    MessageBox.Show("Definition not found.");
                    return;
                }

                
               richTextBox2.Text = $"{selectedWord}: {definition}";
            }
            catch (HttpRequestException httpEx)
            {
                if (httpEx.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Word not found in the dictionary.");
                }
                else
                {
                    MessageBox.Show($"Error fetching definition: {httpEx.Message}");
                }
            }
            catch (Exception ex)
            {
              
                MessageBox.Show($"Error fetching definition: {ex.Message}");
            }
        }

        private string GetSelectedWord()
        {
            int selectionStart = richTextBox1.SelectionStart;
            int selectionLength = richTextBox1.SelectionLength;

            if (selectionLength > 0)
            {
                return richTextBox1.SelectedText.Trim();  
            }

            return string.Empty; 
        }
    }

    public class NewsElement
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
    }
}
