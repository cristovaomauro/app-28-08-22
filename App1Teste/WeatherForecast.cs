namespace App1Teste
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 64 + (int)(TemperatureC / 2);

        public string? Summary { get; set; }
    }
}