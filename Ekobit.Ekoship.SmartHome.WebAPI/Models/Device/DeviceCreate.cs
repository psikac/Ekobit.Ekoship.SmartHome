namespace Ekobit.Ekoship.SmartHome.WebAPI.Models.Device
{
    public class DeviceCreate
    {
        public string Name { get; set; } = null!;

        public bool IsActive { get; set; }

        public float CurrentValue { get; set; }

        public int TypeId { get; set; }

        public int UnitId { get; set; }

        public int HomeId { get; set; }
    }
}
