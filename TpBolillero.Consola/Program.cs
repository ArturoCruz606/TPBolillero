using System;
using System.Diagnostics;
using System.Collections.Generic;
using TpBolillero.Core;
using System.Threading.Tasks;

namespace TpBolillero.Consola
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch cronometro = new Stopwatch();
            int repeticiones = 1000000000;
            Bolillero bolillero = new Bolillero(100);
            bolillero.Azar = new Aleatorio();
            Simulacion simulacion = new Simulacion();
            List<byte> lista = new List<byte>{1, 7, 15 , 2, 40, 72};
            
            cronometro.Start();
            Console.WriteLine($"Simulando sin hilos");
            System.Console.WriteLine(simulacion.SimularSinHilos(bolillero,lista, repeticiones)); 
            cronometro.Stop();
            TimeSpan tt = cronometro.Elapsed;
            string tiempotranscurrido = String.Format("{0:00}:{1:00}:{2:00}",
            tt.Hours, tt.Minutes, tt.Seconds);
            System.Console.WriteLine(tiempotranscurrido);
            
            cronometro.Reset();
            cronometro.Start();
            Console.WriteLine($"Simulando con hilos");
            System.Console.WriteLine(simulacion.SimularConHilos(bolillero, lista, repeticiones, 6));
            cronometro.Stop();
            tt = cronometro.Elapsed;
            tiempotranscurrido = String.Format("{0:00}:{1:00}:{2:00}",
            tt.Hours, tt.Minutes, tt.Seconds);
            System.Console.WriteLine(tiempotranscurrido);

            cronometro.Reset();
            cronometro.Start();
            Console.WriteLine($"Simulando con hilos Async");
            System.Console.WriteLine(await simulacion.SimularConHilosAsync(bolillero, lista, repeticiones, 6));
            cronometro.Stop();
            tt = cronometro.Elapsed;
            tiempotranscurrido = String.Format("{0:00}:{1:00}:{2:00}",
            tt.Hours, tt.Minutes, tt.Seconds);
            System.Console.WriteLine(tiempotranscurrido);

            cronometro.Reset();
            cronometro.Start();
            Console.WriteLine($"Simulando con hilos ParallelAsync");
            System.Console.WriteLine(await simulacion.SimularParallelAsync(bolillero, lista, repeticiones, 6));
            cronometro.Stop();
            tt = cronometro.Elapsed;
            tiempotranscurrido = String.Format("{0:00}:{1:00}:{2:00}",
            tt.Hours, tt.Minutes, tt.Seconds);
            System.Console.WriteLine(tiempotranscurrido);
        }
    }
}