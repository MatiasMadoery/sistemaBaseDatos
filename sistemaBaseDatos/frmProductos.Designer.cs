namespace sistemaBaseDatos
{
    partial class frmProductos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.txtBuscarPorId = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBuscarPorMarca = new System.Windows.Forms.TextBox();
            this.btnBuscarMarca = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarDescripcion = new System.Windows.Forms.Button();
            this.txtBuscarPorDescripcion = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarId);
            this.groupBox1.Controls.Add(this.txtBuscarPorId);
            this.groupBox1.Location = new System.Drawing.Point(154, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR POR ID";
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.Location = new System.Drawing.Point(419, 39);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(97, 30);
            this.btnBuscarId.TabIndex = 3;
            this.btnBuscarId.Text = "BUSCAR";
            this.btnBuscarId.UseVisualStyleBackColor = true;
            // 
            // txtBuscarPorId
            // 
            this.txtBuscarPorId.Location = new System.Drawing.Point(58, 43);
            this.txtBuscarPorId.Name = "txtBuscarPorId";
            this.txtBuscarPorId.Size = new System.Drawing.Size(314, 22);
            this.txtBuscarPorId.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBuscarPorMarca);
            this.groupBox3.Controls.Add(this.btnBuscarMarca);
            this.groupBox3.Location = new System.Drawing.Point(41, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 127);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BUSCAR POR MARCA";
            // 
            // txtBuscarPorMarca
            // 
            this.txtBuscarPorMarca.Location = new System.Drawing.Point(26, 41);
            this.txtBuscarPorMarca.Name = "txtBuscarPorMarca";
            this.txtBuscarPorMarca.Size = new System.Drawing.Size(262, 22);
            this.txtBuscarPorMarca.TabIndex = 2;
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.Location = new System.Drawing.Point(101, 81);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.Size = new System.Drawing.Size(97, 30);
            this.btnBuscarMarca.TabIndex = 1;
            this.btnBuscarMarca.Text = "BUSCAR";
            this.btnBuscarMarca.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarDescripcion);
            this.groupBox2.Controls.Add(this.txtBuscarPorDescripcion);
            this.groupBox2.Location = new System.Drawing.Point(505, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 127);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSCAR POR DESCRIPCION";
            // 
            // btnBuscarDescripcion
            // 
            this.btnBuscarDescripcion.Location = new System.Drawing.Point(110, 81);
            this.btnBuscarDescripcion.Name = "btnBuscarDescripcion";
            this.btnBuscarDescripcion.Size = new System.Drawing.Size(97, 30);
            this.btnBuscarDescripcion.TabIndex = 4;
            this.btnBuscarDescripcion.Text = "BUSCAR";
            this.btnBuscarDescripcion.UseVisualStyleBackColor = true;
            // 
            // txtBuscarPorDescripcion
            // 
            this.txtBuscarPorDescripcion.Location = new System.Drawing.Point(24, 41);
            this.txtBuscarPorDescripcion.Name = "txtBuscarPorDescripcion";
            this.txtBuscarPorDescripcion.Size = new System.Drawing.Size(262, 22);
            this.txtBuscarPorDescripcion.TabIndex = 3;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(24, 441);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(810, 253);
            this.dgvProductos.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(360, 383);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "BUSCAR TODO";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(175, 716);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(125, 36);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(367, 716);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 36);
            this.button6.TabIndex = 6;
            this.button6.Text = "MODIFICAR";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(553, 716);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 36);
            this.button7.TabIndex = 7;
            this.button7.Text = "ELIMINAR";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 775);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscarMarca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnBuscarId;
        private System.Windows.Forms.TextBox txtBuscarPorId;
        private System.Windows.Forms.TextBox txtBuscarPorMarca;
        private System.Windows.Forms.Button btnBuscarDescripcion;
        private System.Windows.Forms.TextBox txtBuscarPorDescripcion;
        private System.Windows.Forms.Button button7;
    }
}

