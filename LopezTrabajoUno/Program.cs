using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopezTrabajoUno
{
    class Program
    {
        private static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("0 = Cancelar");
            Console.WriteLine("1 = Crear Jugador");
            Console.WriteLine("2 = Cambiar Color");
            Console.WriteLine("3 = Atacar");
            Console.WriteLine("4 = Recibir Daño");
            Console.WriteLine("5 = Usar una Pocion");
        }
        private static void MostrarMenuMuerte()
        {
            Console.Clear();
            Console.WriteLine("0 = Salir");
            Console.WriteLine("1 = Volver a Empezar");
        }
        private static void MostrarMenuPocion()
        {
            Console.Clear();
            Console.WriteLine("1 = Pocion de Salud");
            Console.WriteLine("2 = Pocion de Mana");
        }
        private static void ProcesarMenuPocion()
        {
            MostrarMenuPocion();
                var key3 = Console.ReadLine();
            if (key3=="1")
            {
                
            }
            if (key3 == "2")
            {

            }
        }
        private static void ProcesarMenuMuerte()
        {
                MostrarMenuMuerte();
                var key2 = Console.ReadLine();
            if (key2=="0")
            {
                Environment.Exit(0);            
            }
        }
        private static void ProcesarMenu()
        {
            Personaje P1 = new Personaje();
            Personaje P2 = new Personaje();
            P2.Color = "Rojo";
            P2.Vida = 100;
            P2.Fuerza = 50;
            P2.Defensa = 10;
            P2.Mana = 100;
            while (true)
            {
                MostrarMenu();
                var key = Console.ReadLine();
                if (key == "0")
                    break;
                switch (key)
                {
                    case "1":
                        CargarPersonaje(P1);
                        break;
                    case "2":
                        P1.CambiarColor();
                        break;
                    case "3":
                        P1.Atacar(P2);
                        break;
                    case "4":
                        Console.WriteLine("¿Cuanto daño recibio?");
                        int DañoRecibido = int.Parse(Console.ReadLine());
                        P1.RecibirDaño(DañoRecibido);
                        if (P1.Vida<=0)
                        {
                            ProcesarMenuMuerte();
                        }
                        break;
                    case "5":
                        ProcesarMenuPocion();
                        break;
                }
                Console.Clear();
                Console.WriteLine("Las estadisticas del primer personaje son: ");
                MostrarPersonaje(P1);
                Console.WriteLine("Las estadisticas del segundo personaje son: ");
                MostrarPersonaje(P2);
                Console.ReadKey();
            }
        }
        public static void CargarPersonaje(Personaje P)
        {
            Console.WriteLine("Ingrese el color");
            P.Color = Console.ReadLine();
            Console.WriteLine("Ingrese la vida");
            P.Vida = int.Parse(Console.ReadLine());
            P.VidaMaxima = P.Vida;
            Console.WriteLine("Ingrese la fuerza");
            P.Fuerza = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Defensa");
            P.Defensa = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Mana");
            P.Mana = int.Parse(Console.ReadLine());
            P.ManaMaximo = P.ManaMaximo;
        }
        public static void MostrarPersonaje(Personaje P)
        {
            Console.WriteLine($"Color:{P.Color }");
            Console.WriteLine($"Vida:{P.Vida}");
            Console.WriteLine($"Fuerza:{P.Fuerza}");
            Console.WriteLine($"Defensa:{P.Defensa}");
            Console.WriteLine($"Mana:{P.Mana}");
        }
        static void Main(string[] args)
        {
            ProcesarMenu();
            Console.ReadKey();
        }
    }
}
