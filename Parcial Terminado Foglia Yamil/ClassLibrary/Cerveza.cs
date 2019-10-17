using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza: Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;

        public Cerveza(int capacidadML, string marca, int contenidoML)
            :base(marca, capacidadML, contenidoML)
        {
            this.tipo = Tipo.Vidrio;
        }

        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML)
            :this(capacidadML, marca, contenidoML)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Genera un informe donde se encuntra toda la informacion de la botella
        /// </summary>
        /// <returns>El informe realizado</returns>
        protected override string GenerarInforme()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append("Cerveza");
            datos.Append(base.GenerarInforme());

            return datos.ToString();
        }

        /// <summary>
        /// Resta la medida servida al contenido de la botella, si la botella no tiene el contenido que necesita sirve el total del contenido(Siepre se servira el %80, por la espuma)
        /// </summary>
        /// <returns>la cantidad que se sirve</returns>
        public override int ServirMedida()
        {
            int servir;
            if (MEDIDA <= this.contenidoML)
            {
                this.contenidoML = this.contenidoML - MEDIDA;
                servir = (MEDIDA*80) / 100;
            }
            else
            {
                servir = this.contenidoML;
                this.contenidoML = 0;
            }
            return servir;
        }


        /// <summary>
        /// Retorna el tipo de botella que usa la cerveza pasada por parametro
        /// </summary>
        /// <param name="cerveza">cerveza</param>
        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }



    }
}
