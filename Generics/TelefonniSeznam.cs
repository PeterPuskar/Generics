using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class TelefonniSeznam
    {
        Dictionary<string, Student> seznam = new Dictionary<string, Student>();

        public void AddStudent(Student student)
        {
            try
            {
                seznam.Add(student.TelCislo, student);
            }

            catch (System.ArgumentException exception)
            {
                Console.WriteLine("rovnake zadanie {0}", exception.ToString());
            }

            

         //  seznam.Add(student.TelCislo, student);
        }
        public bool Find(string telCislo, out Student student)
        {
            return seznam.TryGetValue(telCislo, out student);


        }    
    }
}
