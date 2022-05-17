using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAEA_PC02.Adapter02
{
    class Tipo_Motores
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("*Motor Naftero*");

            Motor motor1 = new MotorNaftero();
            motor1.Arrancar();
            motor1.Acelerar();
            motor1.Detener();
            motor1.CargarCombustible();

            Console.WriteLine("------------------");
            Console.WriteLine("*Motor Diesel*");

            Motor motor2 = new MotorDiesel();
            motor2.Arrancar();
            motor2.Acelerar();
            motor2.Detener();
            motor2.CargarCombustible();

            Console.WriteLine("------------------");
            Console.WriteLine("*Motor Electrico*");

            Motor motor3 = new MotorElectricoAdapter();
            motor3.Arrancar();
            motor3.Acelerar();
            motor3.Detener();
            motor3.CargarCombustible();

            Console.ReadKey();
        }

    }
}
