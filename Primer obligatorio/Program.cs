using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primer_obligatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            bool continuar = true;

             while (continuar)
            {
                //  Es aconsejable cubrirnos por cualquier error no previsto (la aplicación no se cae y sigue mostrando el menú)
                try
                {
                    opcion = PidoOpcion();

                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                         
                            break;

                        case 2:
                            Console.Clear();
                            
                            break;

                        case 3:
                            Console.Clear();
                           
                            break;

                        case 4:
                            Console.Clear();

                            break;

                        case 5:
                            continuar = false;

                            Console.Clear();
                            Console.WriteLine("Gracias por utilizar la aplicación");
                            Console.ReadLine();
                            break;


                    }// Fin switch
                }// Fin try

                catch (Exception ex)
                {
                    Console.WriteLine("Error inesperado: " + ex.Message);
                    Console.ReadLine();

                }// Fin catch
            }// Fin while
        }// Fin Main






        //  Pedimos el ingreso de un número entero
        static int PidoEntero(string mensaje)
        {
            int numero;

            while (true)
            {
                try
                {
                    Console.WriteLine(mensaje);
                    numero = Convert.ToInt32(Console.ReadLine());

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Console.WriteLine();
                }
            }
            return numero;
        }

        //  Operación que ofrece el menú al usuario (y devuelve la opción seleccionada)
        static int PidoOpcion()
        {
            int opcion;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - Agregar frase");
                Console.WriteLine("2 - Invertir frase");
                Console.WriteLine("3 - Mostrar todas las frases");
                Console.WriteLine("4 - Buscar una palabra");
                Console.WriteLine("5 - Salir");
                Console.WriteLine();

                opcion = PidoEntero("Eliga una opción: ");

                if (opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("Debe ingresar uan opción entre 1 y 5");
                    Console.ReadLine();
                }
                else
                    return opcion;
            }
        }







    }
}
