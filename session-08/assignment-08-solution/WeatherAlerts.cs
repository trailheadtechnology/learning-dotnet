using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace json_sample
{
    public static class WeatherAlerts
    {
        public static async Task<WeatherAlertsDto> GetAlertsAsync()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "(jtower@trailheadtechnology.com)");
                var response = await client.GetAsync("https://api.weather.gov/alerts/active?area=FL");
                var json = await response.Content.ReadAsStringAsync();
                var dto = JsonConvert.DeserializeObject<WeatherAlertsDto>(json);

                return dto;
            }
        }
    }

    public class WeatherAlertsDto
    {
        public FeatureDto[] features { get; set; }
    }

    public class FeatureDto
    {
        public FeaturePropertyDto properties { get; set; }
    }

    public class FeaturePropertyDto
    {
        public string description { get; set; }
    }
}
