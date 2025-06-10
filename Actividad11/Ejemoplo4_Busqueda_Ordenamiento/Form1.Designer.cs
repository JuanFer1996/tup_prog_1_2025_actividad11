namespace Ejemoplo4_Busqueda_Ordenamiento
{
    partial class FormPrincipal
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
            this.lbResultado = new System.Windows.Forms.Label();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.btnCalcularPromedio = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.lb_promedio = new System.Windows.Forms.Label();
            this.lb_valor = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btnListarOrdenado = new System.Windows.Forms.Button();
            this.lbResultadoBusqueda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(213, 91);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(63, 13);
            this.lbResultado.TabIndex = 21;
            this.lbResultado.Text = "lbResultado";
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(12, 314);
            this.tbResultado.Multiline = true;
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(405, 69);
            this.tbResultado.TabIndex = 20;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(216, 40);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 20);
            this.tbValor.TabIndex = 19;
            // 
            // btnCalcularPromedio
            // 
            this.btnCalcularPromedio.Location = new System.Drawing.Point(336, 91);
            this.btnCalcularPromedio.Name = "btnCalcularPromedio";
            this.btnCalcularPromedio.Size = new System.Drawing.Size(135, 23);
            this.btnCalcularPromedio.TabIndex = 18;
            this.btnCalcularPromedio.Text = "Calcular Promedio";
            this.btnCalcularPromedio.UseVisualStyleBackColor = true;
            this.btnCalcularPromedio.Click += new System.EventHandler(this.btnCalcularPromedio_Click);
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(376, 40);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btRegistrar.TabIndex = 17;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // lb_promedio
            // 
            this.lb_promedio.AutoSize = true;
            this.lb_promedio.Location = new System.Drawing.Point(55, 77);
            this.lb_promedio.Name = "lb_promedio";
            this.lb_promedio.Size = new System.Drawing.Size(60, 13);
            this.lb_promedio.TabIndex = 16;
            this.lb_promedio.Text = "Promedio : ";
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Location = new System.Drawing.Point(55, 40);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(31, 13);
            this.lb_valor.TabIndex = 15;
            this.lb_valor.Text = "Valor";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(116, 209);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(100, 20);
            this.tbBuscar.TabIndex = 22;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(376, 205);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 23;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btnListarOrdenado
            // 
            this.btnListarOrdenado.Location = new System.Drawing.Point(423, 314);
            this.btnListarOrdenado.Name = "btnListarOrdenado";
            this.btnListarOrdenado.Size = new System.Drawing.Size(75, 69);
            this.btnListarOrdenado.TabIndex = 24;
            this.btnListarOrdenado.Text = "Listar Ordenado";
            this.btnListarOrdenado.UseVisualStyleBackColor = true;
            this.btnListarOrdenado.Click += new System.EventHandler(this.btnListarOrdenado_Click);
            // 
            // lbResultadoBusqueda
            // 
            this.lbResultadoBusqueda.AutoSize = true;
            this.lbResultadoBusqueda.Location = new System.Drawing.Point(116, 256);
            this.lbResultadoBusqueda.Name = "lbResultadoBusqueda";
            this.lbResultadoBusqueda.Size = new System.Drawing.Size(0, 13);
            this.lbResultadoBusqueda.TabIndex = 25;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.lbResultadoBusqueda);
            this.Controls.Add(this.btnListarOrdenado);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.btnCalcularPromedio);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.lb_promedio);
            this.Controls.Add(this.lb_valor);
            this.Name = "FormPrincipal";
            this.Text = "Busqueda y Ordenamiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Button btnCalcularPromedio;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Label lb_promedio;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btnListarOrdenado;
        private System.Windows.Forms.Label lbResultadoBusqueda;
    }
}

