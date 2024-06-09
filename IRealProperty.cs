using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7_csharp
{
    // интерфейс недвижимость
    internal interface IRealProperty
    {
        // статическое поле содержащее название недвижимости
        string realProperty { get; set; }

        //свойство содержащее площадь недвижимости
        double Area { get; set; }

        // свойство количество комнат
        int CountRooms { get; set; }

        // свойство адрес недвижимости
        string Address { get; set; }
    }
}
