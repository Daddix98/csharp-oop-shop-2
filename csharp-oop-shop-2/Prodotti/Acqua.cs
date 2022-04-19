using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2.Prodotti
{
    internal class Acqua : Prodotto
    {
        private double litri;
        private double ph;
        private string sorgente;
        private const double MAX_LITRI = 1;

        public Acqua(string nomeProdotto, string descrizione, double prezzo, double iva, double litri, double ph, string sorgente)
            : base(nomeProdotto, descrizione, prezzo, iva)
        {
            this.litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;
        }

        ///<summary>
        /// Questo metodo calcola la quantità di acqua rimanente.
        ///</summary>
        public void Bevi(double litriDaBere)
        {
            if (litriDaBere > litri)
            {
                Console.WriteLine("Stai bevendo come un cammello: " + litri + " Questi sono i litri massimi ");
            }
            else
            {
                litri -= litriDaBere; // -= significa sottrarre se stesso alla variabile litri da bere 
                Console.WriteLine(" Rimangono questi litri: " + litri + " Questi sono i litri rimanenti ");
            }
        }

        public void Riempi(double litriDaRiempire)
        {
            if(MAX_LITRI < litri)
            {
                Console.WriteLine("Hai superato il numero massimo: " + MAX_LITRI);
            }
            else
            {
                litri += litriDaRiempire;
                Console.WriteLine("La bottiglia ora ha questi litri: " + litri);

            }
        }

        public void Svuota()
        {
            litri = 0;

        }

        public override void StampaProdotto()
        {

            Console.WriteLine(GetNomeEsteso() + " " + ph + " " + sorgente);
        }


    }
}
