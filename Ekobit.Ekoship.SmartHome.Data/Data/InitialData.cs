using Ekobit.Ekoship.SmartHome.Data.Models;

namespace Ekobit.Ekoship.SmartHome.Data.Data
{
	public static class InitialData
	{
		public static Address[] Addresses = new Address[]
		{
			new Address{Id = 1, Country = "HR", City = "Varazdin", ZipCode = 42000, StreetName = "Pavlinska", Number  = 2},
			new Address{Id = 2, Country = "HR", City = "Varazdin", ZipCode = 42000, StreetName = "Zagrebacka", Number  = 5}
		};

		public static Home[] Homes = new Home[]
		{
			new Home{Id = 1, AddressId = 1, Name = "Dvorana 6"},
			new Home{Id = 2, AddressId = 1, Name = "Dvorana 7"},
		};
	}
}
