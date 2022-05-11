using System;
using System.Collections.Generic;
using TpBolillero.Core;

namespace TpBolillero.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Bolillero bolillero = new Bolillero(10);
            bolillero.Azar = new Aleatorio();
            Simulacion simulacion = new Simulacion();
            List<byte> lista = new List<byte>{1};
            var inicio = DateTime.Now;
            Console.WriteLine($"Simulando sin hilos{inicio}");
            System.Console.WriteLine(simulacion.SimularSinHilos(bolillero,lista, 300000)); 
            var fin = DateTime.Now;
            Console.WriteLine(fin);
            Console.WriteLine("Simulando con hilos");
            simulacion.SimularConHilos(bolillero, lista, 300000, 6);
        }
    }
}