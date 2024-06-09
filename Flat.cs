using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7_csharp
{
    // структура квартира 
    internal struct Flat : IRealProperty
    {
        public string realProperty {  get; set; }
        public double Area { get; set; }
        public int CountRooms { get; set; }
        public string Address { get; set; }

        // свойств есть ли балкон в квартире
        public bool IsBalcony { get; set; }

        // свойство есть ли газ в квартире
        public bool IsGas { get; set; }

        // свойство номер этажа
        public int FloarNumber {  get; set; }

        public Flat() 
        {
            realProperty = "Квартира";
        }

    }
}
