namespace Ekobit.Ekoship.SmartHome.Data.Models
{
    public class Home
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int? AddressId { get; set; }

        public Address? Address { get; set; }

        public int? DeviceId { get; set; }

        public Device? Device { get; set; }
    }
}
