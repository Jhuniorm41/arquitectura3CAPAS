namespace Login
{
    partial class PDetalle
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
            this.comboRepuesto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboServicio = new System.Windows.Forms.ComboBox();
            this.btnServicio = new System.Windows.Forms.Button();
            this.btnRepuesto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(712, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboRepuesto
            // 
            this.comboRepuesto.FormattingEnabled = true;
            this.comboRepuesto.Location = new System.Drawing.Point(478, 54);
            this.comboRepuesto.Name = "comboRepuesto";
            this.comboRepuesto.Size = new System.Drawing.Size(165, 21);
            this.comboRepuesto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Repuesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Servicio";
            // 
            // comboServicio
            // 
            this.comboServicio.FormattingEnabled = true;
            this.comboServicio.Location = new System.Drawing.Point(81, 52);
            this.comboServicio.Name = "comboServicio";
            this.comboServicio.Size = new System.Drawing.Size(144, 21);
            this.comboServicio.TabIndex = 4;
            // 
            // btnServicio
            // 
            this.btnServicio.Location = new System.Drawing.Point(240, 52);
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.Size = new System.Drawing.Size(109, 23);
            this.btnServicio.TabIndex = 5;
            this.btnServicio.Text = "Agregar Servicio";
            this.btnServicio.UseVisualStyleBackColor = true;
            this.btnServicio.Click += new System.EventHandler(this.btnServicio_Click);
            // 
            // btnRepuesto
            // 
            this.btnRepuesto.Location = new System.Drawing.Point(665, 52);
            this.btnRepuesto.Name = "btnRepuesto";
            this.btnRepuesto.Size = new System.Drawing.Size(107, 23);
            this.btnRepuesto.TabIndex = 6;
            this.btnRepuesto.Text = "Agregar Repuesto";
            this.btnRepuesto.UseVisualStyleBackColor = true;
            this.btnRepuesto.Click += new System.EventHandler(this.btnRepuesto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DETALLE DE REPARACION";
            // 
            // PDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 356);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRepuesto);
            this.Controls.Add(this.btnServicio);
            this.Controls.Add(this.comboServicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboRepuesto);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDetalle";
            this.Load += new System.EventHandler(this.PDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboRepuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboServicio;
        private System.Windows.Forms.Button btnServicio;
        private System.Windows.Forms.Button btnRepuesto;
        private System.Windows.Forms.Label label3;
    }
}