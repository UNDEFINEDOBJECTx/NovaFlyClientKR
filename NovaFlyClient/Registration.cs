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
    public partial class Registration : Form
    {
        private readonly HttpClient _httpClient;
        public Registration()
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("http://100.119.85.27:8000") };
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
        private async Task<string> RegUser(string name, string surname, string email, string pass, string cpass)
        {
            StringContent content = new StringContent("", Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync($"http://100.119.85.27:8000/auth/register?email={Uri.EscapeDataString(email)}&name={Uri.EscapeDataString(name)}&surname={Uri.EscapeDataString(surname)}&password={Uri.EscapeDataString(pass)}&confirm_password={Uri.EscapeDataString(cpass)}",content);
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                
                return "Пользователь добавлен";
                   
            }
            else
            {
                
                return "Ошибка: "+ response;
            }
        }
        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private async void ConfirmB_Click(object sender, EventArgs e)
        {
            var user = new 
            {
             email = Email.Text,
             name = Nam.Text,
             surname = Surname.Text,
             password = Password.Text,
             confirm_password = Cpass.Text 
            };


            if (Password.Text != Cpass.Text)
            {
                MessageBox.Show("Ошибка регистрации. Пароли не совпадают.");
            }
            else
            {
                string json = JsonConvert.SerializeObject(user);
                Console.WriteLine(json);
                using (HttpClient client = new HttpClient())
                {
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    try
                    {
                        HttpResponseMessage response = await client.PostAsync("http://100.119.85.27:8000/auth/register/", content);
                        string responseString = await response.Content.ReadAsStringAsync();

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Регистрация прошла успешно!");
                            Login l = new Login();
                            l.Show();
                            this.Close();
                        }

                        else
                        {
                            try
                            {
                                JObject errorResponse = JObject.Parse(responseString);

                                if (errorResponse["detail"] != null && errorResponse["detail"].Type == JTokenType.Array)
                                {
                                    foreach (var detail in errorResponse["detail"])
                                    {
                                        string msg = detail["msg"]?.ToString();
                                        if (!string.IsNullOrEmpty(msg))
                                        {
                                            MessageBox.Show(msg, "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Неизвестная ошибка:\n" + responseString);
                                }
                            }
                            
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Ошибка разбора ответа:\n" + ex.Message);
                                }
                            }
                    }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка подключения: " + ex.Message);
                        }

                }
            }



        }
    }
}
