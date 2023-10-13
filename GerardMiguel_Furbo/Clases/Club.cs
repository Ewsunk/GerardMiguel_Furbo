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
    }
}
