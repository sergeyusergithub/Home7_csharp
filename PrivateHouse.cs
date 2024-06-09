using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7_csharp
{
    // структура Частный дом
    internal struct PrivateHouse : IRealProperty
    {
        public string realProperty {  get; set; }
        public double Area { get; set; }
        public int CountRooms { get; set; }
        public string Address { get; set; }

        // количество этажей
        public int FloarNumber { get; set; }

        // площадь земельного участка
        public double AreaLand { get; set; }

        public PrivateHouse()
        {
            realProperty = "Частный дом";
        }
    }
}
