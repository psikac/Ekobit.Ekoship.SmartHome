using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekobit.Ekoship.SmartHome.Data.Models
{
    public class Device
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string SerialNr { get; set; } = null!;
    }
}
