using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Appuntamenti
{
    public class Persona
    {
        public string ID { get; }
        public string Nome { get; }
        public string Cognome { get; }

        public Persona(string iD, string nome, string cognome)
        {
            ID = iD;
            Nome = nome;
            Cognome = cognome;
        }
    }
}
