using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace cs_http
{
    public class ResponseFlight
    {
        [JsonPropertyName("flights")]
        public List<Flight> Flights; 
    }
}
