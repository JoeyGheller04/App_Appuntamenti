using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Appuntamenti
{
    class Patologia
    {
        public string ID { get; }
        public string Nome { get; }

        public Patologia(string iD, string nome)
        {
            ID = iD;
            Nome = nome;
        }
    }
}
