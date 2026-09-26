namespace Ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1st answer point a 
            // Struct is value type 
            DeliveryAddress Address_1 = new DeliveryAddress()
            {
                City = "Cairo",
                Street = "Tahrer"
            };
            Console.WriteLine(Address_1);
            DeliveryAddress Address_2 = Address_1;

            Address_2.Street = "Elmo3z";

            Console.WriteLine(Address_2);
            Console.WriteLine(Address_1);

            // Edit Address_2 ==> not change Address_1


            #endregion

        }
    }
}
