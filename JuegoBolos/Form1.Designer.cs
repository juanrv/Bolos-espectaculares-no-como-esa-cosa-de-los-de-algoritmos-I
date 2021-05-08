
namespace JuegoBolos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TablaJugador1 = new System.Windows.Forms.DataGridView();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lanzamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntuacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextJugador1 = new System.Windows.Forms.TextBox();
            this.TextJugador2 = new System.Windows.Forms.TextBox();
            this.BtnJugar = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.TablaJugador2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaJugador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaJugador2)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaJugador1
            // 
            this.TablaJugador1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaJugador1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Turno,
            this.Lanzamiento,
            this.Puntuacion,
            this.Total});
            this.TablaJugador1.Location = new System.Drawing.Point(35, 187);
            this.TablaJugador1.Name = "TablaJugador1";
            this.TablaJugador1.RowTemplate.Height = 25;
            this.TablaJugador1.Size = new System.Drawing.Size(483, 516);
            this.TablaJugador1.TabIndex = 0;
            // 
            // Turno
            // 
            this.Turno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            this.Turno.ReadOnly = true;
            // 
            // Lanzamiento
            // 
            this.Lanzamiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Lanzamiento.HeaderText = "Lanzamiento";
            this.Lanzamiento.Name = "Lanzamiento";
            this.Lanzamiento.ReadOnly = true;
            // 
            // Puntuacion
            // 
            this.Puntuacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Puntuacion.HeaderText = "Pinos Tirados";
            this.Puntuacion.Name = "Puntuacion";
            this.Puntuacion.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // TextJugador1
            // 
            this.TextJugador1.Location = new System.Drawing.Point(125, 128);
            this.TextJugador1.Name = "TextJugador1";
            this.TextJugador1.Size = new System.Drawing.Size(289, 23);
            this.TextJugador1.TabIndex = 2;
            // 
            // TextJugador2
            // 
            this.TextJugador2.Location = new System.Drawing.Point(742, 128);
            this.TextJugador2.Name = "TextJugador2";
            this.TextJugador2.Size = new System.Drawing.Size(289, 23);
            this.TextJugador2.TabIndex = 3;
            // 
            // BtnJugar
            // 
            this.BtnJugar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnJugar.Location = new System.Drawing.Point(545, 110);
            this.BtnJugar.Name = "BtnJugar";
            this.BtnJugar.Size = new System.Drawing.Size(95, 51);
            this.BtnJugar.TabIndex = 5;
            this.BtnJugar.Text = "¡Tirar!";
            this.BtnJugar.UseVisualStyleBackColor = true;
            this.BtnJugar.Click += new System.EventHandler(this.BtnJugar_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.Location = new System.Drawing.Point(436, 49);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(301, 30);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Ingrese Nombres de Jugadores";
            // 
            // TablaJugador2
            // 
            this.TablaJugador2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaJugador2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.TablaJugador2.Location = new System.Drawing.Point(660, 187);
            this.TablaJugador2.Name = "TablaJugador2";
            this.TablaJugador2.RowTemplate.Height = 25;
            this.TablaJugador2.Size = new System.Drawing.Size(471, 516);
            this.TablaJugador2.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Turno";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Lanzamiento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Pinos Tirados";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Total";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLimpiar.Location = new System.Drawing.Point(545, 464);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(95, 51);
            this.BtnLimpiar.TabIndex = 8;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 715);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TablaJugador2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BtnJugar);
            this.Controls.Add(this.TextJugador2);
            this.Controls.Add(this.TextJugador1);
            this.Controls.Add(this.TablaJugador1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TablaJugador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaJugador2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaJugador1;
        private System.Windows.Forms.TextBox TextJugador1;
        private System.Windows.Forms.TextBox TextJugador2;
        private System.Windows.Forms.Button BtnJugar;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridView TablaJugador2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lanzamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntuacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}

