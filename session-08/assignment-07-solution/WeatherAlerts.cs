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
        public static async Task<IEnumerable<OutputDTO>> GetAlertsAsync(string area, string filterName)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "(jtower@trailheadtechnology.com)");
                var response = await client.GetAsync($"https://api.weather.gov/alerts/active?area={area}");
                var json = await response.Content.ReadAsStringAsync();
                var dto = JsonConvert.DeserializeObject<WeatherAlertsDto>(json);

                //var results = from f in dto.features
                //              where f.properties.description.Contains(filterName)
                //              //select f.properties.description; // IEnumerable<string>
                //              select new OutputDTO { Description = f.properties.description, Feature = f };

                //var r2 = from f2 in results
                //         where f2.Feature != null
                //         select new { f2.Description };

                var results3 = dto.features
                    //.Where(f => f.properties.description.Contains(filterName))
                    .Select(f => new OutputDTO { Description = f.properties.description, Feature = f });

                //var dict = new Dictionary<string, OutputDTO>();
                //dict = (from item in dict
                //        orderby item.Value.Description descending
                //        select item).ToDictionary(x => x.Key, x => x.Value);
                //var results5 = dict.OrderByDescending(item => item.Value.Description).Select(item => item);

                return results3;
            }
        }
    }

    public class OutputDTO
    {
        public string Description { get; set; }
        public FeatureDto Feature { get; set; }
    }

    public class WeatherAlertsDto //data transfer object
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
