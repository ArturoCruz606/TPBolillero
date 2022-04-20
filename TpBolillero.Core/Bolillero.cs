using System.Collections.Generic;
namespace TpBolillero.Core
{
    public class Bolillero
    {
        public List<byte> Adentro { get; set; }
        public List<byte> Afuera { get; set; }
        public Iazar Azar { get; set; }
        public Bolillero(){
            Adentro = new List<byte>();
            Afuera = new List<byte>();
        }
        private void CrearBolillas(byte cantidadbolillas){
                for (byte i = 0; i < cantidadbolillas ; i++)
            {
                    Adentro.Add(i);
            }
        }
        public Bolillero(byte cantidadbolillas) : this() => CrearBolillas(cantidadbolillas);
        public byte SacarBolilla(){
            var a = Azar.SacarBolilla(Adentro);
            Afuera.Add(a);
            Adentro.Remove(a);
            return a;
        }
        public void ReIngresar(){
            Adentro.AddRange(Afuera);
            Afuera.Clear();
        }
        public bool Jugar(List<byte> numeros){
            for (int i = 0; i < numeros.Count; i++)
            {
                if(SacarBolilla() != numeros[i])
                    return false;
            }
            return true;
        }
        public long JugarN(List<byte> numeros, long cantidad){
            long contador = 0;
            for (int i = 0; i < cantidad; i++)
            {
                if(Jugar(numeros))
                    contador++;

                ReIngresar();
            }
            return contador;
        }
    }
}