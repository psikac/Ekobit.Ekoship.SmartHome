namespace Ekobit.Ekoship.SmartHome.Data.Models
{
    public class Device
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public bool IsActive { get; set; }

        public float CurrentValue { get; set; }

        public DateTime LastUpdated { get; set; }

        public int DeviceTypeId { get; set; }

        public DeviceType Type { get; set; } = null!;

        public int UnitId { get; set; }

        public Unit Unit { get; set; } = null!;

        public int HomeId { get; set; }

        public Home Home { get; set; } = null!;
    }
}
