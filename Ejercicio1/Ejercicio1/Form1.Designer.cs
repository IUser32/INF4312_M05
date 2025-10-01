namespace Ejercicio1
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
            dgvEstudiantes = new DataGridView();
            Matricula = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Materia = new DataGridViewTextBoxColumn();
            lblName = new Label();
            lblNombres = new Label();
            txtNombres = new TextBox();
            lblApellidos = new Label();
            txtApellidos = new TextBox();
            lblMateria = new Label();
            lblSexo = new Label();
            cmbSexo = new ComboBox();
            cmbMateria = new ComboBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            mtbtMatricula = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.AllowUserToAddRows = false;
            dgvEstudiantes.AllowUserToDeleteRows = false;
            dgvEstudiantes.AllowUserToOrderColumns = true;
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Columns.AddRange(new DataGridViewColumn[] { Matricula, Nombres, Apellidos, Sexo, Materia });
            dgvEstudiantes.Location = new Point(40, 308);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.RowHeadersWidth = 102;
            dgvEstudiantes.Size = new Size(1360, 375);
            dgvEstudiantes.TabIndex = 0;
            // 
            // Matricula
            // 
            Matricula.HeaderText = "Matricula";
            Matricula.MinimumWidth = 12;
            Matricula.Name = "Matricula";
            Matricula.ReadOnly = true;
            Matricula.Width = 250;
            // 
            // Nombres
            // 
            Nombres.HeaderText = "Nombres";
            Nombres.MinimumWidth = 12;
            Nombres.Name = "Nombres";
            Nombres.ReadOnly = true;
            Nombres.Width = 250;
            // 
            // Apellidos
            // 
            Apellidos.HeaderText = "Apellidos";
            Apellidos.MinimumWidth = 12;
            Apellidos.Name = "Apellidos";
            Apellidos.ReadOnly = true;
            Apellidos.Width = 250;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.MinimumWidth = 12;
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            Sexo.Width = 250;
            // 
            // Materia
            // 
            Materia.HeaderText = "Materia";
            Materia.MinimumWidth = 12;
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            Materia.Width = 250;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(38, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(140, 41);
            lblName.TabIndex = 2;
            lblName.Text = "Matricula";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(433, 25);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(141, 41);
            lblNombres.TabIndex = 4;
            lblNombres.Text = "Nombres";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(433, 69);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(378, 47);
            txtNombres.TabIndex = 3;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(826, 25);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(141, 41);
            lblApellidos.TabIndex = 6;
            lblApellidos.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(826, 69);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(420, 47);
            txtApellidos.TabIndex = 5;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(433, 133);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(118, 41);
            lblMateria.TabIndex = 8;
            lblMateria.Text = "Materia";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(38, 133);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(82, 41);
            lblSexo.TabIndex = 7;
            lblSexo.Text = "Sexo";
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "", "Masculino", "Femenina" });
            cmbSexo.Location = new Point(38, 177);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(378, 49);
            cmbSexo.TabIndex = 9;
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Items.AddRange(new object[] { "", "INF 4312", "INF 4311", "INF 4313", "INF 4319" });
            cmbMateria.Location = new Point(433, 177);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(378, 49);
            cmbMateria.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(1047, 163);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(199, 75);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(826, 163);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(204, 75);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // mtbtMatricula
            // 
            mtbtMatricula.Location = new Point(38, 69);
            mtbtMatricula.Mask = "SO-0000-0000";
            mtbtMatricula.Name = "mtbtMatricula";
            mtbtMatricula.Size = new Size(378, 47);
            mtbtMatricula.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 704);
            Controls.Add(mtbtMatricula);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbMateria);
            Controls.Add(cmbSexo);
            Controls.Add(lblMateria);
            Controls.Add(lblSexo);
            Controls.Add(lblApellidos);
            Controls.Add(txtApellidos);
            Controls.Add(lblNombres);
            Controls.Add(txtNombres);
            Controls.Add(lblName);
            Controls.Add(dgvEstudiantes);
            Name = "Form1";
            Text = "Formulario 1";
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEstudiantes;
        private DataGridViewTextBoxColumn Matricula;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn Materia;
        private Label lblName;
        private Label lblNombres;
        private TextBox txtNombres;
        private Label lblApellidos;
        private TextBox txtApellidos;
        private Label lblMateria;
        private Label lblSexo;
        private ComboBox cmbSexo;
        private ComboBox cmbMateria;
        private Button btnGuardar;
        private Button btnLimpiar;
        private MaskedTextBox mtbtMatricula;
    }
}
