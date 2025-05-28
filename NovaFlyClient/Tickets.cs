using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaFlyClient
{
    class Tickets
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int passenger_id { get; set; }
        public int flight_id { get; set; }
        public string seat_number { get; set; }
        public int price { get; set; }
    }
}
