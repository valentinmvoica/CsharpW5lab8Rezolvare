using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpW5lab9
{
    class VagonClasa1 : VagonPersoane
    {
        public VagonClasa1(int nrPersoane, int anFabricatie) //,3500
            :base(nrPersoane,anFabricatie)
        {
            base.masa = 3500;
        }
        public void PornesteAc()
        {
            Console.WriteLine("AC-ul porneste");
        }
        public void OpresteAc()
        {
            Console.WriteLine("AC-ul opreste");
        }
    }
}
