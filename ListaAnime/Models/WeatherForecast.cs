using System;

namespace ListaAnime
{
    public class WeatherForecast
    {
        internal DateTime Date;

        public string Titulo { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
