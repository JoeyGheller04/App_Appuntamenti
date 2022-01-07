using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Appuntamenti
{
    class Specializzazione
    {
        public string ID { get; }
        public string Nome { get; }

        public Specializzazione(string iD, string nome)
        {
            ID = iD;
            Nome = nome;
        }
    }
}
