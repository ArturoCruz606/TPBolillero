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
            Simulacion simulacion = new Simulacion();
            List<byte> lista = new List<byte>{1};
            DateTime();
            simulacion.SimularSinHilos(bolillero,lista, 300000);
        }
    }
}