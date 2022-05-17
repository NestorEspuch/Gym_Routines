using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Threading;

namespace Gym_Routines
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void saveUser()
        {
            try
            {
                StreamWriter writer = File.AppendText("../../../data/users.txt");
                writer.WriteLineAsync(textBoxName.Text+";"+textBoxUser.Text+";"+
                    textBoxPwd.Text+";"+textBoxEmail.Text);
                
                writer.Close();
                textBoxInfo.Text = "USUARIO CREADO";
            }
            catch (IOException error)
            {
                textBoxInfo.Text = "ERROR";
                Console.WriteLine("Error de escritura en archivo users.txt: " + error.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            saveUser();
            Thread.Sleep(1900);
            this.Hide();
        }
    }
}
