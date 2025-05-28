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
    public partial class Shedule : Form
    {
        //Переменные для поиска рейса
        //--------------------------------------------------------------------------------------------------------------
        private Airports d = new Airports();
        private Airports a = new Airports();
        private string dd = null;
        private string ad = null;
        //--------------------------------------------------------------------------------------------------------------



        //Переменные для АПИ
        //--------------------------------------------------------------------------------------------------------------
        private string _token;
        private readonly HttpClient _httpClient;
        //--------------------------------------------------------------------------------------------------------------



        //Техническая инфа
        //--------------------------------------------------------------------------------------------------------------
        public Shedule(string token)
        {
            _token = token;
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("http://100.119.85.27:8000") };
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

        }
        //--------------------------------------------------------------------------------------------------------------




        //Получение значений города и аэропорта (нужно для составления расписания)
        //--------------------------------------------------------------------------------------------------------------
        private async Task<string> GetAirportCodeAsync(int id)
        {
            try
            {
                // Отправляем GET-запрос (без тела)
                HttpResponseMessage response = await _httpClient.GetAsync($"http://100.119.85.27:8000/airports/{id}");

                if (!response.IsSuccessStatusCode)
                {
                    var errorResponse = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Ошибка: {response.StatusCode}\nОтвет сервера: {errorResponse}");
                    return null;
                }

                // Читаем ответ
                string jsonResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Ответ сервера: " + jsonResponse); // Для отладки

                // Парсим JSON (используем dynamic для гибкости)
                dynamic responseData = JsonConvert.DeserializeObject(jsonResponse);

                // Проверяем наличие airport_code
                if (responseData?.airport_code == null)
                {
                    Console.WriteLine("В ответе нет поля 'airport_code'");
                    return null;
                }

                return (string)responseData.airport_code;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Ошибка сети: {ex.Message}");
                return null;
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Ошибка парсинга JSON: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
                return null;
            }
        }
        private async Task<string> City(int id)
        {


            HttpResponseMessage response = await _httpClient.GetAsync($"http://100.119.85.27:8000/airports/{id}");

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();

                dynamic responseData = JsonConvert.DeserializeObject(jsonResponse);
                return responseData.city; 
            }
            else
            {
                var errorResponse = await response.Content.ReadAsStringAsync();

                return null;
            }
        }
        //--------------------------------------------------------------------------------------------------------------




        //Загрузка формы
        //--------------------------------------------------------------------------------------------------------------
        private void Shedule_Load(object sender, EventArgs e)
        {
            Update_info();
        }
        //--------------------------------------------------------------------------------------------------------------





        //Обновление информации по кнопке
        //--------------------------------------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            Update_info();
        }
        //--------------------------------------------------------------------------------------------------------------






        //Обновление информации в таблице и выдвигающихся списках
        //--------------------------------------------------------------------------------------------------------------
        private async void Update_info()
        {
            HttpResponseMessage respon = await _httpClient.GetAsync("http://100.119.85.27:8000/flights");
            respon.EnsureSuccessStatusCode();

            string responb = await respon.Content.ReadAsStringAsync();
            List<Flight> fl = JsonConvert.DeserializeObject<List<Flight>>(responb);

            foreach (var id in fl)
            {
                id.cityfr = await City(id.departure_from);
                id.airport = await GetAirportCodeAsync(id.departure_from);
                id.cityto = await City(id.arrival_to);
            }
            Shed.DataSource = fl;
            for (int i = 0; i < Shed.Columns.Count; i++)
            {
                Shed.Columns[i].ReadOnly = true;
            }
            Shed.AllowUserToOrderColumns = false;
            Shed.AllowUserToAddRows = false;
            Shed.Columns.Remove("plane_id");
            Shed.Columns.Remove("AC");
            Shed.Columns.Remove("departure_from");
            Shed.Columns.Remove("arrival_to");

            Shed.Refresh();

            respon = await _httpClient.GetAsync("http://100.119.85.27:8000/airports/");
            respon.EnsureSuccessStatusCode();

            responb = await respon.Content.ReadAsStringAsync();
            List<Airports> air = JsonConvert.DeserializeObject<List<Airports>>(responb);
            List<Airports> air1 = JsonConvert.DeserializeObject<List<Airports>>(responb);
            air.Insert(0, new Airports());
            air1.Insert(0, new Airports());
            DERFR.DataSource = air;
            DERFR.DisplayMember = "city";

            ARRTO.DataSource = air1;
            ARRTO.DisplayMember = "city";
        }
        //--------------------------------------------------------------------------------------------------------------




        //Геттеры рейсов и пассажиров по айди
        //--------------------------------------------------------------------------------------------------------------
        private async Task<Flight> GetFlight(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"http://100.119.85.27:8000/flights/{id}");
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();

                Flight tmp = JsonConvert.DeserializeObject<Flight>(jsonResponse);
                return tmp;
            }
            else
            {
                var errorResponse = await response.Content.ReadAsStringAsync();

                return null;
            }
        }
        private async Task<Passenger> GetPassenger(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"http://100.119.85.27:8000/passengers/{id}");
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();

                Passenger tmp = JsonConvert.DeserializeObject<Passenger>(jsonResponse);
                return tmp;
            }
            else
            {
                var errorResponse = await response.Content.ReadAsStringAsync();

                return null;
            }
        }
        //--------------------------------------------------------------------------------------------------------------





        //Выход из приложения (Окончание работы проекта)
        //--------------------------------------------------------------------------------------------------------------
        private void Shedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //--------------------------------------------------------------------------------------------------------------



        //Поиск рейса
        //--------------------------------------------------------------------------------------------------------------
        private async void Search_Click(object sender, EventArgs e)
        {
            string url = $"http://100.119.85.27:8000/flights/filter/by?";

            if (d.id > 0)
            {
                url += $"departure_from={d.id}&";
            }
            if (a.id > 0)
            {
                url += $"arrival_to={a.id}&";
            }
            if(dd != null)
            {
                url += $"departure_date={dd}&";
            }
            if (ad != null)
            {
                url += $"arrival_date={ad}&";
            }
            try
            {
             HttpResponseMessage respon = await _httpClient.GetAsync(url);
            respon.EnsureSuccessStatusCode();





            string responb = await respon.Content.ReadAsStringAsync();
            List<Flight> fl = JsonConvert.DeserializeObject<List<Flight>>(responb);

            foreach (var id in fl)
            {
                id.cityfr = await City(id.departure_from);
                id.airport = await GetAirportCodeAsync(id.departure_from);
                id.cityto = await City(id.arrival_to);
            }

            
            Shed.DataSource = fl;

            Shed.Columns.Remove("plane_id");
            Shed.Columns.Remove("AC");
            Shed.Columns.Remove("departure_from");
            Shed.Columns.Remove("arrival_to");
            //hed.Columns[5].

            Shed.Refresh();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP Error: {ex.Message}");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unknown Error: {ex.Message}");
                
            }


            MessageBox.Show(d+" "+a + " " +dd + " " +ad);
        }
        //--------------------------------------------------------------------------------------------------------------




        //Установка значений для поиска
        //--------------------------------------------------------------------------------------------------------------
        private void DERFR_SelectedIndexChanged(object sender, EventArgs e)
        {
            d = (Airports) DERFR.SelectedItem ;
        }
        private void ARRTO_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = (Airports) ARRTO.SelectedItem ;
        }
        private void DEPD_ValueChanged(object sender, EventArgs e)
        {
            
            dd = DEPD.Value.ToString("yyyy-MM-dd");
        }
        private void ARRD_ValueChanged(object sender, EventArgs e)
        {
            ad = ARRD.Value.ToString("yyyy-MM-dd");
        }
        //--------------------------------------------------------------------------------------------------------------




        //Заказ билета
        //--------------------------------------------------------------------------------------------------------------
        private void ticketclk_Click(object sender, EventArgs e)
        {
            

            Ticket t = new Ticket(_token);
            t.Show();

        }
        //--------------------------------------------------------------------------------------------------------------



        //Просмотр билетов
        //--------------------------------------------------------------------------------------------------------------
        private async void tickets_Click(object sender, EventArgs e)
        {
            InfoT.Clear();
            HttpResponseMessage respon = await _httpClient.GetAsync("http://100.119.85.27:8000/tickets/");
            respon.EnsureSuccessStatusCode();

            string responb = await respon.Content.ReadAsStringAsync();
            List<Tickets> p = JsonConvert.DeserializeObject<List<Tickets>>(responb);
            foreach(var item in p)
            {
                try
                {
                    Flight fltmp = await GetFlight(item.flight_id);
                    Passenger pastmp = await GetPassenger(item.passenger_id);

                    fltmp.cityfr = await City(fltmp.departure_from);
                    fltmp.cityto = await City(fltmp.arrival_to);
                    fltmp.airport = await GetAirportCodeAsync(fltmp.departure_from);

                    InfoT.Text += $"----------------------------------------------------------------------\r\n" +
                        $"БИЛЕТ №{item.id}\r\n" +
                        $"\r\n" +
                        $"Откуда: {fltmp.cityfr}\r\n" +
                        $"Аэропорт: {fltmp.airport}\r\n" +
                        $"Куда: {fltmp.cityto}\r\n" +
                        $"Время отправления: {fltmp.departure_date.ToString("yyyy-MM-dd")} {fltmp.departure_time}\r\n" +
                        $"Время прибытия: {fltmp.arrival_date.ToString("yyyy-MM-dd")} {fltmp.arrival_time}\r\n" +
                        $"\r\n" +
                        $"----------------------------------------------------------------------\r\n" +
                        $"ДАННЫЕ ПАССАЖИРА\r\n" +
                        $"\r\n" +
                        $"Фамилия: {pastmp.surname}\r\n" +
                        $"Имя: {pastmp.name}\r\n" +
                        $"Отчество: {pastmp.patronymic}\r\n" +
                        $"Номер документа: {pastmp.document_number}\r\n" +
                        $"Номер места: {item.seat_number}\r\n" +
                        $"\r\n"+
                        $"----------------------------------------------------------------------\r\n" +
                        $"ЦЕНА: {item.price} $\r\n" +
                        $"\r\n" +
                        $"\r\n";

                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        //--------------------------------------------------------------------------------------------------------------
    }
}
