namespace Ekobit.Ekoship.SmartHome.WebAPI.Models.Device
{
    public class DeviceDetails
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public bool IsActive { get; set; }

        public float CurrentValue { get; set; }

        public DateTime LastUpdated { get; set; }

        public string Type { get; set; } = null!;

        public string Unit { get; set; } = null!;

        public string HomeName { get; set; } = null!;
    }
}
