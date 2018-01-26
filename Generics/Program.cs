using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            TelefonniSeznam telefonniSeznam = new TelefonniSeznam();
            telefonniSeznam.AddStudent(new Student { TelCislo = "0905363636", Jmeno = "Pavel", rc = "854471" });
            telefonniSeznam.AddStudent(new Student { TelCislo = "+459870021", Jmeno = "Honza", rc = "887452" });
            telefonniSeznam.AddStudent(new Student { TelCislo = "+459870021", Jmeno = "Petr", rc = "025687/7" });

            Student student = new Student();
            if (telefonniSeznam.Find("78dd9654", out student))
            {
                Console.WriteLine(student.Jmeno);
                Console.WriteLine(student.TelCislo);

            }

            else
            {
                Console.WriteLine("zaznam nie je");
            }

            GenericSmallStack<string> test = new GenericSmallStack<string>();

               test.Pop();

            //test.Push("prvy");
            //test.Push("druhy");
            //test.Push("treti");


            

            Console.ReadKey();
        }
    }
}
