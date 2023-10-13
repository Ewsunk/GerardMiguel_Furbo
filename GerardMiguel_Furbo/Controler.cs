using GerardMiguel_Furbo.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerardMiguel_Furbo
{
    internal class Controler
    {
        private static List<Club> clubes;
        private static int clubSeleccionado;
        private static List<Partido> partidosLista;

        public static void Start()
        {
            clubes = new List<Club>();
            clubSeleccionado = 0;

            NewClub();
            Menu();
        }

        public List<Partido> PartidosLista { get { return partidosLista; } set { partidosLista = value; } }

        private static void Menu()
        {
            int eleccion;

            do
            {
                Console.WriteLine("1- Crear club");
                Console.WriteLine("2- Seleccionar club");
                Console.WriteLine("3- Crear equipo");
                Console.WriteLine("4- Crear jugador");
                Console.WriteLine("5- Ver lista de clubs, equipos y jugadores");
                Console.WriteLine("6- Organizar partido");
                Console.WriteLine("7- Ver resultados de partidos");

                Console.Write("Seleccion: ");
                int.TryParse(Console.ReadLine(), out eleccion);

                switch (eleccion)
                {
                    case 1:
                        NewClub();
                        break;

                    case 2:
                        SelectClub();
                        break;

                    case 3:
                        clubes[clubSeleccionado].CrearEquipo(false);
                        break;

                    case 4:
                        CrearJugador();
                        break;

                    case 5:
                        ListAll();
                        break;

                    case 6:
                        JugarPartido();
                        break;

                    case 7:
                        MostrarVictorias();
                        break;

                    default: 
                        Console.WriteLine("Opcion no valida");
                        break;
                }

                Console.WriteLine();
            } while (eleccion != 0);
        }


        private static void MostrarVictorias()
        {
            foreach (Partido partido in partidosLista)
                partido.ToString();
        }

        private static void CrearJugador()
        {
            Equipo equipo = clubes[clubSeleccionado].SeleccionarEquipo();

            if (equipo == null)
                Console.WriteLine("Nombre de equipo incorrecto!");
            else
                equipo.CrearJugador(false);
        }


        private static void NewClub()           // Crear club
        {
            Console.Write("Introduce el nombre del club: ");
            var nombre = Console.ReadLine();

            if (nombre.Equals("") || nombre == null)
            {
                Console.WriteLine("Nombre erróneo!");
                return;
            }

            Club nuevoClub = new Club(nombre);
            clubes.Add(nuevoClub);
            nuevoClub.CrearEquipo(true);
        }

        private static void SelectClub()        // Selecciona el club que quieras de la lista
        {
            int i = 0;

            foreach (Club club in clubes)
            {
                Console.WriteLine(i + " - " + club.Nombre);
                i++;
            }

            clubSeleccionado = Convert.ToInt32(System.Console.ReadLine());
        }

        private static void ListAll()
        {
            foreach (Club club in clubes)
            {
                Console.WriteLine("- " + club.ToString());

                foreach (Equipo equipo in club.EquiposLista)
                {
                    Console.WriteLine("-- " + equipo.ToString());

                    foreach (Jugador jugador in equipo.JugadoresLista)
                    {
                        Console.WriteLine("--- " +  jugador.ToString());
                    }
                }
            }
        }

        private static void JugarPartido()
        {
            Equipo equipo1 = null, equipo2 = null;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Club actual: " + clubes[clubSeleccionado].Nombre +
                "\nCambiar de club?" +
                "\n0- No" +
                "\n1- Si");

                if (Convert.ToInt32(Console.ReadLine()) == 1)
                    SelectClub();

                if (i == 0)
                    equipo1 = clubes[clubSeleccionado].SeleccionarEquipo();
                else
                    equipo2 = clubes[clubSeleccionado].SeleccionarEquipo();
            }

            Partido partido = new Partido(equipo1, equipo2);

            Equipo equipoGanador = partido.JugarPartido();

            Console.WriteLine("Ha ganado: " + equipoGanador.ToString());
        }

        public Partido EncontrarPartidoGanado(Equipo equipo)
        {
            return partidosLista.Find(partido => partido.EquipoGanador == equipo);
        }


    }
}
