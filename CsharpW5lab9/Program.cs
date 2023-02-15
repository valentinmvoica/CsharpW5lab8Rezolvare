using System;
using System.Collections.Generic;

namespace CsharpW5lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Locomotiva lc = new Locomotiva();
            Tren tren = new Tren("ACC Foamea", lc);
            tren.AdaugaVagon(new VagonPersoane(200, 2022));
            tren.AdaugaVagon(new VagonClasa1(150, 1990));
            tren.AdaugaVagon(new VagonPersoane(70, 2023));

            tren.AdaugaVagon(new VagonMarfa(1990, TipMarfa.Carbuni,100));
            tren.AdaugaVagon(new VagonMarfa(1990, TipMarfa.Otel, 300));
            tren.AdaugaVagon(new VagonMarfa(1990, TipMarfa.Carbuni, 90));
            tren.AdaugaVagon(new VagonMarfa(1990, TipMarfa.Cereale, 70));


            tren.PornesteDinGara();
            Console.WriteLine("");
            tren.OpresteInGara();
            Console.WriteLine("");
            Console.WriteLine($"Nr total de locuri {tren.NrLocuri}");
            Console.WriteLine("");
            List<Incarcatura> sumarMarfa = tren.GetSumarMarfa();

            foreach(Incarcatura incarcatura in sumarMarfa)
            {
                Console.WriteLine($"{incarcatura.TipMarfa}  -  {incarcatura.Cantitate}");
            }
        }
    }
}
