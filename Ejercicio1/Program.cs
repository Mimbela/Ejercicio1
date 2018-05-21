using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{


    class Program
    {
        static void Main(string[] args)
        {
            Circunferencia Rueda = new Circunferencia();
            Rueda.ModificarRadio(10.2);

            Circunferencia Moneda = new Circunferencia();
            Moneda.ModificarRadio(1.4);

            Console.WriteLine("AREA RUEDA: {0}", Rueda.Area());
            Console.WriteLine("AREA MONEDA: {0}", Moneda.Area());
            Console.WriteLine("PERIMETRO RUEDA: {0}", Rueda.Perimetro());
            Console.WriteLine("PERIMETRO MONEDA: {0}", Moneda.Perimetro());

            Console.Read();
        }
    }
}