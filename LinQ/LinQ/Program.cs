using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var autod = new List<Auto>()
            {
                new Auto(){Tootja = "Mercedes-Benz    ", Mudel = "GLK 220         ", KW = 125, Värv = "Must met."},
                new Auto(){Tootja = "Volvo            ", Mudel = "XC60            ", KW = 169, Värv = "Pruun met."},
                new Auto(){Tootja = "Mazda            ", Mudel = "6               ", KW = 114, Värv = "Must"},
                new Auto(){Tootja = "McLaren          ", Mudel = "570S            ", KW = 419, Värv = "Oranž"},
                new Auto(){Tootja = "Mercedes-Benz    ", Mudel = "E               ", KW = 190, Värv = "Must met."},
                new Auto(){Tootja = "Volkswagen       ", Mudel = "Passat Highline ", KW = 130, Värv = "Kuldne met."},
                new Auto(){Tootja = "BMW              ", Mudel = "760 Li          ", KW = 448, Värv = "Pruun met."},
                new Auto(){Tootja = "Dodge Challenger ", Mudel = "srt8            ", KW = 351, Värv = "Must"},
                new Auto(){Tootja = "Porsche          ", Mudel = "911             ", KW = 353, Värv = "Must"},
                new Auto(){Tootja = "BMW              ", Mudel = "X6              ", KW = 300, Värv = "Must met."}
            };

            var kW = (from auto in autod orderby auto.KW descending select auto).ToList();
            Console.WriteLine("Autode võimsusjärjekord on: ");
            foreach (var auto in kW)
            {
                Console.WriteLine(auto.Tootja + auto.Mudel + auto.KW + " kW " + auto.Värv);
            }

            var O = autod.Where(x => x.Tootja.Contains("o")).ToList();
            Console.WriteLine("\nAutod mille tootjanimes on 'o' täht: ");
            foreach (var auto in O)
            {
                Console.WriteLine(auto.Tootja + auto.Mudel + auto.KW + " kW " + auto.Värv);
            }

            var E = autod.Where(x => x.Tootja.Contains("e")).ToList();
            Console.WriteLine("\nAutod mille tootjanimes on 'e' täht: ");
            foreach (var auto in E)
            {
                Console.WriteLine(auto.Tootja + auto.Mudel + auto.KW + " kW " + auto.Värv);
            }

            var neli = autod.Where(x => x.Tootja.Length > 4).ToList();
            Console.WriteLine("\nAutod mille tootjanimi on pikem kui 4 tähte: ");
            foreach (var auto in neli)
            {
                Console.WriteLine(auto.Tootja + auto.Mudel + auto.KW + " kW " + auto.Värv);
            }
            // Kõige tugevam ja nõrgem
            Console.WriteLine("\nKõige tugevam auto on: ");
            var tugevaim = autod.OrderByDescending(x => x.KW).First();
            Console.WriteLine(tugevaim.Tootja + tugevaim.Mudel + tugevaim.KW + " kW " + tugevaim.Värv);
            Console.WriteLine("\nKõige nõrgeim auto on: ");
            var nõrgim = autod.OrderByDescending(x => x.KW).Last();
            Console.WriteLine(nõrgim.Tootja + nõrgim.Mudel + nõrgim.KW + " kW " + nõrgim.Värv);
        }
    }
}
