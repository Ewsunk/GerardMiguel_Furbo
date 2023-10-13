using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerardMiguel_Furbo.Clases
{
    

    internal class Jugador
    {
        private string nombre;
        private int dorsal;


        public Jugador() { }

        public Jugador(string nombre, int dorsal)
        {
            this.nombre = nombre;
            this.dorsal = dorsal;
        }


        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Dorsal { get {  return dorsal; } set { dorsal = value; } }


        public override string ToString()
        {
            return "Jugador: " + this.nombre + " dorsal: ";
        }
    }
}
