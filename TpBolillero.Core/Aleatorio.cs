using System;
using System.Collections.Generic;

namespace TpBolillero.Core
{
    public class Aleatorio : Iazar
    {
        private Random Random { get; set; }
        public Aleatorio()
        {
            Random = new Random();
        }
        public byte SacarBolilla(List<byte> bolillas)
        {
            var a = bolillas.Count;
            var b = Random.Next(0,a);
            return Convert.ToByte(bolillas[b]);
        }

    }
}
