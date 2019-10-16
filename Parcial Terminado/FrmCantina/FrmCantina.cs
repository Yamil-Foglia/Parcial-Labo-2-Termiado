using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCantina;
using Entidades;

namespace FrmCantina
{
    public partial class FrmCantina : Form
    {
        public Botella.Tipo tipo;

        public FrmCantina()
        {
            InitializeComponent();
            this.barra1.SetCantina = Cantina.GetCantina(10);
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

        private void btmAgregar_Click(object sender, EventArgs e)
        {

            Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);
            if (rbAgua.Checked == true)
            {
                Botella botellaDeAgua = new Agua((int)nudCapacidad.Value, tbMarca.Text, (int)nudContenido.Value);
                barra1.AgregarBotella(botellaDeAgua);
            }
            else if(rbCerveza.Checked == true)
            {
                Botella botellaDeCerveza = new Cerveza((int)nudCapacidad.Value, tbMarca.Text, this.tipo, (int)nudContenido.Value);
                barra1.AgregarBotella(botellaDeCerveza);
            } 
        }
    }
}
