namespace Ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1

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
            //// Class is Rev type
            //Customer customer01 = new Customer();
            //customer01.Name = "Joo";

            //Customer customer02 = customer01;
            //Console.WriteLine(customer01);
            //Console.WriteLine(customer02);

            //customer02.Name = "Seka";
            //Console.WriteLine(customer01);
            //Console.WriteLine(customer02);

            //// if customer01 (or customer02) change ==> another customer02 (or customer01) make same change , bacause are the same address in heap
            #endregion

            #region 2st answer point a
            //// All field are public 
            //// No validation
            //// No control access
            #endregion

            #region 2st answer point b
            //Shipment shipment01 = new Shipment();
            //shipment01.Description = "Phone";
            //shipment01.weight = 1.0;
            //shipment01.DeliveryFee = 20;
            #endregion

            #endregion

            #region Part 2
            DeliveryCenter deliveryCenter = new DeliveryCenter(10);

            Console.WriteLine("Enter Data for 3 Shipments :");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Shipment {i + 1}:");

                Console.Write("Enter Tracking Code: ");
                string code = Console.ReadLine();

                Console.Write("Enter Description: ");
                string desc = Console.ReadLine();

                Console.Write("Enter Weight: ");
                double.TryParse(Console.ReadLine(), out double weight);

                Console.Write("Enter Delivery Fee: ");
                double.TryParse(Console.ReadLine(), out double fee);

                Console.Write("Enter City: ");
                string city = Console.ReadLine();

                Console.Write("Enter Street: ");
                string street = Console.ReadLine();

                Console.Write("Enter Building Number: ");
                int.TryParse(Console.ReadLine(), out int bldgNo);

                DeliveryAddress addr = new DeliveryAddress(city, street, bldgNo);
                Shipment ship = new Shipment(code, desc, weight, fee, addr);

                deliveryCenter.AddShipment(ship);
            }

            Console.WriteLine("Printing Shipments Using Integer Indexer :");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(deliveryCenter[i]);
            }
            #endregion


        }
    }
}
