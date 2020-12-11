using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using blazor5dotnet.Models;

namespace blazor5dotnet.Services
{
    public class WeatherForeCastService : IWeatherForeCastService
    {
        public HttpClient http {get;set;}

        public WeatherForeCastService (HttpClient http)
        {
            this.http = http;
        }

        public async Task<WeatherForecast[]> Get()
        {
            return await http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }
        
    }
}