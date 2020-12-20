using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dischi
{
    class Disco
    {
        private string titolo;
        private string cantante;
        private int codice;
        private bool prestato;

        public Scaffale s { get; set; }
        public List<Brano> B { get; set; }

        public Disco(string titolo,string cantante)
        {
            this.titolo = titolo;
            this.cantante = cantante;
        }

        public bool IsPrestato()
        {
            bool b = false;
            return b;

        }
        public void SetPrestato(bool b)
        {
            string r;
            Console.WriteLine("Vuoi prestare il disco?\n(Si/No");
            r = Console.ReadLine();
            if(r == "Si")
            {
                b = true;
            }
            else if(r == "No")
            {
                b = false;
            
            }else if(r != "No" || r !=  "Si")
            {
                Console.WriteLine("risposta errata");
            }
            
        }
        public string GetTitolo()
        {
            return titolo;
        }
       



    }

}
