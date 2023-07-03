namespace WeatherViewer.WebApiEntities
{
    public class WeatherData
    {
        public int Id { get; set; }
        public decimal Temperature { get; set; }

        public string ThermalSensation { get; set; }

        public Country Country { get; set; }
        public City City { get; set; }

    }
}