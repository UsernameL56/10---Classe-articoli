using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe1
{
    public class ArticoloAlimentare : Articolo
    {
        // attributi
        protected int _annoScadenza;

        //metodi accessor
        static int AnnoScadenza
        {
            get { return AnnoScadenza; }
            set { AnnoScadenza = value; }
        }

        //costruttore
        public ArticoloAlimentare(int _codice, string _descrizione, double _prezzoUnitario, int _annoScadenza) : base(_codice, _descrizione, _prezzoUnitario) 
        {
            AnnoScadenza = _annoScadenza;
        }

        //metodi
        public override void Sconta(bool cartaFedelta)
        {
            double sconto;
            base.Sconta(cartaFedelta);

            if(AnnoScadenza == DateTime.Now.Year)
            {
                sconto = (PrezzoUnitario * 20) / 100;
                PrezzoUnitario -= sconto;
            }

        }
    }
}
