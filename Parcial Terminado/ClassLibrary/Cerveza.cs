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

        protected override string GenerarInforme()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append("Cerveza");
            datos.Append(base.GenerarInforme());

            return datos.ToString();
        }

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
                servir = (this.contenidoML * 80) / 100;
                this.contenidoML = 0;
            }
                

            return servir;
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }



    }
}
