using System.Collections.Generic;
namespace TpBolillero.Core
{
    public class Bolillero
    {
        public List<byte> Adentro { get; set; }
        public List<byte> Afuera { get; set; }
        private Iazar azar { get; set; }
        public Bolillero(){
            Adentro = new List<byte>();
            Afuera = new List<byte>();
        }
        private void CrearBollillas(byte cantidadbolillas){
                Adentro.Add(cantidadbolillas);
        }
        public Bolillero(byte cantidadbolillas){
                for (int i = 0; i < cantidadbolillas - 1; i++)
            {
                    CrearBollillas(cantidadbolillas);
            }
        }
        public byte SacarBolilla(){
            var a = azar.SacarBolilla(Adentro);
            Afuera.Add(a);
            return a;
        }
        public void ReIngresar(){
            Adentro.AddRange(Afuera);
            Afuera.Clear();
        }
    }
}