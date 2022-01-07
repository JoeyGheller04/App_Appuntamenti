using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Appuntamenti
{
    class Appuntamento
    {
        public Appuntamento(DateTime data, string paziente, string medico)
        {
            Data = data;
            Paziente = paziente;
            Medico = medico;
        }

        public DateTime Data { get; }
        public string Paziente { get; }
        public string Medico { get; }

    }
}
