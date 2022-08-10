using Microsoft.VisualStudio.TestTools.UnitTesting;
using sdetCourse.Humano;
using System;

namespace sdetCourse
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AccionesHumanos rober = new AccionesHumanos();
            AccionesPerros firulais = new AccionesPerros();
         

            Console.WriteLine(rober.Bombear(60));
            Console.WriteLine(firulais.Bombear(60));

            Console.WriteLine(rober.Pasos(61200));
            Console.WriteLine(firulais.Pasos(61200));

            Console.WriteLine(rober.inalaciones(10));
            Console.WriteLine(firulais.inalaciones(10));

            Console.WriteLine(rober.digiere(500));
            Console.WriteLine(firulais.digiere(500));



            /*
            rober.respirando();
            accion.palpitar();
            accion.digerir();
            accion.caminar();
            accion.pensar();
            
            */

        }
    }
}
