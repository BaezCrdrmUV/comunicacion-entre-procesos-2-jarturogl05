using System;
using System.Diagnostics;
using System.IO;

namespace comunicacion_entre_procesos_2_jarturogl05
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = Process.GetCurrentProcess();
            bool salida = false;


            while (!salida)
            {
                Console.WriteLine("1. Escribir un mensaje");
                Console.WriteLine("2. Leer Mensajes");
                Console.WriteLine("3. Salir");
                string respuesta = Console.ReadLine();

                switch (respuesta)
                {
                    case "1":                        
                        Console.WriteLine("Escribe un mensaje");
                        string mensaje = Console.ReadLine();
                        using (StreamWriter writer = System.IO.File.AppendText("ArchivoDeTexto.txt"))
                        {
                            writer.WriteLine("El proceso con el PID "+  process.Id + " Escribió " +  mensaje );
                        }
                        break;
                    case "2":
                        Console.WriteLine(File.ReadAllText("ArchivoDeTexto.txt"));
                        break;
                    case "3":
                        salida = true;
                        break;
                    default:
                        Console.WriteLine ("Escribe una opción correcta");
                        break;

                }
            }


        }
    }
}
