using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terra2.Classes
{
    class Calculos
    {
        public int calculoElemento(bool positivo, int atributo)
        {
            if (positivo == true)
            {
                return (2 + atributo);
            }
            else
            {
                return (-2 + atributo);
            }
        }

        public int calculoHabilidadEC(bool positivo, int temple, int caracteristica)
        {
            if (positivo == true)
            {
                return (caracteristica + temple);
            }
            else
            {
                return (-2 + temple);
            }
        }

        public int subidaAtributo(int atributo)
        {
            return atributo + 1;
        }

        public int bajadaAtributo(int atributo)
        {
            return atributo - 1;
        }

        public int subidaElementoPorAtributo(int elemento)
        {
            return elemento + 1;
        }

        public int bajadaElementoPorAtributo(int elemento)
        {
            return elemento - 1;
        }
    }
}
