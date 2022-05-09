using System.Collections.Generic;
using System.Threading.Tasks;

namespace TpBolillero.Core
{
    public class Simulacion
    {
        public int SimularSinHilos(Bolillero bolillero, List<byte> jugada, int cantidadSimulaciones)
        {
            int contador = 0;
            for (int i = 0; i < cantidadSimulaciones; i++)
            {
                if(bolillero.Jugar(jugada))
                    contador++;

                bolillero.ReIngresar();
            }
            return contador;
        }
        public int SimularConHilos(Bolillero bolillero, List<byte> jugada, int cantidadSimulaciones, int cantidaddehilos)
        {
            for (int i = 0; i < cantidaddehilos; i++)
            {
            bolillero.Clone();
            Task tarea = new Task(() => SimularSinHilos(bolillero,jugada,cantidadSimulaciones));
            }
        }
    }
}