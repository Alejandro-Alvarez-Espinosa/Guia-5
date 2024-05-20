using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_5
{
    public class TelefonoBasico : Telefono
    {
        public bool TieneRadioFM {  get; set; }
        public bool TieneLinterna { get; set; }


        public void MostrarInformacionBasico()
        {
            MostrarInformacion();
            Console.WriteLine("Tiene Radio FM: {0}", TieneRadioFM ? "Sí" : "No");
            Console.WriteLine("Tiene Linterna: {0}", TieneLinterna ? "Sí" : "No");
        }
    }
}
