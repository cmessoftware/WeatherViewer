using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherViewer.WebApiEntities
{
    public class City
    {
        public int Id { get; set; }
        public bool Available { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }
        public Country? Country { get; set; }

    }
}