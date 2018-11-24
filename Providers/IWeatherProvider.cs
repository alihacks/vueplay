using System.Collections.Generic;
using vueplay.Models;

namespace vueplay.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
