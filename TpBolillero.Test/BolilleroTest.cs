using System;
using System.Collections.Generic;
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
            var bolilla = Bolillero.SacarBolilla();
            var cantidadAdentro = Bolillero.Adentro.Count;
            var cantidadAfuera = Bolillero.Afuera.Count;
            Assert.Equal(0, bolilla);
            Assert.Equal(9, cantidadAdentro);
            Assert.Equal(1, cantidadAfuera);
        }
        [Fact]
        public void ReIngresar()
        {
            Bolillero.SacarBolilla();
            Bolillero.ReIngresar();
            var cantidadAdentro = Bolillero.Adentro.Count;
            var cantidadAfuera = Bolillero.Afuera.Count;
            Assert.Equal(10, cantidadAdentro);
            Assert.Equal(0, cantidadAfuera);
        }
        [Fact]
        public void JugarGana()
        {
            List<byte> numeros = new List<byte> { 0, 1, 2, 3 };
            Assert.True(Bolillero.Jugar(numeros));
        }

        [Fact]
        public void JugarNVeces()
        {
            List<byte> numeros = new List<byte> { 0, 1 };
            var jugadoNveces = Bolillero.JugarN(numeros, 1);
            Assert.Equal(1, jugadoNveces);
        }
    }
}
