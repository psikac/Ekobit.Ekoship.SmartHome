namespace Ekobit.Ekoship.SmartHome.WebAPI.Models.Device
{
    public class DeviceList
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public bool IsActive { get; set; }

        public string Type { get; set; } = null!;

        public string HomeName { get; set; } = null!;
    }
}
