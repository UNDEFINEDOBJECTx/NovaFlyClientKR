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
using System.Text.RegularExpressions;

namespace NovaFlyClient
{
    
    public partial class ChangePassenger : Form
    {
        Passenger tmp = new Passenger();
        private string nam = "";
        private string surn = "";
        private string patr = "";
        private string docnum = "";


        private readonly HttpClient _httpClient;
        private string _token;
        public ChangePassenger(string token)
        {
            _token = token;
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("http://100.119.85.27:8000") };
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
        }

        private void ChangePassenger_Load(object sender, EventArgs e)
        {
            updatei();
        }
        private async void updatei()
        {
            try
            {
                var response = await _httpClient.GetAsync("http://100.119.85.27:8000/passengers/");
                response.EnsureSuccessStatusCode(); // Проверка на ошибки HTTP

                string content = await response.Content.ReadAsStringAsync();
                List<Passenger> p = JsonConvert.DeserializeObject<List<Passenger>>(content);
                p.Insert(0, new Passenger());

                pascol.DataSource = p;
                pascol.DisplayMember = "surname";
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Ошибка запроса: {ex.Message}");

            }
        }








        private void pascol_SelectedIndexChanged(object sender, EventArgs e)
        {
             tmp =(Passenger) pascol.SelectedItem;

            n1.Text = tmp.name;
            sn1.Text = tmp.surname;
            ptr1.Text = tmp.patronymic;
            dn1.Text = tmp.document_number;
        }

        private async void chang_Click(object sender, EventArgs e)
        {
            string url = $"http://100.119.85.27:8000/passengers/{tmp.id}";
            //Формирование изменений
            //Имя
            if (n2.Text != "")
            {
                nam = n2.Text;
            }
            else
            {
                nam = n1.Text;
            }
            //Фамилия
            if(sn2.Text != "")
            {
                surn = sn2.Text;
            }
            else
            {
                surn = sn1.Text;
            }
            //Отчество
            if (ptr2.Text != "")
            {
                patr = ptr2.Text;
            }
            else
            {
                patr = ptr1.Text;
            }
            //Номер документа
            if (dn2.Text != "")
            {
                docnum = dn2.Text;
            }
            else
            {
                docnum = dn1.Text;
            }

            var newuser = new
            {
                name = nam,
                surname = surn,
                patronymic = patr,
                document_number = docnum
            };
            try
            {
                string json = JsonConvert.SerializeObject(newuser);

                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PutAsync(url, content);
                
                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Операция прошла успешно!");
                    this.Close();
                }
            }
            catch(HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
