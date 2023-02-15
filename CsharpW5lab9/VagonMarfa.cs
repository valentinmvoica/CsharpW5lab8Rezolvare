using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpW5lab9
{
    class VagonMarfa : Vagon
    {
        private TipMarfa tipMarfa;
        private int cantitatea;
        public VagonMarfa(int anFabricatie, TipMarfa tipMarfa, int cantitatea):base(anFabricatie)
        {
            base.masa = 10000;
            this.tipMarfa = tipMarfa;
            this.cantitatea = cantitatea;
        }

        public TipMarfa TipMarfa { get { return this.tipMarfa; } }
        public int Cantitatea { get { return this.cantitatea; } }

    }
}
