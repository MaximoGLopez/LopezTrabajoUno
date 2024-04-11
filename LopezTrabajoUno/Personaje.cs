using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopezTrabajoUno
{
    class Personaje
    {
        public string Color { get; set; }
        public int Vida { get; set; }
        public int VidaMaxima { get; set; }
        public int Defensa { get; set; }
        public int Fuerza { get; set; }
        public int Mana { get; set; }
        public int ManaMaximo { get; set; }

        public void CambiarColor()
        {
            Console.WriteLine("Coloque el nuevo color");
            Color = Console.ReadLine();
        }
        public bool RecibirDaño(int Fuerza)
        {
            int Daño = Fuerza - Defensa;
            if (Daño>0)
            {
                Vida = Vida - Daño;
                    return true;
            }
            else
            {
                return false;
            }
        }
        public bool Atacar(Personaje Oponente)
        {
            if (Mana >= 10)
            {
                Mana -= 10;
                Oponente.RecibirDaño(Fuerza);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
