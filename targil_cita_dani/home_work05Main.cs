using System;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------Cookie---------------------------
            //2.1
            //Create new Cookie object
            Cookie cookie1 = new Cookie();
            Cookie cookie2 = new Cookie();
            Cookie cookie3 = new Cookie();
            //-------------------------------------------------------
            //2.2 and 2.3
            //adding values to all my cookie
            cookie1.Gluten = false;
            cookie1.Eggs = 4;
            cookie1.QuantityOfFlour = 300;
            cookie1.QuantityOfSugar = 100;
            
            cookie2.Gluten = true;
            cookie2.Eggs = 6;
            cookie2.QuantityOfFlour = 200;
            cookie2.QuantityOfSugar = 50;
            //-------------------------------------------------------
            //2.5
            Console.WriteLine($"For cookie 1 {PrintDetails(cookie1)}");
            Console.WriteLine($"For cookie 2 {PrintDetails(cookie2)}");
            //-------------------------------------------------------
            //2.6
            cookie1.QuantityOfSugar = 75;
            //-------------------------------------------------------
            //2.7
            //print detaills of my cookie
            Console.WriteLine($"For cookie 1 {PrintDetails(cookie1)}");
            Console.WriteLine($"For cookie 2 {PrintDetails(cookie2)}");
            //-------------------------------------------------------
            //2.8
            cookie1 = cookie2;
            //-------------------------------------------------------
            //2.9
            cookie2.Eggs = 7;
            //-------------------------------------------------------
            //2.10
            Console.WriteLine($"For cookie 1 {PrintDetails(cookie1)}");
            Console.WriteLine($"For cookie 2 {PrintDetails(cookie2)}");
            //Because the value of cookie2 goes to cookie1 so they are the same

            //-----------------------Car------------------------------
            //2.1
            Car car1 = new Car();
            car1.CarName = "Ford";
            //-------------------------------------------------------
            //2.2
            Console.WriteLine($"car1 : {PrintCar(car1)}");
            //-------------------------------------------------------
            //2.3
            Console.WriteLine("how much speed you want to take ? ");
            car1.takeSpeed(Convert.ToInt32(Console.ReadLine()));
            //-------------------------------------------------------
            //2.4
            Console.WriteLine($"{PrintCar(car1)}");
            //-------------------------------------------------------
            //2.5
            car1.minusSpeed(2);
            //-------------------------------------------------------
            //2.6
            Console.WriteLine($"{PrintCar(car1)}");
            //-------------------------------------------------------
            //2.7
            car1.stopCar();
            Console.WriteLine($"{PrintCar(car1)}");

            //-------------------------------------------------------
        }
        //-----------------------------------------------------------
        //2.4
        public static String PrintDetails(Cookie c)
        {
            String res = "details of cookie :";
            res += $" gluten : { c.Gluten }\n";
            res += $" eggs : { c.Eggs }\n";
            res += $" gluten : { c.QuantityOfFlour }\n";
            res += $" gluten : { c.QuantityOfSugar }\n";
            return res;
        }
        public static String PrintCar(Car a)
        {
            String Details = "details of the Car :\n";
            Details += $"car name: { a.CarName }\n";
            Details += $"his currnet speed is: { a.CurrentSpeed }\n";
            return Details;
        }

    }

}
