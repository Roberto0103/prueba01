using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sdetCourse.Humano
{
    public abstract class Organos
    {
        internal void Pulmon(){
            Console.WriteLine("usando Pulmon");
        }


        internal void corazon()
        {
            Console.WriteLine("usando corazon");
        }

        internal void estomago()
        {
            Console.WriteLine("usando estomago");
        }

        internal void caminata()
        {
            Console.WriteLine("usando locomotrizidad");
        }

        internal void cerebro()
        {
            Console.WriteLine("usando cerebro");
        }


        public abstract string Bombear(int segundos);
        public abstract string Pasos(int numPasos);
        public abstract string inalaciones(int numInalaciones);
        public abstract string digiere(int numgramos);

    }

}
