using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espacionTotales;
        private static Cantina singleton;

        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }

        private Cantina(int espacios)
        {
            this.espacionTotales = espacios;
            this.botellas = new List<Botella>();
        }

        /// <summary>
        /// Crea un unico objeto, y si ya esta creado modifica uno de sus atributos 
        /// </summary>
        /// <param name="espacios"></param>
        /// <returns>Si el objeto nunca se creo te devuelve el objeto creado, caso contrario modifica un atributo del mismo</returns>
        public static Cantina GetCantina(int espacios)
        {
            if (singleton is null)
            {
                singleton = new Cantina(espacios);
            }
            else
            {
                singleton.espacionTotales = espacios;
            }

            return singleton;
        }

        /// <summary>
        /// Agrega una botella a la cantina
        /// </summary>
        /// <param name="c">Cantina</param>
        /// <param name="b">Botella a incluir a la cantina</param>
        /// <returns></returns>
        public static bool operator +(Cantina c, Botella b)
        {
            bool rta = false;
            if(c.espacionTotales > 0)
            {
                c.botellas.Add(b);
                c.espacionTotales--;
                rta = true;
            }
            return rta;
        }

    }
}
