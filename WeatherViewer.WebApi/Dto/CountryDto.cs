namespace WeatherViewer.WebApiDto
{
    public class CountryDto
    {

        public string Name { get; set; }

        public string ThreeLetterIsoCode { get; set; }

        public string TwoLetterIsoCode { get; set; }

        public List<CityDto> Cities { get; set; }

       
    }
}