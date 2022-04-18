using System;
using System.Collections.Generic;
namespace TpBolillero.Core
{
    public class Primera: Iazar
    {
        public byte SacarBolilla(List<byte> bolillas)
        {
            return Convert.ToByte(bolillas [0]);
        }
    }
}