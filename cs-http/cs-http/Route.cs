using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace cs_http
{
    public class Route
    {
        [JsonPropertyName("destination")]
        public string Destinations { get; set; }

        [JsonPropertyName("eu")]
        public string Eu { get; set; }

        [JsonPropertyName("visa")]

        public string Visa { get; set; }
    }
}
