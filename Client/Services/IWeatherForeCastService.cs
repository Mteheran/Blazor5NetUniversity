using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor5dotnet.Models;

namespace blazor5dotnet.Services
{
    public interface IWeatherForeCastService
    {
        Task<WeatherForecast[]> Get();
    }
}