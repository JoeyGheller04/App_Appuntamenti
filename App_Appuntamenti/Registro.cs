using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Appuntamenti
{
    class Registro
    {
        public Registro()
        {
            Lista = new List<Persona>();
        }

        public List<Persona> Lista { get; }

        public void Add(Persona ToAdd)
        {
            Lista.Add(ToAdd);
        }


        public string FindId(string ID)
        {
            foreach(Persona Element in Lista)
            {
                if(Element.ID == ID)
                {
                    return Element.Cognome + " " + Element.Nome;
                }
            }

            return "";
        }
    }
}
