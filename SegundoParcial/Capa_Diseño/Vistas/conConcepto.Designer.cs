namespace Capa_Diseño.Vistas
{
    partial class conConcepto
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
            this.ACTUALIZAR = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ACTUALIZAR
            // 
            this.ACTUALIZAR.BackColor = System.Drawing.Color.Black;
            this.ACTUALIZAR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACTUALIZAR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ACTUALIZAR.Location = new System.Drawing.Point(136, 58);
            this.ACTUALIZAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ACTUALIZAR.Name = "ACTUALIZAR";
            this.ACTUALIZAR.Size = new System.Drawing.Size(84, 27);
            this.ACTUALIZAR.TabIndex = 0;
            this.ACTUALIZAR.Text = "ACTUALIZAR";
            this.ACTUALIZAR.UseVisualStyleBackColor = false;
            this.ACTUALIZAR.Click += new System.EventHandler(this.ACTUALIZAR_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(381, 58);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "SELECCIONAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.nombre,
            this.efecto,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(61, 127);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(494, 167);
            this.dataGridView1.TabIndex = 2;
            // 
            // cod
            // 
            this.cod.HeaderText = "CODIGO";
            this.cod.MinimumWidth = 6;
            this.cod.Name = "cod";
            this.cod.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // efecto
            // 
            this.efecto.HeaderText = "EFECTO";
            this.efecto.MinimumWidth = 6;
            this.efecto.Name = "efecto";
            this.efecto.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "ESTATUS";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 125;
            // 
            // FRM_CONCEPTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ACTUALIZAR);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRM_CONCEPTO";
            this.Text = "Consulta concepto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ACTUALIZAR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn efecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}