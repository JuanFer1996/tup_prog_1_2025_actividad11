namespace Ejemplo5
{
    partial class FormPrncipal
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
            this.lbResultadoBusqueda = new System.Windows.Forms.Label();
            this.btnListarOrdenado = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.btnCalcularPromedio = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.lb_promedio = new System.Windows.Forms.Label();
            this.lb_valor = new System.Windows.Forms.Label();
            this.btnMayoresAlPromedio = new System.Windows.Forms.Button();
            this.Maximo = new System.Windows.Forms.Label();
            this.Minimo = new System.Windows.Forms.Label();
            this.btnMaximo = new System.Windows.Forms.Button();
            this.btnMinimo = new System.Windows.Forms.Button();
            this.lbMaximo = new System.Windows.Forms.Label();
            this.lbMinimo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbResultadoBusqueda
            // 
            this.lbResultadoBusqueda.AutoSize = true;
            this.lbResultadoBusqueda.Location = new System.Drawing.Point(28, 320);
            this.lbResultadoBusqueda.Name = "lbResultadoBusqueda";
            this.lbResultadoBusqueda.Size = new System.Drawing.Size(0, 13);
            this.lbResultadoBusqueda.TabIndex = 36;
            // 
            // btnListarOrdenado
            // 
            this.btnListarOrdenado.Location = new System.Drawing.Point(449, 346);
            this.btnListarOrdenado.Name = "btnListarOrdenado";
            this.btnListarOrdenado.Size = new System.Drawing.Size(96, 33);
            this.btnListarOrdenado.TabIndex = 35;
            this.btnListarOrdenado.Text = "Listar Ordenado";
            this.btnListarOrdenado.UseVisualStyleBackColor = true;
            this.btnListarOrdenado.Click += new System.EventHandler(this.btnListarOrdenado_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(174, 281);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 34;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(31, 281);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(100, 20);
            this.tbBuscar.TabIndex = 33;
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(115, 59);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(0, 13);
            this.lbResultado.TabIndex = 32;
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(26, 353);
            this.tbResultado.Multiline = true;
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(405, 69);
            this.tbResultado.TabIndex = 31;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(118, 7);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 20);
            this.tbValor.TabIndex = 30;
            // 
            // btnCalcularPromedio
            // 
            this.btnCalcularPromedio.Location = new System.Drawing.Point(254, 54);
            this.btnCalcularPromedio.Name = "btnCalcularPromedio";
            this.btnCalcularPromedio.Size = new System.Drawing.Size(145, 23);
            this.btnCalcularPromedio.TabIndex = 29;
            this.btnCalcularPromedio.Text = "Calcular Promedio";
            this.btnCalcularPromedio.UseVisualStyleBackColor = true;
            this.btnCalcularPromedio.Click += new System.EventHandler(this.btnCalcularPromedio_Click);
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(254, 7);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(145, 23);
            this.btRegistrar.TabIndex = 28;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // lb_promedio
            // 
            this.lb_promedio.AutoSize = true;
            this.lb_promedio.Location = new System.Drawing.Point(23, 59);
            this.lb_promedio.Name = "lb_promedio";
            this.lb_promedio.Size = new System.Drawing.Size(60, 13);
            this.lb_promedio.TabIndex = 27;
            this.lb_promedio.Text = "Promedio : ";
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Location = new System.Drawing.Point(23, 10);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(31, 13);
            this.lb_valor.TabIndex = 26;
            this.lb_valor.Text = "Valor";
            // 
            // btnMayoresAlPromedio
            // 
            this.btnMayoresAlPromedio.Location = new System.Drawing.Point(449, 382);
            this.btnMayoresAlPromedio.Name = "btnMayoresAlPromedio";
            this.btnMayoresAlPromedio.Size = new System.Drawing.Size(96, 40);
            this.btnMayoresAlPromedio.TabIndex = 37;
            this.btnMayoresAlPromedio.Text = "Listado Mayor al Promedio";
            this.btnMayoresAlPromedio.UseVisualStyleBackColor = true;
            this.btnMayoresAlPromedio.Click += new System.EventHandler(this.btnMayoresAlPromedio_Click);
            // 
            // Maximo
            // 
            this.Maximo.AutoSize = true;
            this.Maximo.Location = new System.Drawing.Point(23, 126);
            this.Maximo.Name = "Maximo";
            this.Maximo.Size = new System.Drawing.Size(49, 13);
            this.Maximo.TabIndex = 38;
            this.Maximo.Text = "Maximo :";
            // 
            // Minimo
            // 
            this.Minimo.AutoSize = true;
            this.Minimo.Location = new System.Drawing.Point(23, 173);
            this.Minimo.Name = "Minimo";
            this.Minimo.Size = new System.Drawing.Size(46, 13);
            this.Minimo.TabIndex = 39;
            this.Minimo.Text = "Minimo :";
            // 
            // btnMaximo
            // 
            this.btnMaximo.Location = new System.Drawing.Point(254, 124);
            this.btnMaximo.Name = "btnMaximo";
            this.btnMaximo.Size = new System.Drawing.Size(145, 23);
            this.btnMaximo.TabIndex = 42;
            this.btnMaximo.Text = "Calcular Maximo";
            this.btnMaximo.UseVisualStyleBackColor = true;
            this.btnMaximo.Click += new System.EventHandler(this.btnMaximo_Click);
            // 
            // btnMinimo
            // 
            this.btnMinimo.Location = new System.Drawing.Point(254, 161);
            this.btnMinimo.Name = "btnMinimo";
            this.btnMinimo.Size = new System.Drawing.Size(145, 23);
            this.btnMinimo.TabIndex = 43;
            this.btnMinimo.Text = "Calcular Minimo";
            this.btnMinimo.UseVisualStyleBackColor = true;
            this.btnMinimo.Click += new System.EventHandler(this.btnMinimo_Click);
            // 
            // lbMaximo
            // 
            this.lbMaximo.AutoSize = true;
            this.lbMaximo.Location = new System.Drawing.Point(115, 129);
            this.lbMaximo.Name = "lbMaximo";
            this.lbMaximo.Size = new System.Drawing.Size(0, 13);
            this.lbMaximo.TabIndex = 44;
            // 
            // lbMinimo
            // 
            this.lbMinimo.AutoSize = true;
            this.lbMinimo.Location = new System.Drawing.Point(115, 171);
            this.lbMinimo.Name = "lbMinimo";
            this.lbMinimo.Size = new System.Drawing.Size(0, 13);
            this.lbMinimo.TabIndex = 45;
            // 
            // FormPrncipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.lbMinimo);
            this.Controls.Add(this.lbMaximo);
            this.Controls.Add(this.btnMinimo);
            this.Controls.Add(this.btnMaximo);
            this.Controls.Add(this.Minimo);
            this.Controls.Add(this.Maximo);
            this.Controls.Add(this.btnMayoresAlPromedio);
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
            this.Name = "FormPrncipal";
            this.Text = "Ejemplo5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbResultadoBusqueda;
        private System.Windows.Forms.Button btnListarOrdenado;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Button btnCalcularPromedio;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Label lb_promedio;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.Button btnMayoresAlPromedio;
        private System.Windows.Forms.Label Maximo;
        private System.Windows.Forms.Label Minimo;
        private System.Windows.Forms.Button btnMaximo;
        private System.Windows.Forms.Button btnMinimo;
        private System.Windows.Forms.Label lbMaximo;
        private System.Windows.Forms.Label lbMinimo;
    }
}

