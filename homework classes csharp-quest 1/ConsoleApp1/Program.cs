using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;







namespace ConsoleApp1
{

    class Cookie
    {

        //-------------Properties--------------
        public int has_gluten=1;
        public int num_eggs;
        public int sugar_quantity;
        public int flour_quantity;


        public string get_gluten()
        {
            if (has_gluten == 0)
            {
                return "cookie is gluten free!";

            }
            else
            {
                return "cookie is not gluten free!";

            }
        }
        public string get_eggs()
        {
             return $"number of eggs in cookie is {num_eggs}";
        }
        public string get_sugar_quantity()
        {
            return $"cookie has {sugar_quantity} sugar in grams";
        }
        public string get_flour_quantity()
        {
            return $"cookie has {flour_quantity} flour in grams";
        }





        public string get_cookie_info()
        {
            if (has_gluten==0)
            {
                return $"has no gluten\neggs:{num_eggs}\nsugar:{sugar_quantity}\nflour:{flour_quantity}";
            }
            else
            {
                return $"has gluten\neggs:{num_eggs}\nsugar:{sugar_quantity}\nflour:{flour_quantity}";
            }
        }



    }

   













    class Program
    {
       


        static void Main(string[] args)
        {
            Cookie choclate = new Cookie();
            {
                Console.WriteLine("enter 1 if has gluten or 0 if no gluten in chocklate cookie ");
                choclate.has_gluten = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(choclate.get_gluten());
                Console.WriteLine("enter number of eggs in choclate cookie ");
                choclate.num_eggs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(choclate.get_eggs());
                Console.WriteLine("enter quantity in grams of sugar in choclate cookie ");
                choclate.sugar_quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(choclate.get_sugar_quantity());
                Console.WriteLine("enter quantity in grams of flour in choclate cookie ");
                choclate.flour_quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(choclate.get_flour_quantity());
            }
            
            Console.WriteLine("\n============next cookie:vanilla cookie=============\n");

            Cookie vanilla = new Cookie();
            {
                Console.WriteLine("enter 1 if has gluten or 0 if no gluten in vanilla cookie ");
                vanilla.has_gluten = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(vanilla.get_gluten());
                Console.WriteLine("enter number of eggs in vanilla cookie ");
                vanilla.num_eggs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(vanilla.get_eggs());
                Console.WriteLine("enter quantity in grams of sugar in vanilla cookie ");
                vanilla.sugar_quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(vanilla.get_sugar_quantity());
                Console.WriteLine("enter quantity in grams of flour in vanilla cookie ");
                vanilla.flour_quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(vanilla.get_flour_quantity());
            }
            


            Console.WriteLine("\n=========choclate cookie info:============");



            Console.WriteLine(choclate.get_cookie_info());
            Console.WriteLine("\n=========vanilla cookie info:============");

            Console.WriteLine(vanilla.get_cookie_info());

            choclate = vanilla;


            Console.WriteLine("\n=========choclate cookie info after change:============");



            Console.WriteLine(choclate.get_cookie_info());
            Console.WriteLine("\n=========vanilla cookie info after change:============");

            Console.WriteLine(vanilla.get_cookie_info());






        }
    }
}
