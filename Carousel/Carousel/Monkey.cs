using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Carousel
{
    public class Monkey
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Location")]
        public string Location { get; set; }
        [JsonProperty("Details")]
        public string Details { get; set; }
        [JsonProperty("Image")]
        public string Image { get; set; }
        [JsonProperty("Population")]
        public int Population { get; set; }
        [JsonProperty("Latitude")]
        public double Latitude { get; set; }
        [JsonProperty("Longitude")]
        public double Longitude { get; set; }
    }
}
