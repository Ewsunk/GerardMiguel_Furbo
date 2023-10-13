using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerardMiguel_Furbo.Clases
{
    public class Partido
    {
        private Equipo equipoA;
        private Equipo equipoB;
        private Equipo equipoGanador;

        public Partido(Equipo equipoA, Equipo equipoB) 
        {
            this.equipoA = equipoA;
            this.equipoB = equipoB;
        }


        public Equipo JugarPartido()
        {
            var rand = new Random();
            var numero = rand.Next(2);

            switch (numero)
            {
                case 0:
                    equipoGanador = null;
                    break;

                case 1:
                    equipoGanador = equipoA;
                    break;

                case 2:
                    equipoGanador = equipoB;
                    break;
            }

            return equipoGanador;
        }

    }
}
