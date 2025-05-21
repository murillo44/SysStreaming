namespace UI
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
            groupBox1 = new GroupBox();
            btnCargar = new Button();
            txtCalificacion = new TextBox();
            label6 = new Label();
            txtDuracion = new TextBox();
            label5 = new Label();
            txtAñoLanzamiento = new TextBox();
            label4 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            comboCategoria = new ComboBox();
            label2 = new Label();
            txtTitulo = new TextBox();
            label1 = new Label();
            dgvPeliculas = new DataGridView();
            groupBox2 = new GroupBox();
            btnEliminar = new Button();
            txtIdEliminar = new TextBox();
            label7 = new Label();
            groupBox3 = new GroupBox();
            txtNuevaCalificacion = new TextBox();
            label9 = new Label();
            btnModificar = new Button();
            txtIdModificar = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCargar);
            groupBox1.Controls.Add(txtCalificacion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDuracion);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAñoLanzamiento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboCategoria);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(27, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 522);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "NUEVA PELICULA";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(149, 467);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(135, 34);
            btnCargar.TabIndex = 12;
            btnCargar.Text = "CARGAR";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Location = new Point(21, 409);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(263, 27);
            txtCalificacion.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 386);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 10;
            label6.Text = "Calificación (1 al 5):";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(21, 340);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(263, 27);
            txtDuracion.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 317);
            label5.Name = "label5";
            label5.Size = new Size(149, 20);
            label5.TabIndex = 8;
            label5.Text = "Duracion (en horas):";
            // 
            // txtAñoLanzamiento
            // 
            txtAñoLanzamiento.Location = new Point(21, 269);
            txtAñoLanzamiento.Name = "txtAñoLanzamiento";
            txtAñoLanzamiento.Size = new Size(263, 27);
            txtAñoLanzamiento.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 246);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 6;
            label4.Text = "Año de lanzamiento:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(21, 205);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(263, 27);
            txtDescripcion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 182);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 4;
            label3.Text = "Descripcion:";
            // 
            // comboCategoria
            // 
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Location = new Point(21, 74);
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(263, 28);
            comboCategoria.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 51);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Categoría:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(21, 138);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(263, 27);
            txtTitulo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 115);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Título:";
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPeliculas.BackgroundColor = SystemColors.ActiveCaption;
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliculas.Location = new Point(392, 25);
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.Size = new Size(590, 343);
            dgvPeliculas.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(txtIdEliminar);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(392, 386);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(289, 161);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "ELIMINAR PELICULA";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(130, 106);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(135, 34);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(23, 59);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.Size = new Size(242, 27);
            txtIdEliminar.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 36);
            label7.Name = "label7";
            label7.Size = new Size(28, 20);
            label7.TabIndex = 0;
            label7.Text = "ID:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtNuevaCalificacion);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(btnModificar);
            groupBox3.Controls.Add(txtIdModificar);
            groupBox3.Controls.Add(label8);
            groupBox3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(693, 386);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(289, 161);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "MODIFICAR CALIFICACION";
            // 
            // txtNuevaCalificacion
            // 
            txtNuevaCalificacion.Location = new Point(168, 67);
            txtNuevaCalificacion.Name = "txtNuevaCalificacion";
            txtNuevaCalificacion.Size = new Size(97, 27);
            txtNuevaCalificacion.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 70);
            label9.Name = "label9";
            label9.Size = new Size(138, 20);
            label9.TabIndex = 14;
            label9.Text = "Nueva calificación:";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(130, 106);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(135, 34);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtIdModificar
            // 
            txtIdModificar.Location = new Point(77, 29);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(188, 27);
            txtIdModificar.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 32);
            label8.Name = "label8";
            label8.Size = new Size(28, 20);
            label8.TabIndex = 0;
            label8.Text = "ID:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 571);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(dgvPeliculas);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "UAI STREAMING";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox txtTitulo;
        private Button button1;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private TextBox txtCalificacion;
        private TextBox textBox3;
        private Label label4;
        private TextBox txtDuracion;
        private TextBox textBox2;
        private Label label3;
        private TextBox txtAñoLanzamiento;
        private ComboBox comboCategoria;
        private TextBox txtDescripcion;
        private Button btnCargar;
        private DataGridView dgvPeliculas;
        private GroupBox groupBox2;
        private Button btnEliminar;
        private TextBox txtIdEliminar;
        private Label label7;
        private GroupBox groupBox3;
        private TextBox txtNuevaCalificacion;
        private Label label9;
        private Button btnModificar;
        private TextBox txtIdModificar;
        private Label label8;
    }
}
