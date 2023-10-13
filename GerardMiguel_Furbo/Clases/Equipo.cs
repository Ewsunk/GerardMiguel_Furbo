using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerardMiguel_Furbo.Clases
{
    public class Equipo
    {
        private string nombre;
        private List<Jugador> jugadoresLista;

        public Equipo(string nombre) 
        {
            this.nombre = nombre;
            jugadoresLista = new List<Jugador>();
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }

        public void AddJugador(Jugador jugador)
        {

        }

        public void QuitarJugador(Jugador jugador)
        {

        }
    }
}
