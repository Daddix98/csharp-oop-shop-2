using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    //----------- CLASSE PRODOTTO ---------------
    internal class Prodotto
    {
        //---------- DICHIARO LE VARIABILI --------------
        private int codiceProdotto;
        private string nomeProdotto;
        private string descrizione;
        private double prezzo;
        private double iva;
        
        //---------- COSTRUTTORE --------------
        public Prodotto(string nomeProdotto, string descrizione, double prezzo, double iva)
        {
            this.nomeProdotto = nomeProdotto;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }
        //-------------- METODO 1 CREAZIONE CODICE -------------
        public int GetGeneraCodiceProdotto()
        {
            Random random = new Random();
            int numero = random.Next(100);
            return numero;
        }
        //------------ METODO 2 CALCOLA PREZZO CON IVA ------------
        public double GetCalcolaPrezzoIva()
        {
            double prezzoConIva = prezzo * 1.22;
            return prezzoConIva;
        }
        //----------- METODO 3 STAMPA NOME ESTESO ----------
        public string GetNomeEsteso()
        {
            string nomePiuCodice = nomeProdotto + " " + GetGeneraCodiceProdotto();
            return nomePiuCodice;
        }
        //------------ METODO 4 STAMPA DATI ---------------
        public virtual void StampaProdotto()
        {
            Console.WriteLine("BENVENUTI NEL NOSTRO E-COMMERCE" + "\n");
            Console.WriteLine("------- I NOSTRI PRODOTTI -------");
            Console.WriteLine("Prodotto: " + GetNomeEsteso());
            Console.WriteLine("---------------------------------" + "\n");
            Console.WriteLine("-----------DESCRIZIONE-----------");
            Console.WriteLine(descrizione);
            Console.WriteLine("---------------------------------" + "\n");
            Console.WriteLine("-------------COSTI---------------");
            Console.WriteLine("Prezzo senza iva: " + prezzo);
            Console.WriteLine("Prezzo calcolato con iva: " + GetCalcolaPrezzoIva());
            Console.WriteLine(".................................");
            Console.WriteLine("\n" + "\n");
        }
    }
}
