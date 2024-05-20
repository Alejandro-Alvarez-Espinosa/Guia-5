namespace Guia_5
{
    public class program
    {
        static void Main(string[] args)
        {

            TelefonoInteligente TInteligente = new TelefonoInteligente();

            TInteligente.Marca = "Tecno";
            TInteligente.Modelo = "Pova 6 Pro";
            TInteligente.Precio = 269;
            TInteligente.SistemaOperativo = "Android 14";
            TInteligente.MemoriaRam = "Ocho";

            TelefonoBasico TBasico = new TelefonoBasico();

            TBasico.Marca = "Nokia";
            TBasico.Modelo = "3310";
            TBasico.Precio = 59;
            TBasico.TieneRadioFM = true;
            TBasico.TieneLinterna = true;

            
            Console.WriteLine("\n-------Teléfono Inteligente-------");
            TInteligente.MostrarInformacionInteligente();

            Console.WriteLine("\n-------Teléfono Básico-------");
            TBasico.MostrarInformacionBasico();
        }
    }
}
