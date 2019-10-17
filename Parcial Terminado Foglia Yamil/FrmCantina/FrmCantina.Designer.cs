namespace FrmCantina
{
    partial class FrmCantina
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantina));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btmAgregar = new System.Windows.Forms.Button();
            this.nudContenido = new System.Windows.Forms.NumericUpDown();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            this.lblTipoBotella = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.rbAgua = new System.Windows.Forms.RadioButton();
            this.rbCerveza = new System.Windows.Forms.RadioButton();
            this.barra1 = new ControlCantina.Barra();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContenido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btmAgregar);
            this.panel1.Controls.Add(this.nudContenido);
            this.panel1.Controls.Add(this.nudCapacidad);
            this.panel1.Controls.Add(this.lblCapacidad);
            this.panel1.Controls.Add(this.lblContenido);
            this.panel1.Controls.Add(this.cmbBotellaTipo);
            this.panel1.Controls.Add(this.lblTipoBotella);
            this.panel1.Controls.Add(this.tbMarca);
            this.panel1.Controls.Add(this.lblMarca);
            this.panel1.Controls.Add(this.rbAgua);
            this.panel1.Controls.Add(this.rbCerveza);
            this.panel1.Location = new System.Drawing.Point(8, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 124);
            this.panel1.TabIndex = 1;
            // 
            // btmAgregar
            // 
            this.btmAgregar.Location = new System.Drawing.Point(457, 68);
            this.btmAgregar.Name = "btmAgregar";
            this.btmAgregar.Size = new System.Drawing.Size(119, 39);
            this.btmAgregar.TabIndex = 10;
            this.btmAgregar.Text = "Agregar";
            this.btmAgregar.UseVisualStyleBackColor = true;
            this.btmAgregar.Click += new System.EventHandler(this.btmAgregar_Click);
            // 
            // nudContenido
            // 
            this.nudContenido.Location = new System.Drawing.Point(253, 84);
            this.nudContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudContenido.Name = "nudContenido";
            this.nudContenido.Size = new System.Drawing.Size(67, 20);
            this.nudContenido.TabIndex = 9;
            this.nudContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Location = new System.Drawing.Point(162, 84);
            this.nudCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(67, 20);
            this.nudCapacidad.TabIndex = 8;
            this.nudCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(159, 68);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 7;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(250, 68);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(55, 13);
            this.lblContenido.TabIndex = 6;
            this.lblContenido.Text = "Contenido";
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Location = new System.Drawing.Point(457, 34);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbBotellaTipo.TabIndex = 5;
            // 
            // lblTipoBotella
            // 
            this.lblTipoBotella.AutoSize = true;
            this.lblTipoBotella.Location = new System.Drawing.Point(454, 18);
            this.lblTipoBotella.Name = "lblTipoBotella";
            this.lblTipoBotella.Size = new System.Drawing.Size(63, 13);
            this.lblTipoBotella.TabIndex = 4;
            this.lblTipoBotella.Text = "Botella Tipo";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(162, 34);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(158, 20);
            this.tbMarca.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(159, 18);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // rbAgua
            // 
            this.rbAgua.AutoSize = true;
            this.rbAgua.Location = new System.Drawing.Point(18, 53);
            this.rbAgua.Name = "rbAgua";
            this.rbAgua.Size = new System.Drawing.Size(50, 17);
            this.rbAgua.TabIndex = 1;
            this.rbAgua.TabStop = true;
            this.rbAgua.Text = "Agua";
            this.rbAgua.UseVisualStyleBackColor = true;
            // 
            // rbCerveza
            // 
            this.rbCerveza.AutoSize = true;
            this.rbCerveza.Location = new System.Drawing.Point(18, 18);
            this.rbCerveza.Name = "rbCerveza";
            this.rbCerveza.Size = new System.Drawing.Size(64, 17);
            this.rbCerveza.TabIndex = 0;
            this.rbCerveza.TabStop = true;
            this.rbCerveza.Text = "Cerveza";
            this.rbCerveza.UseVisualStyleBackColor = true;
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.barra1.Location = new System.Drawing.Point(8, 12);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(600, 368);
            this.barra1.TabIndex = 0;
            // 
            // FrmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barra1);
            this.Name = "FrmCantina";
            this.Text = "Alumno Yamil Foglia";
            this.Load += new System.EventHandler(this.FrmCantina_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContenido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlCantina.Barra barra1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbCerveza;
        private System.Windows.Forms.ComboBox cmbBotellaTipo;
        private System.Windows.Forms.Label lblTipoBotella;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.RadioButton rbAgua;
        private System.Windows.Forms.Button btmAgregar;
        private System.Windows.Forms.NumericUpDown nudContenido;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblContenido;
    }
}

