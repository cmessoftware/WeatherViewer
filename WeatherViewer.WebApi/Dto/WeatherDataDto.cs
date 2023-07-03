namespace WeatherViewer.WebApiDto
{
    public class WeatherDataDto
    {
        public int Id { get; set; }
        public decimal Temperature { get; set; }

        public string ThermalSensation { get; set; }

        public CountryDto Country { get; set; }
        public CityDto City { get; set; }

    }
}