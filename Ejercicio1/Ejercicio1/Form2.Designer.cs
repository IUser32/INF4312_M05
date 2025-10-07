namespace Ejercicio1
{
    partial class Form2
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
            chbActivar = new CheckBox();
            lblActivarBoton = new Label();
            btnMensaje = new Button();
            SuspendLayout();
            // 
            // chbActivar
            // 
            chbActivar.AutoSize = true;
            chbActivar.Location = new Point(23, 66);
            chbActivar.Name = "chbActivar";
            chbActivar.Size = new Size(145, 45);
            chbActivar.TabIndex = 0;
            chbActivar.Text = "Activar";
            chbActivar.UseVisualStyleBackColor = true;
            chbActivar.CheckedChanged += chbActivar_CheckedChanged;
            // 
            // lblActivarBoton
            // 
            lblActivarBoton.AutoSize = true;
            lblActivarBoton.Location = new Point(23, 9);
            lblActivarBoton.Name = "lblActivarBoton";
            lblActivarBoton.Size = new Size(196, 41);
            lblActivarBoton.TabIndex = 1;
            lblActivarBoton.Text = "Activar boton";
            // 
            // btnMensaje
            // 
            btnMensaje.Enabled = false;
            btnMensaje.Location = new Point(276, 58);
            btnMensaje.Name = "btnMensaje";
            btnMensaje.Size = new Size(188, 58);
            btnMensaje.TabIndex = 2;
            btnMensaje.Text = "Mensaje";
            btnMensaje.UseVisualStyleBackColor = true;
            btnMensaje.Click += btnMensaje_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(576, 192);
            Controls.Add(btnMensaje);
            Controls.Add(lblActivarBoton);
            Controls.Add(chbActivar);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chbActivar;
        private Label lblActivarBoton;
        private Button btnMensaje;
    }
}