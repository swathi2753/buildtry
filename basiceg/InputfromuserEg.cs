using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiceg
{
    class InputfromuserEg
    {
        static void Main()


      {     
            string name, city;
        int age;
        Console.WriteLine("Enter Your name");
            name = Console.ReadLine();
           Console.WriteLine("Enter Your city");
            city = Console.ReadLine();
             Console.WriteLine("Enter Your age");
            age=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------");
            Console.WriteLine("Name:{0}|| City:{1} ||age:{2}", name,city,age);
            Console.Read();

            }





}
}
