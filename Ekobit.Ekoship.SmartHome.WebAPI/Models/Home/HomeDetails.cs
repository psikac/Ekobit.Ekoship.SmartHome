namespace Ekobit.Ekoship.SmartHome.WebAPI.Models.Home
{
    public class HomeDetails
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? StreetName { get; set; }

        public int? Number { get; set; }

        public string? City { get; set; }

        public int? ZipCode { get; set; }

        public string? Country { get; set; }
    }
}
