using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft;

namespace NovaFlyClient
{
   public class Flight
    {
        public int id { get; set; }
        public string cityfr { get; set; }
        public string airport { get; set; }
        public string cityto { get; set; }
        
        public int plane_id { get; set; }
        public int AC { get; set; }
        public int departure_from { get; set; }
        public DateTime departure_date { get; set; }
        public string departure_time { get; set; }
        public int arrival_to { get; set; }
        public DateTime arrival_date { get; set; }
        public string arrival_time { get; set; }
        public string status { get; set; }


        
    }
}
