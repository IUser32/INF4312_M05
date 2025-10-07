using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void chbActivar_CheckedChanged(object sender, EventArgs e)
        {
            btnMensaje.Enabled = ((CheckBox)sender).Checked;
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le has dado clic al botón.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
