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

        /// <summary>
        /// Retornara el atributo capacidadML en litros
        /// </summary>
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
        
        /// <summary>
        /// Retorna el porsentaje del contenido teniendo en cuenta el contenido y la capacidad 
        /// </summary>
        public float PorsentajeContenido
        {
            get
            {
                return ((this.contenidoML * 100) / this.capacidadML);
            }
        }


        public abstract int ServirMedida();
        
        /// <summary>
        /// Genera un informe donde se encuntra toda la informacion de la botella
        /// </summary>
        /// <returns>El informe realizado</returns>
        protected virtual string GenerarInforme()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Marca: {0}\n", this.marca);
            datos.AppendFormat("Capacidad: {0}\n", this.CapacidadLitros);
            datos.AppendFormat("Porsentaje del contenido: %{0}\n", this.PorsentajeContenido);

            return datos.ToString();
        }

        /// <summary>
        /// Override de ToString()
        /// </summary>
        /// <returns>El informe generado por la funcion GenerarInforme()</returns>
        public override string ToString()
        {
            return this.GenerarInforme();
        }

    }
}

