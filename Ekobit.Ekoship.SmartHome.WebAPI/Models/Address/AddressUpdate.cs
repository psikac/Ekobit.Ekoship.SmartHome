namespace Ekobit.Ekoship.SmartHome.WebAPI.Models.Address
{
    public class AddressUpdate
    {
        public string StreetName { get; set; } = null!;

        public int Number { get; set; }

        public string City { get; set; } = null!;

        public int ZipCode { get; set; }

        public string Country { get; set; } = null!;
    }
}
