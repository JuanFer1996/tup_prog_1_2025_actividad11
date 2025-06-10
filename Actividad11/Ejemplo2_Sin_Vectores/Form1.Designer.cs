namespace Ejemplo2_Sin_Vectores
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
            this.lb_valor = new System.Windows.Forms.Label();
            this.lb_promedio = new System.Windows.Forms.Label();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.btnCalcularPromedio = new System.Windows.Forms.Button();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Location = new System.Drawing.Point(82, 46);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(31, 13);
            this.lb_valor.TabIndex = 0;
            this.lb_valor.Text = "Valor";
            // 
            // lb_promedio
            // 
            this.lb_promedio.AutoSize = true;
            this.lb_promedio.Location = new System.Drawing.Point(69, 123);
            this.lb_promedio.Name = "lb_promedio";
            this.lb_promedio.Size = new System.Drawing.Size(60, 13);
            this.lb_promedio.TabIndex = 1;
            this.lb_promedio.Text = "Promedio : ";
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(685, 46);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btRegistrar.TabIndex = 2;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // btnCalcularPromedio
            // 
            this.btnCalcularPromedio.Location = new System.Drawing.Point(685, 123);
            this.btnCalcularPromedio.Name = "btnCalcularPromedio";
            this.btnCalcularPromedio.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularPromedio.TabIndex = 3;
            this.btnCalcularPromedio.Text = "Calcular Promedio";
            this.btnCalcularPromedio.UseVisualStyleBackColor = true;
            this.btnCalcularPromedio.Click += new System.EventHandler(this.btnCalcularPromedio_Click);
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(293, 48);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 20);
            this.tbValor.TabIndex = 4;
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(191, 257);
            this.tbResultado.Multiline = true;
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(395, 104);
            this.tbResultado.TabIndex = 6;
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(293, 132);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(63, 13);
            this.lbResultado.TabIndex = 7;
            this.lbResultado.Text = "lbResultado";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.btnCalcularPromedio);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.lb_promedio);
            this.Controls.Add(this.lb_valor);
            this.Name = "FormPrincipal";
            this.Text = "SIN VECTOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.Label lb_promedio;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Button btnCalcularPromedio;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Label lbResultado;
    }
}

