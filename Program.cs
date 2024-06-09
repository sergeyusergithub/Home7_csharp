namespace Home7_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flat flat = new Flat { Area = 35, CountRooms = 1, FloarNumber = 3, Address = "Ekaterinburg 8 Marta 53 - 26",
            IsBalcony = true, IsGas = false};

            PrivateHouse house = new PrivateHouse { 
                Area = 55,AreaLand = 250,CountRooms =3,
                FloarNumber = 1,Address = "Екатеринбург, Московская 33-3"
            };

            BuyingProperty<Flat> buyingFlat = new BuyingProperty<Flat> { 
                CustomerName = "Tom",SalerName = "Alice", RealProperty = flat,PriceProperty = 350000
            };

            BuyingProperty<PrivateHouse> buyingHouse = new BuyingProperty<PrivateHouse>
            {
                CustomerName = "Make",
                SalerName = "Mary",
                RealProperty = house,
                PriceProperty = 660000
            };


            buyingFlat.Print();
            Console.WriteLine($"Цена за квадратный метр: {(int)buyingFlat.PriceMeter()}");
            Console.WriteLine("=============================================");
            buyingHouse.Print();
            Console.WriteLine($"Цена за квадратный метр: {(int)buyingHouse.PriceMeter()}");
        }
    }
}
