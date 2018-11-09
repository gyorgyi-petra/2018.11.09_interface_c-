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

            Dvd d = new Dvd("Star Wars IV " , 210);
            Dvd d2 = new Dvd("Star Wars V ", 200);
            Dvd d3 = new Dvd("Star Wars III ", 180);

            var katalogus = new List<Interface1>() ; 
            

            katalogus.Add(d);
            katalogus.Add(d2);
            katalogus.Add(d3);
            katalogus.Add(new Dvd("Star Wars IV", 210));
            katalogus.Add(new Ujsag("Kiskegyed", 2018, 11));

            Console.WriteLine(katalogus[0].MegjelenitendoNev());
            Console.WriteLine(katalogus[1].MegjelenitendoNev());

            d3.Cim = "Star Wars II";

        
           

            var dvdk = new List<Dvd>();
            dvdk.Add(d);
            dvdk.Add(d2);
            dvdk.Add(d3);
            Console.WriteLine(dvdk[0].FutasIdoOra());


            dvdk.Sort();
            foreach (var e in dvdk)
            {
                Console.WriteLine(e.MegjelenitendoNev() + " ", e.FutasIdoOra());
            }

           

            Console.ReadLine();
        }
    }
}
