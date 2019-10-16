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



        protected override string GenerarInforme()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append("Agua\n");
            datos.Append(base.GenerarInforme());

            return datos.ToString();
        }


    }
}
