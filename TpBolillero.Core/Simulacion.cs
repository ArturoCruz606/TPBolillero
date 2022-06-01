using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace TpBolillero.Core
{
    public class Simulacion
    {
        public long SimularSinHilos(Bolillero bolillero, List<byte> jugada, int cantidadSimulaciones)
        {
            return bolillero.JugarN(jugada, cantidadSimulaciones);
        }
        public long SimularConHilos(Bolillero bolillero, List<byte> jugada, int cantidadSimulaciones, int cantidaddehilos)
        {
            Task<long>[] tarea = new Task<long>[cantidaddehilos];
            for (int i = 0; i < cantidaddehilos; i++)
            {
                var clon = (Bolillero)bolillero.Clone();
                tarea[i] = Task<long>.Run(() => SimularSinHilos(clon, jugada, cantidadSimulaciones / cantidaddehilos));
            }
            Task<long>.WaitAll(tarea);
            return tarea.Sum(t => t.Result);
        }
        public async Task<long> SimularConHilosAsync(Bolillero bolillero, List<byte> jugada, int cantidadSimulaciones, int cantidaddehilos){
            Task<long>[] tarea = new Task<long>[cantidaddehilos];
            for (int i = 0; i < cantidaddehilos; i++)
            {
                var clon = (Bolillero)bolillero.Clone();
                tarea[i] = Task<long>.Run(() => SimularSinHilos(clon, jugada, cantidadSimulaciones / cantidaddehilos));
            }
            await Task<long>.WhenAll(tarea);
            return tarea.Sum(t => t.Result);
        }
    }
}