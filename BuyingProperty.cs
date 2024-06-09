using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Home7_csharp
{
    // класс покупка недвижимости
    internal class BuyingProperty<T> where T: IRealProperty
    {
        // ФИО покупателя
        public string CustomerName { get; set; }

        // ФИО продавца
        public string SalerName { get; set; }

        // недвижимость 
        public T RealProperty { get; set;  }
   
        // стоимость покупки
        public decimal PriceProperty { get; set; }

        // метод печатающий информацию о покупаямой недвижимости
        public void Print()
        { 
            Console.WriteLine($"Вид недвижимости: {RealProperty.realProperty}\nПлощадь: {RealProperty.Area}\n" +
                $"Количество комнат: {RealProperty.CountRooms}\nАдрес: {RealProperty.Address}");
        }

        // метод определяющий цену за квадратный метр
        public double PriceMeter()
        {

            return (double)PriceProperty/RealProperty.Area;
        }

    }
}
