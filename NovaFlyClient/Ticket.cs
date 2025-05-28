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
    public partial class Ticket : Form
    {
        private readonly HttpClient _httpClient;
        private string _token;
        public Ticket(string token)
        {
            _token = token;
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("http://100.119.85.27:8000") };
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Authorization =new AuthenticationHeaderValue("Bearer", _token);
           
        }
        private async void Updatei()
        {
            try
            {
                var response = await _httpClient.GetAsync("http://100.119.85.27:8000/passengers/");
                response.EnsureSuccessStatusCode(); // Проверка на ошибки HTTP

                string content = await response.Content.ReadAsStringAsync();
                List<Passenger> p = JsonConvert.DeserializeObject<List<Passenger>>(content);
                p.Insert(0, new Passenger());

                passang.DataSource = p;
                passang.DisplayMember = "surname";

                response = await _httpClient.GetAsync("http://100.119.85.27:8000/flights");
                string responb = await response.Content.ReadAsStringAsync();
                List<Flight> fl = JsonConvert.DeserializeObject<List<Flight>>(responb);
                fl.Insert(0, new Flight());
                List<int> id_fl = new List<int>();
                foreach(var idx in fl)
                {
                    id_fl.Add(idx.id);
                }
                flight.DataSource = fl;
                flight.DisplayMember = "id";
                
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Ошибка запроса: {ex.Message}");
               
            }
        }
        private void Ticket_Load(object sender, EventArgs e)
        {
            Updatei();
            
        }

        private void Newpas_Click(object sender, EventArgs e)
        {
            Passanger p = new Passanger(_token);
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Updatei();
        }

        private async void ticke_Click(object sender, EventArgs e)
        {
            string responb = "";
            if (flight.SelectedIndex!=0&&passang.SelectedIndex!=0&&seat.Text!= "")
            {
                Flight selectfl =(Flight) flight.SelectedItem;
                Passenger selectp = (Passenger)passang.SelectedItem;
                var tick = new
                {
                passenger_id = selectp.id,
                flight_id = selectfl.id,
                seat_number = seat.Text,
                price = 15
                };

                try
                {
                    string json = JsonConvert.SerializeObject(tick);
                    
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                    var response = await _httpClient.PostAsync("http://100.119.85.27:8000/tickets/add", content);
                        responb = await response.Content.ReadAsStringAsync();
                    response.EnsureSuccessStatusCode();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Операция прошла успешно!");
                        this.Close();
                    }
                }
                catch (HttpRequestException ex)
                {

                    MessageBox.Show("Ошибка: " + ex.Message + responb);
                }

            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля!");
            }
           
        }

        

        private void changpas_Click(object sender, EventArgs e)
        {
            ChangePassenger chp = new ChangePassenger(_token);
            chp.Show();
        }
    }
}
