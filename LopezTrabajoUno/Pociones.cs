using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopezTrabajoUno
{
    class Pociones
    {
        public int Minimo { get; set; }
        public int Maximo { get; set; }
    }
    class PocionVida : Pociones
    {
        public bool Usar(Personaje P)
        {
            int Curacion = new Random().Next(Minimo, Maximo + 1);
            if (P.Vida+Curacion<P.VidaMaxima)
            {
                P.Vida = P.VidaMaxima;
                return true;
            }
            if (P.Vida+Curacion>P.VidaMaxima)
            {
                P.Vida = P.Vida + Curacion;
                return true;
            }

                return true;
        }

    }
    class PocionMana : Pociones
    {
        public bool Usar(Personaje P)
        {
            int Magia = new Random().Next(Minimo, Maximo + 1);
            if (P.Mana+Magia<P.ManaMaximo)
            {
            P.Mana = P.ManaMaximo;
                return true;
            }
            if (P.Mana + Magia > P.ManaMaximo)
            {
                P.Mana = P.Mana + Magia;
                    return true;
            }
            return false;

        }

    }
}
