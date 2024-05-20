using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_5
{
    public class TelefonoInteligente : Telefono
    {
        public string SistemaOperativo { get; set; }
        public string MemoriaRam {  get; set; } // En GB


        public void MostrarInformacionInteligente()
        {
            MostrarInformacion();
            Console.WriteLine($"Sistema Operativo: {SistemaOperativo}, Memoria Ram: {MemoriaRam} GB");
        }
    }
}
