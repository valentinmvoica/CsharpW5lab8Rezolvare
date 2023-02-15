using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpW5lab9
{
    class Tren
    {
        private readonly string nume;
        private Locomotiva locomotiva;
        private List<Vagon> vagoane = new List<Vagon>();
        public Tren(string nume, Locomotiva locomotiva)
        {
            this.nume = nume;
            this.locomotiva = locomotiva;
        }
        public int NrLocuri {
            get {
                int nrLocuri = 0;
                foreach (Vagon vagon in vagoane)
                {
                    if (vagon is VagonPersoane)
                    {
                        nrLocuri += (vagon as VagonPersoane).NrPersoane;
                    }
                }

                return nrLocuri;
            }
        }
        public void AdaugaVagon(Vagon vagon)
        {
            vagoane.Add(vagon);

        }
        public List<Incarcatura> GetSumarMarfa() {
            List<Incarcatura> rezultat = new List<Incarcatura>();

            foreach (Vagon vagon in vagoane) {
                if (!(vagon is VagonMarfa))
                {
                    continue;
                }

                VagonMarfa deMarfa = vagon as VagonMarfa;

                Incarcatura incarcatura = null;
                foreach(Incarcatura incarcaturaExistenta in rezultat)
                {
                    if (incarcaturaExistenta.TipMarfa == deMarfa.TipMarfa)
                    {
                        incarcatura = incarcaturaExistenta;
                        break;
                    }
                }

                if (incarcatura != null)
                {
                    incarcatura.Cantitate += deMarfa.Cantitatea;
                }
                else
                {
                    incarcatura = new Incarcatura(deMarfa.TipMarfa);
                    incarcatura.Cantitate = deMarfa.Cantitatea;

                    rezultat.Add(incarcatura);
                }
            }

            return rezultat;
        }


        /*{
            tipincarcatura
            cantitate
        }*/

        //Carbuni, 50
        //Otel , 500
        //Persoane, 12

        public void PornesteDinGara()
        {
            //La aceasta comanda, trenul va inchide usile vagoanelor de persoane si va porni aerul conditionat in vagoanele clasa 1
            foreach(Vagon vagon in vagoane)
            {
                if ( vagon is VagonClasa1)
                {
                    VagonClasa1 vagonClasa1 = vagon as VagonClasa1;
                    vagonClasa1.InchideUsile();
                    vagonClasa1.PornesteAc();

                }
                else if (vagon is VagonPersoane)
                {
                    VagonPersoane vagonDePersoane = vagon as VagonPersoane;
                    vagonDePersoane.InchideUsile();
                }
            }
            locomotiva.Porneste();
        }
        public void OpresteInGara()
        {
            //La  aceasta comanda, trenul va opri locomotiva , 
            locomotiva.Opreste();
            foreach (Vagon vagon in vagoane)
            {
                if (vagon is VagonClasa1)
                {
                    VagonClasa1 vagonClasa1 = vagon as VagonClasa1;
                    vagonClasa1.OpresteAc();
                    vagonClasa1.DeschideUsile();

                }
                else if (vagon is VagonPersoane)
                {
                    VagonPersoane vagonDePersoane = vagon as VagonPersoane;
                    vagonDePersoane.DeschideUsile();
                }
            }
            //va deschide usile vagoanelor de persoane si va opri aerul conditionat in vagoanele clasa 1
        }

    }
}
