using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerardMiguel_Furbo
{
    internal class Controler
    {
        private static List<String> clubes;     // Cambiar a objeto club
        private static int clubSeleccionado;

        public static void Start()
        {
            clubes = new List<String>();        // Cambiar a objeto club
            clubSeleccionado = 0;

            Menu();
        }

        private static void Menu()
        {
            int eleccion;

            newClub();

            do
            {

                Console.WriteLine("1- Crear club");
                Console.WriteLine("2- Seleccionar club");
                Console.WriteLine("3- Crear equipo");
                Console.WriteLine("4- Crear jugador");
                Console.WriteLine("5- Ver equipo");
                Console.WriteLine("6- Ver Jugadores");

                eleccion = Convert.ToInt32(System.Console.ReadLine());

                switch(eleccion)
                {
                    case 1:
                        NewClub();
                        break;

                    case 2:
                        SelectClub();
                        break;
                }


            } while (eleccion != 0);
        }

        private static void NewClub()
        {

        }

        private static void SelectClub()
        {
            foreach (var club in clubes)
            {

            }
        }

    }
}
