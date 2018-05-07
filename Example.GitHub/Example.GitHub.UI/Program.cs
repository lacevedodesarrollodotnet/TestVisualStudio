using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.GitHub.Bussiness;

namespace Example.GitHub.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo desde Git-hub");

            var employee = new Employee();
            employee.Name = "Luis";
            employee.LastName = "Acevedo";
            employee.Age = "28 age";
            Console.WriteLine("Employe> {0} {1} {2}", employee.Name, employee.LastName, employee.Age);
            Console.ReadLine();
        }
    }
}
