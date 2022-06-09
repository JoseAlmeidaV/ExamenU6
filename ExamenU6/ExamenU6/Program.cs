using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExamenU6
{
    class Program
    {
        class Amazon// calse
        {
            //campos
            public string nombre, descripcion;
            public float precio;
            int cantidadStock;

            public Amazon(string nombre, string descripcion, float precio, int cantidadStock) // constructor
            {
                this.nombre = nombre;
                this.descripcion = descripcion;
                this.precio = precio;
                this.cantidadStock = cantidadStock;

            }
            public void Resultados() // metodo para desplegar los resultados en pantalla 
            {
                Console.WriteLine("*****INVENTARIO DE AMAZON*****");
                Console.WriteLine();
                Console.WriteLine("^^Producto agregado^^");
                Console.WriteLine("Nombre del Producto: " + nombre);
                Console.WriteLine("Descripcion del producto: " + descripcion);
                Console.WriteLine("precio del producto: " + precio);
                Console.WriteLine("Cantidad en stock: " + cantidadStock);
            }
        }
        static void Main(string[] args)
        {
            //variables auxiliares 
            string nombre, descripcion;
            float precio;
            int cantidadStock;
            int resp;


            StreamWriter sw = new StreamWriter("productos.txt", true);
            Console.WriteLine("****indique la opcion que desee (Coloque el numero)**** ");
            Console.WriteLine("1- Agregar producto");
            Console.WriteLine("2- Salir del programa");
            resp = int.Parse(Console.ReadLine());
            Console.Clear();

            try
            {
                while (resp != 2)
                {
                    Console.WriteLine("****Binvenido al registro de investario de Amazon****");
                    Console.WriteLine();
                    Console.Write("Coloque el nombre del producto: ");
                    nombre = Console.ReadLine();
                    Console.Write("Coloque la descripcion del producto: ");
                    descripcion = Console.ReadLine();
                    Console.Write("Coloque el precio del prodcuto: ");
                    precio = float.Parse(Console.ReadLine());
                    Console.Write("Coloque la cantidad en Stock: ");
                    cantidadStock = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Si desea continuar agragandoi productos precione 1, de lo contrario presione 2");
                    resp = int.Parse(Console.ReadLine());
                    Console.Clear();

                    sw.WriteLine();
                    sw.WriteLine("Nombre del producto: " + nombre);
                    sw.WriteLine("Descripcion del producto: " + descripcion);
                    sw.WriteLine("Precio del producto {0:c} " , precio);
                    sw.WriteLine("Cantidad en stock: " + cantidadStock);

                    Amazon A1 = new Amazon(nombre, descripcion, precio, cantidadStock);
                    A1.Resultados();
                    Console.WriteLine();
                    Console.WriteLine("Presione Enter para continuar...");
                    Console.ReadKey();
                    Console.Clear();


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }
            Console.WriteLine("Gracias por utilizar nuestro servicio de inventario, Amazon se lo agradece !!!!!");
            Console.WriteLine();
            Console.WriteLine("Precion ENRTER para salir");
            sw.Close();
            Console.ReadKey();
            
        }
    }
}
