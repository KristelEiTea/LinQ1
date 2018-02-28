using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Reference
    {       //Klassivenna töö, puudusin, õppisin

            //var autod = new List<Auto>()
            //{
            //    new Auto(){Tootja = "Audi", Mudel = "A8", KW = 142, Värv = "sinine" },
            //    new Auto(){Tootja = "Audi", Mudel = "A4", KW = 74, Värv = "punane" },
            //    new Auto(){Tootja = "BMW", Mudel = "3. seeria", KW = 73, Värv = "kollane" },
            //    new Auto(){Tootja = "BMW", Mudel = "7. seeria", KW = 175, Värv = "oranž" },
            //    new Auto(){Tootja = "Lexus", Mudel = "LS", KW = 161, Värv = "valge" },
            //    new Auto(){Tootja = "Lexus", Mudel = "IS", KW = 114, Värv = "beež" },
            //    new Auto(){Tootja = "Volkswagen", Mudel = "Transporter", KW = 70, Värv = "roosa" },
            //    new Auto(){Tootja = "Volkswagen", Mudel = "Passat", KW = 81, Värv = "roheline" },
            //    new Auto(){Tootja = "Porsche", Mudel = "Cayenne", KW = 150, Värv = "must" },
            //    new Auto(){Tootja = "Porsche", Mudel = "Macan", KW = 94, Värv = "lilla" }
            //};
            //// KW järjestus
            //var KW = (from auto in autod
            //      orderby auto.KW descending
            //      select auto).ToList();
            //Console.WriteLine("Autod KW järjestuses on: ");
            //foreach (var auto in KW)
            //{
            //    Console.WriteLine(auto.Tootja + " " + auto.Mudel + " " + auto.KW + "KW " + auto.Värv);
            //}
            //// O-täht
            //var O = autod.Where(x => x.Tootja.Contains("o")).ToList();
            //Console.WriteLine("\nAutod mille tootjanimes on \"o\" täht: ");
            //foreach (var auto in O)
            //{
            //    Console.WriteLine(auto.Tootja + " " + auto.Mudel + " " + auto.KW + "KW " + auto.Värv);
            //}
            //// E-täht
            //var E = autod.Where(x => x.Tootja.Contains("e")).ToList();
            //Console.WriteLine("\nAutod mille tootjanimes on \"e\" täht: ");
            //foreach (var auto in E)
            //{
            //    Console.WriteLine(auto.Tootja + " " + auto.Mudel + " " + auto.KW + "KW " + auto.Värv);
            //}
            //// Mudel 4+ tähte
            //var neli = autod.Where(x => x.Tootja.Length > 4).ToList();
            //Console.WriteLine("\nAutod mille tootjanimi on pikem kui 4 tähte");
            //foreach (var auto in neli)
            //{
            //    Console.WriteLine(auto.Tootja + " " + auto.Mudel + " " + auto.KW + "KW " + auto.Värv);
            //}
            //// Kõige tugevam ja nõrgem
            //Console.WriteLine("\nKõige tugevam auto on: ");
            //var tugevaim = autod.OrderByDescending(x => x.KW).First();
            // Console.WriteLine(tugevaim.Tootja + " " + tugevaim.Mudel + " " + tugevaim.KW + "KW " + tugevaim.Värv);
            //Console.WriteLine("\nKõige nõrgeim auto on: ");
            //var nõrgim = autod.OrderByDescending(x => x.KW).Last();
            //Console.WriteLine(nõrgim.Tootja + " " + nõrgim.Mudel + " " + nõrgim.KW + "KW " + nõrgim.Värv);
            //}
    }
}
