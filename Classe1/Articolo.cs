using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Classe1
{

    public class Articolo
    {
        //attributi
        protected int _codice;
        protected string _descrizione;
        protected double _prezzoUnitario;

        //metodi accessor
        static int Codice
        {
            get { return Codice; }
            set { Codice = value; }
        }
        static string Descrizione
        {
            get { return Descrizione; }
            set { Descrizione = value; }
        }
        static double PrezzoUnitario
        {
            get { return PrezzoUnitario; }
            set { PrezzoUnitario = value; }
        }

        //costruttore
        public Articolo(int _codice, string _descrizione, int _prezzoUnitario)
        {
            Codice = _codice;
            Descrizione = _descrizione;
            PrezzoUnitario = _prezzoUnitario;
        }

        //metodi
        public virtual void Sconta(bool cartaFedelta)
        {
            double sconto;
            if (cartaFedelta)
            {
                sconto = (PrezzoUnitario * 5) / 100;
                PrezzoUnitario -= sconto;
            }
        }
    }
}
