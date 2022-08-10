using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sdetCourse.Humano
{
    class AccionesPerros : Organos

{
        //Corazon
        public override string Bombear(int vecesxMinutos)
        {
            return $"Bombea {vecesxMinutos * 2}";
        }

        //Caminata
        public override string Pasos(int numpasos)
        {
            return $"Diste {numpasos + 100} pasos";
        }

        //Pulmon
        public override string inalaciones(int numInalaciones)
        {
            return $"Da {numInalaciones + 4} inalaciones por minuto";
        }

        //Estomago
        public override string digiere(int numgramos)
        {
            return $"Digiere {numgramos / 2} Gramos por comida";
        }

    }

}
