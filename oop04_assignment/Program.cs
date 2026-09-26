namespace oop04_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Q1 Abstraction
            /*
                        a)Abstraction is hiding the impelemented code and display the important data or information for the user .

                        b)because it does :
                            1) reduces complexity .
                            2) improves maintainability .
                            3) enhances security .
            */
            #endregion
            #region Q2 Abstract Classes vs. Interfaces 
            /*
                    a) interface purpose is to define a contract while 
                       abstract class purpose is provide base functionality and common behavior . 

                    b) if iam just going to define a signature methods making sure that the class which is going 
                        to inherit use all this methods " mehtod contract " .

                    c) no it can't , yes it can .
            */
            #endregion
            #endregion


            #region Destinations .
            DeliveryAddress S_D = new DeliveryAddress("cairo", "str1" , 12);
            DeliveryAddress E_D = new DeliveryAddress("cairo", "str2", 13);
            DeliveryAddress I_D = new DeliveryAddress("japan","Tokyo", "str3", 14);
            #endregion


            #region Shipments .
            StandardShipment standard_S = new StandardShipment("Sh001", "standard", 12.3m, 300m, S_D, "ready");
            ExpressShipment Express_s = new ExpressShipment("sh002", "Express", 18.3m, 700m, E_D, 233m , "not ready");
            InternationalShipment international_S = new InternationalShipment("sh003", "international", 18.3m, 700m, I_D , 233m , "ready");
            #endregion

            #region Adding shipments .
            DeliveryCenter Delivery_c = new DeliveryCenter();

            Delivery_c.AddShipment(standard_S);
            Delivery_c.AddShipment(Express_s);
            Delivery_c.AddShipment(international_S);
            #endregion

            #region Print All Shipments .
            Delivery_c.PrintAllShipments();
            #endregion


            #region Print All the tracking status of every shipment.
            Delivery_c.PrintAllTrackingStatues();
            #endregion

            #region Print All the insurance cost of every shipment.
            Delivery_c.PrintAllInsurance();
            #endregion

            
            #region Store the shipment objects in an ITrackable[] array and print their tracking statuses.
            Console.WriteLine("=================================================Tracking Statuses Array:");
            ITrackable[] ii = new ITrackable[]
            {
                standard_S , Express_s , international_S
            };
            foreach (ITrackable t in ii)
            {
                Console.WriteLine(t.GettrackingStatus());
                Console.WriteLine("=================================================");
            }
            Console.WriteLine();
            #endregion


            #region Store the shipment objects in an IInsurable[] array and print their insurance values.
            Console.WriteLine("=================================================Insurance Array:");
            IInsurable[] ss = new IInsurable[] {
                standard_S , Express_s , international_S
            };
            foreach (IInsurable j in ss)
            {
                Console.WriteLine(j.CalculateInsurance());
                Console.WriteLine("=================================================");
            }
            Console.WriteLine();
            #endregion 
        }
    }
}
