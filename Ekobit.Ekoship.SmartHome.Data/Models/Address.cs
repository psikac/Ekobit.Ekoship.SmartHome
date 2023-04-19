namespace Ekobit.Ekoship.SmartHome.Data.Models
{
    public class Address
    {
        public int Id { get; set; }

        public string StreetName { get; set; } = null!;

        public int Number { get; set; }

        public string City { get; set; } = null!;

        public int ZipCode { get; set; }

        public string Country { get; set; } = null!;
    }
}
