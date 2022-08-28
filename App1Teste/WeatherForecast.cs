namespace App1Teste
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 82 + (int)(TemperatureC / 0.555);

        public string? Summary { get; set; }
    }
}
