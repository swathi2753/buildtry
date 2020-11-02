using System;

namespace basiceg
{
    class Helloworld 
    {
        static void  Main() 

            {

            Console.WriteLine("------------------");
            // print your Name
            string myname = "Swathi", Surname = "Sha";

            Console.WriteLine(myname);

            // Concatenation
            //printf("Myname:%c",myname)
            Console.WriteLine("Concatenation");
            Console.WriteLine("MyName:" + myname);
            Console.WriteLine("------------------");
            //Placeholder
            Console.WriteLine("Placeholder");
            Console.WriteLine("MyName:{0}", myname);
            Console.WriteLine("MyName:{0} || Surname:{1}", myname, Surname);

            //to read from console window
            Console.Read();
        }
    }
}