using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformar_grados_centigrados_a_grados_fahrenheint
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresar grados centigrados");

            double c = Convert.ToDouble(Console.ReadLine());

            double f = (c * 10 / 5) + (32);

            Console.WriteLine(c + "ºC equivale a" + f + "ºF");

            Console.WriteLine("Presione Enter para cerrar");


            Console.ReadLine();

        }

       
    }
}
