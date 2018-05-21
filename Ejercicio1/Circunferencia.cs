using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Circunferencia
    {
        private double radio;

        public double Area()
        {
            double area = Math.PI * radio * radio;

            return area;
        }
        public double Perimetro()
        {
            double perimetro = 2 * Math.PI * radio;
            return perimetro;
        }

        public void ModificarRadio(double newRadio)
        {
            radio = newRadio;
        }

        public double ConsultarRadio()
        {
            return radio;
        }
    }
}

//EJERCICIO 1
//Declarar una clase llamada Circunferencia que tenga como atributo privado el radio de tipo real y los siguientes métodos:
//a) Calcular el área.
//b) Calcular el perímetro.
//c) Método para modificar el radio
//d) Método para consultar el valor del radio
//Declara dos objetos: Rueda y Moneda y realiza las siguientes operaciones:
//a) Inicializa el radio de la Rueda con el valor de 10.2
//b) Inicializa el radio de la Moneda con el valor de 1.4
//c) Imprime el área de la Rueda.
//d) Imprime el área de la Moneda.
//e) Imprime el perímetro de la Rueda.
//f) Imprime el perímetro de la Moneda.

    