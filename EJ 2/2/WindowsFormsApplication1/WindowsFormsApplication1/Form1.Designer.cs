namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insertar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(646, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar);
            // 
            // insertar
            // 
            this.insertar.BackColor = System.Drawing.Color.LightCyan;
            this.insertar.Location = new System.Drawing.Point(36, 248);
            this.insertar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(76, 28);
            this.insertar.TabIndex = 1;
            this.insertar.Text = "Inertar";
            this.insertar.UseVisualStyleBackColor = false;
            this.insertar.Click += new System.EventHandler(this.insertar_Click);
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.Color.LightCyan;
            this.editar.Location = new System.Drawing.Point(141, 248);
            this.editar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(76, 28);
            this.editar.TabIndex = 2;
            this.editar.Text = "Modificar";
            this.editar.UseVisualStyleBackColor = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.LightCyan;
            this.eliminar.Location = new System.Drawing.Point(247, 248);
            this.eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(76, 28);
            this.eliminar.TabIndex = 3;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // actualizar
            // 
            this.actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.actualizar.Location = new System.Drawing.Point(9, 10);
            this.actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(85, 28);
            this.actualizar.TabIndex = 4;
            this.actualizar.Text = "Refrescar";
            this.actualizar.UseVisualStyleBackColor = false;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(664, 298);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.insertar);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insertar;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button actualizar;
    }
}

