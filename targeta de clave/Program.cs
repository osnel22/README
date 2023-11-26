using System;
using System.Collections;
using System.Data;
using System.Text;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        string usuario = "gonzalez";
        string contraseña = "12345";
        bool accesoPermitido = false;

        while (!accesoPermitido)
        {

            Console.WriteLine("Ingrese el nombre de usuario: ");
            string usuarioIngresado = Console.ReadLine();

            Console.WriteLine("Ingrese la contraseña: ");
            string contrasenaIngresada = Console.ReadLine();

            if (usuarioIngresado == usuario && contrasenaIngresada == contraseña)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" ¡Acceso permitido! ");
                Console.WriteLine("Aqui tu targeta de clave ....");
                Console.ResetColor();





                Random random = new Random();

                int[] numerosAleatorios = new int[41];

                for (int i = 0; i < numerosAleatorios.Length; i++)
                {
                    numerosAleatorios[i] = random.Next(1, 1001);
                }

                int posicion = 0;
                for (posicion = 1; posicion < numerosAleatorios.Length; posicion++)
                {
                    Console.WriteLine("Posición--> {0}:   clave:--> {1}", posicion, numerosAleatorios[posicion ]);
                }


                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                posicion = random.Next(1, 41);
                Console.WriteLine("Ingrese la clave en la posición {0}: ", posicion);
                Console.WriteLine(" ");

                int numeroIngresado = 0;
                bool claveCorrecta = false;

                while (!claveCorrecta)
                {
                    string entradaUsuario = Console.ReadLine();
                    int.TryParse(entradaUsuario, out numeroIngresado);

                    if (numeroIngresado == numerosAleatorios[posicion])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" ");
                        Console.WriteLine("-------¡Número de calve es correcto!.--------");
                        Console.WriteLine("-----------Bienvenido al sistema-------------");

                        Console.ResetColor();
                        claveCorrecta = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("----------------------------------Número de clave incorrecto. Intente nuevamente.---------------------------------------");
                        Console.ResetColor();
                        Console.WriteLine("Ingrese la clave en la posición {0}: ", posicion);
                    }
                }


                Console.WriteLine("Presione cualquier tecla para salir...");

                Console.ReadKey();
                accesoPermitido = true;

            }
            else if (usuarioIngresado == usuario)

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Acceso denegado. contraseña incorrecta.");
                Console.ResetColor();
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Acceso denegado. Nombre de usuario incorrecto.");
                Console.ResetColor();
                
            }

            
        }
        
        
    }
}


