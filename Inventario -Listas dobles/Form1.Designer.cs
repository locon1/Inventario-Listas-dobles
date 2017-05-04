namespace Inventario__Listas_dobles
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdReporte = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cmdAgregar_inicio = new System.Windows.Forms.Button();
            this.cmdEliminar_inicio = new System.Windows.Forms.Button();
            this.cmdEliminar_final = new System.Windows.Forms.Button();
            this.cmdReporte_inverso = new System.Windows.Forms.Button();
            this.cmdInsertar = new System.Windows.Forms.Button();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdReporte
            // 
            this.cmdReporte.Location = new System.Drawing.Point(505, 341);
            this.cmdReporte.Name = "cmdReporte";
            this.cmdReporte.Size = new System.Drawing.Size(75, 23);
            this.cmdReporte.TabIndex = 58;
            this.cmdReporte.Text = "Reporte";
            this.cmdReporte.UseVisualStyleBackColor = true;
            this.cmdReporte.Click += new System.EventHandler(this.cmdReporte_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(121, 234);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 40);
            this.cmdBuscar.TabIndex = 57;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(121, 280);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.TabIndex = 56;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(15, 280);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar.TabIndex = 55;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // txtLista
            // 
            this.txtLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLista.Location = new System.Drawing.Point(227, 12);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLista.Size = new System.Drawing.Size(353, 306);
            this.txtLista.TabIndex = 54;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(12, 189);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(184, 20);
            this.txtCosto.TabIndex = 53;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(12, 173);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(37, 13);
            this.lblCosto.TabIndex = 52;
            this.lblCosto.Text = "Costo:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(12, 139);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(184, 20);
            this.txtCantidad.TabIndex = 51;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 123);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 50;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 20);
            this.txtNombre.TabIndex = 49;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 48;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(184, 20);
            this.txtCodigo.TabIndex = 47;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 46;
            this.lblCodigo.Text = "Código:";
            // 
            // cmdAgregar_inicio
            // 
            this.cmdAgregar_inicio.Location = new System.Drawing.Point(15, 234);
            this.cmdAgregar_inicio.Name = "cmdAgregar_inicio";
            this.cmdAgregar_inicio.Size = new System.Drawing.Size(75, 40);
            this.cmdAgregar_inicio.TabIndex = 59;
            this.cmdAgregar_inicio.Text = "Agregar al inicio";
            this.cmdAgregar_inicio.UseVisualStyleBackColor = true;
            this.cmdAgregar_inicio.Click += new System.EventHandler(this.cmdAgregar_inicio_Click);
            // 
            // cmdEliminar_inicio
            // 
            this.cmdEliminar_inicio.Location = new System.Drawing.Point(15, 309);
            this.cmdEliminar_inicio.Name = "cmdEliminar_inicio";
            this.cmdEliminar_inicio.Size = new System.Drawing.Size(75, 40);
            this.cmdEliminar_inicio.TabIndex = 60;
            this.cmdEliminar_inicio.Text = "Eliminar al inicio";
            this.cmdEliminar_inicio.UseVisualStyleBackColor = true;
            this.cmdEliminar_inicio.Click += new System.EventHandler(this.cmdEliminar_inicio_Click);
            // 
            // cmdEliminar_final
            // 
            this.cmdEliminar_final.Location = new System.Drawing.Point(121, 309);
            this.cmdEliminar_final.Name = "cmdEliminar_final";
            this.cmdEliminar_final.Size = new System.Drawing.Size(75, 40);
            this.cmdEliminar_final.TabIndex = 61;
            this.cmdEliminar_final.Text = "Eliminar al final";
            this.cmdEliminar_final.UseVisualStyleBackColor = true;
            this.cmdEliminar_final.Click += new System.EventHandler(this.cmdEliminar_final_Click);
            // 
            // cmdReporte_inverso
            // 
            this.cmdReporte_inverso.Location = new System.Drawing.Point(424, 332);
            this.cmdReporte_inverso.Name = "cmdReporte_inverso";
            this.cmdReporte_inverso.Size = new System.Drawing.Size(75, 40);
            this.cmdReporte_inverso.TabIndex = 62;
            this.cmdReporte_inverso.Text = "Reporte inverso";
            this.cmdReporte_inverso.UseVisualStyleBackColor = true;
            this.cmdReporte_inverso.Click += new System.EventHandler(this.cmdReporte_inverso_Click);
            // 
            // cmdInsertar
            // 
            this.cmdInsertar.Location = new System.Drawing.Point(333, 339);
            this.cmdInsertar.Name = "cmdInsertar";
            this.cmdInsertar.Size = new System.Drawing.Size(75, 23);
            this.cmdInsertar.TabIndex = 63;
            this.cmdInsertar.Text = "Insertar";
            this.cmdInsertar.UseVisualStyleBackColor = true;
            this.cmdInsertar.Click += new System.EventHandler(this.cmdInsertar_Click);
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(227, 341);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(100, 20);
            this.txtPosicion.TabIndex = 64;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 381);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.cmdInsertar);
            this.Controls.Add(this.cmdReporte_inverso);
            this.Controls.Add(this.cmdEliminar_final);
            this.Controls.Add(this.cmdEliminar_inicio);
            this.Controls.Add(this.cmdAgregar_inicio);
            this.Controls.Add(this.cmdReporte);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "Form1";
            this.Text = "Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdReporte;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button cmdAgregar_inicio;
        private System.Windows.Forms.Button cmdEliminar_inicio;
        private System.Windows.Forms.Button cmdEliminar_final;
        private System.Windows.Forms.Button cmdReporte_inverso;
        private System.Windows.Forms.Button cmdInsertar;
        private System.Windows.Forms.TextBox txtPosicion;
    }
}

