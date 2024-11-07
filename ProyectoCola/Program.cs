using System;

namespace ProyectoCola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cola cola = new Cola(0);

            int opcion, valor, valorDev;
            bool verificador;

            bool a = true;

            while (a == true)
            {
                Console.WriteLine("     ");
                Console.WriteLine("-----------Proyecto Pilas-----------");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("       1.- Establecer Tamaño");
                Console.WriteLine("           2.- Insert");
                Console.WriteLine("           3.- Extract");
                Console.WriteLine("          4.- Imprimir");
                Console.WriteLine("           5.- Salir");
                Console.WriteLine("      _____________________");
                Console.WriteLine("      Seleccionar Opción => ");

                string opc = Console.ReadLine();

                try
                {
                    opcion = Convert.ToInt32(opc);

                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Insertar tamaño de la cola: ");
                            valor = Convert.ToInt32(Console.ReadLine());
                            cola = new Cola(valor);
                            break;

                        case 2:
                            Console.Clear();
                            Console.Write("Valor a insertar en la cola: ");
                            valor = Convert.ToInt32(Console.ReadLine());
                            verificador = cola.Insert(valor);

                            if (verificador)
                            {
                                Console.WriteLine($"Se inserto el valor: {valor} correctamente");
                            }
                            else
                            {
                                Console.WriteLine($"cola llena, no se inserto ningun valor");
                            }
                            Console.ReadLine();
                            break;

                        case 3:
                            Console.Clear();
                            valorDev = cola.Extract();

                            if (valorDev == -1)
                            {
                                Console.WriteLine($"cola vacia, no se elimino ningun valor");
                            }
                            else
                            {
                                Console.WriteLine($"Se elimino el valor {valorDev} de la cola");
                            }
                            Console.ReadLine();


                            break;

                        case 4:
                            Console.Clear();
                            cola.Print();
                            Console.ReadLine();
                            break;

                        case 5:
                            a = false;
                        break;

                        default:
                           Console.WriteLine("Opcion no valida");
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Opcion no valida");
                }
            }
        }
    }
}