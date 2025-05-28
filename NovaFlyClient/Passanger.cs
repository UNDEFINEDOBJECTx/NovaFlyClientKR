using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;


namespace NovaFlyClient
{
    public partial class Passanger : Form
    {

        private string d;
        private readonly HttpClient _httpClient;
        private string _token;
        public Passanger(string token)
        {
            _token = token;
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("http://100.119.85.27:8000") };
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
        }

        private async void Confirm_Click(object sender, EventArgs e)
        {
            string url = "http://100.119.85.27:8000/passengers/add/?";

            
            if (na.Text!=null && sur.Text!= null && doc_num!=null && d != null)
            {
                var pas = new
                {
                    surname = sur.Text,
                    name = na.Text,
                    patronymic = patr.Text,
                    date_of_birth = d,
                    document_number = doc_num.Text
                    
                };
                string responb = "";
                try
                {
                    string json = JsonConvert.SerializeObject(pas);
                    MessageBox.Show(json);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                    var response = await _httpClient.PostAsync(url, content);
                    responb = await response.Content.ReadAsStringAsync();
                    response.EnsureSuccessStatusCode();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Операция прошла успешно!");
                        this.Close();
                    }
                     
                }
               catch(HttpRequestException ex)
                {
                   
                    MessageBox.Show("Ошибка: "+ex.Message+" "+responb);
                }
                
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля и выберете дату рождения!");
            }
            
        }

        private void brthday_ValueChanged(object sender, EventArgs e)
        {
            d = brthday.Value.ToString("yyyy-MM-dd");
        }

        private void Passanger_Load(object sender, EventArgs e)
        {

        }
    }
}
