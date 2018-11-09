using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            Interface1 k = new Konyv("Harry Potter ", "J K Rowlings", "123344");

            Interface1 d = new Dvd("Star Wars IV " , 210);

            var katalogus = new List<Interface1>();
            

            katalogus.Add(new Konyv("Harry Potter","J K Rowlings", "1234555"));
            katalogus.Add(new Dvd("Star Wars IV", 210));
            katalogus.Add(new Ujsag("Kiskegyed", 2018, 11));

            Console.WriteLine(katalogus[0].MegjelenitendoNev());
            Console.WriteLine(katalogus[1].MegjelenitendoNev());

            Console.ReadLine();
        }
    }
}
