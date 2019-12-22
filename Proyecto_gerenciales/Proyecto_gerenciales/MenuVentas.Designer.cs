namespace Proyecto_gerenciales
{
    partial class MenuVentas
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
            if (disposing && (components != null))
            {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGraficaPedidos = new System.Windows.Forms.Button();
            this.btnVerPedidos = new System.Windows.Forms.Button();
            this.btnCrearPedido = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGraficaPedidos);
            this.groupBox1.Controls.Add(this.btnVerPedidos);
            this.groupBox1.Controls.Add(this.btnCrearPedido);
            this.groupBox1.Location = new System.Drawing.Point(15, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos";
            // 
            // btnGraficaPedidos
            // 
            this.btnGraficaPedidos.Location = new System.Drawing.Point(29, 152);
            this.btnGraficaPedidos.Name = "btnGraficaPedidos";
            this.btnGraficaPedidos.Size = new System.Drawing.Size(194, 47);
            this.btnGraficaPedidos.TabIndex = 5;
            this.btnGraficaPedidos.Text = "Grafica de Pedidos";
            this.btnGraficaPedidos.UseVisualStyleBackColor = true;
            this.btnGraficaPedidos.Click += new System.EventHandler(this.btnGraficaPedidos_Click);
            // 
            // btnVerPedidos
            // 
            this.btnVerPedidos.Location = new System.Drawing.Point(29, 99);
            this.btnVerPedidos.Name = "btnVerPedidos";
            this.btnVerPedidos.Size = new System.Drawing.Size(194, 47);
            this.btnVerPedidos.TabIndex = 4;
            this.btnVerPedidos.Text = "Ver Pedidos";
            this.btnVerPedidos.UseVisualStyleBackColor = true;
            this.btnVerPedidos.Click += new System.EventHandler(this.btnVerPedidos_Click);
            // 
            // btnCrearPedido
            // 
            this.btnCrearPedido.Location = new System.Drawing.Point(29, 46);
            this.btnCrearPedido.Name = "btnCrearPedido";
            this.btnCrearPedido.Size = new System.Drawing.Size(193, 47);
            this.btnCrearPedido.TabIndex = 3;
            this.btnCrearPedido.Text = "Crear Pedido";
            this.btnCrearPedido.UseVisualStyleBackColor = true;
            this.btnCrearPedido.Click += new System.EventHandler(this.btnCrearPedido_Click);
            // 
            // MenuVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ventas";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGraficaPedidos;
        private System.Windows.Forms.Button btnVerPedidos;
        private System.Windows.Forms.Button btnCrearPedido;

    }
}