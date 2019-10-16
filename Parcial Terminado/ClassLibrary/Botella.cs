using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        public enum Tipo
        {
            Plastico,
            Vidrio
        }
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        protected Botella(string marca, int capacidadML, int contenidoML)
        {

            if (capacidadML < contenidoML)
                this.contenidoML = capacidadML;
            else
                this.contenidoML = contenidoML;

            this.capacidadML = capacidadML;
            this.marca = marca;
        }

        public int CapacidadLitros
        {
            get
            {
                return (this.capacidadML/1000); 
            }
        }

        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = value;
            }
        }
        
        public float PorsentajeContenido
        {
            get
            {
                return ((this.contenidoML * 100) / this.capacidadML);
            }
        }


        public abstract int ServirMedida();
        

        protected virtual string GenerarInforme()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Marca: {0}\n", this.marca);
            datos.AppendFormat("Capacidad: {0}\n", this.CapacidadLitros);
            datos.AppendFormat("Porsentaje del contenido: {0}\n", this.PorsentajeContenido);

            return datos.ToString();
        }

        public override string ToString()
        {
            return this.GenerarInforme();
        }

    }
}

