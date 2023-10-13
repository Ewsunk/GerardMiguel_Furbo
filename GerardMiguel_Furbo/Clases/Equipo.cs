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

        //Getters y Setters
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public List<Jugador> JugadoresLista { get { return jugadoresLista; } set { jugadoresLista = value; } }

        public void AddJugador(Jugador jugador) { jugadoresLista.Add(jugador); }
        public void QuitarJugador(Jugador jugador) { jugadoresLista.Remove(jugador); }

        public override string ToString() { return "Equipo " + this.nombre; }
        
        public void CrearJugador(bool primeraVez)
        {
            if (primeraVez) Console.Write("Introduce el nombre del primer jugador del equipo: ");
            else Console.Write("Introduce el nombre del jugador: ");

            var nombre = Console.ReadLine();

            if (nombre.Equals("") || nombre == null)
            {
                Console.WriteLine("Nombre erróneo!");
                return;
            }

            int dorsal;

            Console.Write("Introduce la dorsal del jugador: ");
            var resultado = int.TryParse(Console.ReadLine(), out dorsal);

            if (!resultado || dorsal < 0)
            {
                Console.WriteLine("Dorsal errónea!");
                return;
            }

            Jugador nuevoJugador = new Jugador(nombre, dorsal);
            jugadoresLista.Add(nuevoJugador);
        }
    }
}
