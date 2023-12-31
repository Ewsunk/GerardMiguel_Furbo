﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerardMiguel_Furbo.Clases
{
    public class Club
    {
        private string nombre;
        private List<Equipo> equiposLista;


        public Club(string nombre) 
        {
            this.nombre = nombre;
            equiposLista = new List<Equipo>();
        }


        //Getters y Setters
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public List<Equipo> EquiposLista { get { return equiposLista; } set { equiposLista = value; } }

        public void AddEquipo(Equipo equipo) { equiposLista.Add(equipo); }
        public void QuitarEquipo(Equipo equipo) { equiposLista.Remove(equipo); }

        public void CrearEquipo(bool primeraVez)
        {
            if (primeraVez) Console.Write("Introduce el nombre del primer equipo del club: ");
            else Console.Write("Introduce el nombre del equipo: ");

            var nombre = Console.ReadLine();

            if (nombre.Equals("") || nombre == null)
            {
                Console.WriteLine("Nombre erróneo!");
                return;
            }

            Equipo nuevoEquipo = new Equipo(nombre);
            equiposLista.Add(nuevoEquipo);
            nuevoEquipo.CrearJugador(true);
        }

        public override string ToString() { return "Club " + this.nombre; }


        public Equipo SeleccionarEquipo()
        {
            Console.WriteLine("\n\n");

            Console.WriteLine("==== Lista de Equipos ====");

            foreach (Equipo equipo in equiposLista)
                Console.WriteLine(equipo.ToString());

            Console.WriteLine("\n\n");

            Console.Write("Introduce el nombre del equipo: ");
            string equipoNombre = Console.ReadLine();

            Equipo equipoSeleccionado = equiposLista.Find(equipo => equipo.ToString().Equals(equipoNombre));
            return equipoSeleccionado;
        }
    }
}
