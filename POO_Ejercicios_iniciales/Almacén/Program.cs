using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacén
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Productos num1= null;
            Productos num2=null;
            try
            {
                num1 = new Productos("Opera", "Galletita");
                num2 = new Productos("Coca", "Gaseosa", 100, 50.65f);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            List<Productos> LstProductos = new List<Productos>();
            LstProductos.Add(num1);
            LstProductos.Add(num2);

            foreach (Productos a in LstProductos)
            {
                a.VerificarStock();
            }
            Console.WriteLine(num1.ToString());
            Console.WriteLine(num2.ToString());

            num1.Comprar();
            num1.Comprar(10);

            Console.WriteLine(num1.vender());
            Console.WriteLine(num2.vender(100));
            Console.WriteLine(num1.vender(20));

            foreach (Productos a in LstProductos)
            {
                a.VerificarStock();
            }

            
            Console.WriteLine(num1.ToString());
            Console.WriteLine(num2.ToString());

            

            Console.ReadKey();


        }
    }
}
