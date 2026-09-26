namespace Ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1st answer point a 
            //// Struct is value type 
            //DeliveryAddress Address_1 = new DeliveryAddress()
            //{
            //    City = "Cairo",
            //    Street = "Tahrer"
            //};
            //Console.WriteLine(Address_1);
            //DeliveryAddress Address_2 = Address_1;

            //Address_2.Street = "Elmo3z";

            //Console.WriteLine(Address_2);
            //Console.WriteLine(Address_1);

            //// Edit Address_2 ==> not change Address_1


            #endregion

            #region 1st answer point b
            // Class is Rev type
            Customer customer01 = new Customer();
            customer01.Name = "Joo";

            Customer customer02 = customer01;
            Console.WriteLine(customer01);
            Console.WriteLine(customer02);

            customer02.Name = "Seka";
            Console.WriteLine(customer01);
            Console.WriteLine(customer02);

            // if customer01 (or customer02) change ==> another customer02 (or customer01) make same change , bacause are the same address in heap
            #endregion

            #region 2st answer point a
            // All field are public 
            // No validation
            // No control access
            #endregion

            #region 2st answer point b
            Shipment shipment01 = new Shipment();
            shipment01.Description = "Phone";
            shipment01.weight = 1.0;
            shipment01.DeliveryFee = 20;
            #endregion

        }
    }
}
