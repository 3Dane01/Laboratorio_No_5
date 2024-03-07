namespace Laboratorio_No_5
{
    partial class Form1
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
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.dataGridViewAsistencia = new System.Windows.Forms.DataGridView();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.dataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.buttonReporte = new System.Windows.Forms.Button();
            this.comboBoxEmpleados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(12, 29);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.RowHeadersWidth = 51;
            this.dataGridViewEmpleados.RowTemplate.Height = 24;
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(450, 385);
            this.dataGridViewEmpleados.TabIndex = 0;
            // 
            // dataGridViewAsistencia
            // 
            this.dataGridViewAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsistencia.Location = new System.Drawing.Point(513, 29);
            this.dataGridViewAsistencia.Name = "dataGridViewAsistencia";
            this.dataGridViewAsistencia.RowHeadersWidth = 51;
            this.dataGridViewAsistencia.RowTemplate.Height = 24;
            this.dataGridViewAsistencia.Size = new System.Drawing.Size(450, 385);
            this.dataGridViewAsistencia.TabIndex = 1;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(513, 442);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(123, 47);
            this.buttonCargar.TabIndex = 2;
            this.buttonCargar.Text = "Cargar Datos";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // dataGridViewReporte
            // 
            this.dataGridViewReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReporte.Location = new System.Drawing.Point(1015, 29);
            this.dataGridViewReporte.Name = "dataGridViewReporte";
            this.dataGridViewReporte.RowHeadersWidth = 51;
            this.dataGridViewReporte.RowTemplate.Height = 24;
            this.dataGridViewReporte.Size = new System.Drawing.Size(450, 385);
            this.dataGridViewReporte.TabIndex = 3;
            // 
            // buttonReporte
            // 
            this.buttonReporte.Location = new System.Drawing.Point(1015, 430);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(123, 47);
            this.buttonReporte.TabIndex = 4;
            this.buttonReporte.Text = "Calcular Sueldo";
            this.buttonReporte.UseVisualStyleBackColor = true;
            this.buttonReporte.Click += new System.EventHandler(this.buttonReporte_Click);
            // 
            // comboBoxEmpleados
            // 
            this.comboBoxEmpleados.FormattingEnabled = true;
            this.comboBoxEmpleados.Location = new System.Drawing.Point(12, 442);
            this.comboBoxEmpleados.Name = "comboBoxEmpleados";
            this.comboBoxEmpleados.Size = new System.Drawing.Size(349, 24);
            this.comboBoxEmpleados.TabIndex = 5;
            this.comboBoxEmpleados.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpleado_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 658);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEmpleados);
            this.Controls.Add(this.buttonReporte);
            this.Controls.Add(this.dataGridViewReporte);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.dataGridViewAsistencia);
            this.Controls.Add(this.dataGridViewEmpleados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.DataGridView dataGridViewAsistencia;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.DataGridView dataGridViewReporte;
        private System.Windows.Forms.Button buttonReporte;
        private System.Windows.Forms.ComboBox comboBoxEmpleados;
        private System.Windows.Forms.Label label1;
    }
}

