using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gym_Routines.forms
{
    public partial class NewRutina : Form
    {
        public NewRutina()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool movLogin = false;
        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            movLogin = true;
        }

        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (movLogin)
            {
                this.Location = Cursor.Position;
            }
        }

        private void panelTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            movLogin = false;
        }
    }
}
