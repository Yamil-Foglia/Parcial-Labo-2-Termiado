using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        private const int MEDIDA = 400;

        public Agua(int capacidadML, string marca, int contenidoMl)
            : base(marca, capacidadML, contenidoMl)
        {
        }

        /// <summary>
        /// Resta la medida servida al contenido de la botella, si la botella no tiene el contenido que necesita sirve el total del contenido
        /// </summary>
        /// <returns>la cantidad que se sirve</returns>
        public int ServirMedida(int medida)
        {
            int servir;
            if (medida <= this.contenidoML)
            {
                this.contenidoML = this.contenidoML - medida;
                servir = medida;
            }
            else
            {
                servir = this.contenidoML;
                this.contenidoML = 0;
            }

            return servir;
        }

        public override int ServirMedida()
        {
            return ServirMedida(MEDIDA);
        }

        /// <summary>
        /// Genera un informe donde se encuntra toda la informacion de la botella
        /// </summary>
        /// <returns>El informe realizado</returns>
        protected override string GenerarInforme()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append("Agua\n");
            datos.Append(base.GenerarInforme());

            return datos.ToString();
        }


    }
}
