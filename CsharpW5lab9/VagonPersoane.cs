using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpW5lab9
{
    class VagonPersoane : Vagon
    {
        private int nrPersoane;
        //3000
        public VagonPersoane(int nrPersoane, int anFabricatie)
            :base(anFabricatie) 
        {
            base.masa = 3000;
            this.nrPersoane = nrPersoane;
        }

        public void InchideUsile()
        {
            Console.WriteLine("Inchid usile");
        }
        public void DeschideUsile()
        {
            Console.WriteLine("Deschid usile");
        }

        public int NrPersoane { get { return this.nrPersoane; } }

    }
}
