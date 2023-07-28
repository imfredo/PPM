namespace WindowsFormsApp1
{
    partial class Risxpert
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Riesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ref,
            this.ID,
            this.Activo,
            this.Riesgo,
            this.TipoRiesgo,
            this.Daño});
            this.dataGridView1.Location = new System.Drawing.Point(129, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // Ref
            // 
            this.Ref.HeaderText = "Ref";
            this.Ref.Name = "Ref";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo/Bien";
            this.Activo.Name = "Activo";
            // 
            // Riesgo
            // 
            this.Riesgo.HeaderText = "Riesgo";
            this.Riesgo.Name = "Riesgo";
            // 
            // TipoRiesgo
            // 
            this.TipoRiesgo.HeaderText = "Tipo de Riesgo";
            this.TipoRiesgo.Name = "TipoRiesgo";
            // 
            // Daño
            // 
            this.Daño.HeaderText = "Daño";
            this.Daño.Name = "Daño";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(30, 165);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(61, 27);
            this.btnGrabar.TabIndex = 4;
            this.btnGrabar.Text = "Guardar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(47, 136);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(27, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Riesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daño;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnAgregar;
    }
}

