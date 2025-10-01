namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            mtbtMatricula.Clear();
            txtApellidos.Clear();

            cmbSexo.SelectedIndex = 0;
            cmbMateria.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombres.Text))
            {
                MessageBox.Show("El nombre es requerido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                MessageBox.Show("El apellido es requerido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(mtbtMatricula.Text))
            {
                MessageBox.Show("La matricula es requerida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbSexo.SelectedIndex < 0)
            {
                MessageBox.Show("El sexo es requerido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbMateria.SelectedIndex < 0)
            {
                MessageBox.Show("La materia es requerida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvEstudiantes.Rows.Add(mtbtMatricula.Text, txtNombres.Text, txtApellidos.Text, cmbSexo.SelectedItem.ToString(), cmbMateria.SelectedItem.ToString());

            this.btnLimpiar_Click(sender, e);
        }
    }
}
