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
using System.Windows.Forms;

namespace NovaFlyClient
{
    public partial class Login : Form
    {
        private readonly HttpClient _httpClient;
        public Login()
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("http://100.119.85.27:8000") };
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
       

    private void Login_Load(object sender, EventArgs e)
        {

        }

        private async Task<string> AuthenticateUser(string email, string password)
        {
            var user = new
            {
                email = email,
                password = Uri.EscapeDataString(password)
            };

            string json = JsonConvert.SerializeObject(user);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync($"http://100.119.85.27:8000/auth/login", content);

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();

                dynamic responseData = JsonConvert.DeserializeObject(jsonResponse);
                return responseData.access_token; // Извлечение токена
            }
            else
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                MessageBox.Show(errorResponse);
                return null;
            }
        }

        private async void LoginB_Click(object sender, EventArgs e)
        {
            string email = Email.Text; // Поле для ввода email
            string password = Password.Text; // Поле для ввода пароля
            using (var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10)))
                try
                {

                    
                    var token = await AuthenticateUser(email, password);
                    if (!string.IsNullOrEmpty(token))
                    {

                        Shedule shed = new Shedule(token);
                        shed.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Ошибка аутентификации. Проверьте данные.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка: " + ex.Message);
                }
        }
    }
}
