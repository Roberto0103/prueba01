using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sdetCourse.Humano
{
    public class AccionesHumanos : Organos
    {
        internal void respirando()
        {
            Pulmon();
            Console.WriteLine("Respirando");
        }

        internal void palpitar()
        {
            corazon();
            Console.WriteLine("palpitando");
        }

        internal void digerir()
        {
            estomago();
            Console.WriteLine("digiriendo");
        }

        internal void caminar()
        {
            caminata();
            Console.WriteLine("caminar");
        }

        internal void pensar()
        {
            cerebro();
            Console.WriteLine("analizar");
        }



        //Corazon
        public override string Bombear(int vecesxSegundo)
        {
            return $"Bombea {vecesxSegundo}";
        }

        //Caminata
        public override string Pasos(int numpasos)
        {
            return $"Diste {numpasos } pasos";
        }

        //Pulmon
        public override string inalaciones(int numInalaciones)
        {
            return $"Diste {numInalaciones} inalaciones por minuto";
        }

        //Estomago
        public override string digiere(int numgramos)
        {
            return $"Digiere {numgramos} gramos por comida";
        }

    }
}


