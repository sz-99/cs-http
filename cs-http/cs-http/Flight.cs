using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace cs_http
{
    public class Flight
    {
        [JsonPropertyName("flightName")]
        public string FlightName { get; set; } = "";

        [JsonPropertyName("id")]
        public int Id  { get; set; }

        [JsonPropertyName("scheduleDate")]
        public string ScheduledDate { get; set; } = "";

        [JsonPropertyName("terminal")]
        public string Terminal { get; set; }

        [JsonPropertyName("actualLandingTime")]
        public string ActualLandingTime { get; set; } = "";

        [JsonPropertyName("aircraftType")]
        public string AircraftType { get; set; } = "";

        [JsonPropertyName("route")]
        public Route Route { get; set; } = new Route();
    }
}
