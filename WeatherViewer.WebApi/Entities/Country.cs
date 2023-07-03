namespace WeatherViewer.WebApiEntities
{
    public class Country
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string ThreeLetterIsoCode { get; set; }

        public string TwoLetterIsoCode { get; set; }

        public List<City> Cities { get; set; }

       
    }
}