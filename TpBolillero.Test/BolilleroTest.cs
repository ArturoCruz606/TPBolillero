using System;
using TpBolillero.Core;
using Xunit;

namespace TpBolillero.Test
{
    public class BolilleroTest
    {
        public Bolillero Bolillero { get; set; }
        public BolilleroTest()
        {
            Bolillero = new Bolillero(10);
            Bolillero.Azar = new Primera();
        }

        [Fact]
        public void SacarBolilla()
        {
            Bolillero.SacarBolilla();
            // Assert.Equal()
        }
    }
}
