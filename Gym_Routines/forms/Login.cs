using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Gym_Routines
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            if (File.Exists("../../../data/rememberUser.txt"))
            {
                fillUser();
            }
            boxInfo.TabStop = false;
        }
        private void fillUser()
        {
            try
            {
                StreamReader file = new StreamReader("../../../data/rememberUser.txt");
                string line = file.ReadLine();
                if(line != null)
                {
                    string[] split = line.Split(';');
                    boxUser.Text = split[0];
                    boxPwd.Text = split[1];
                }
                file.Close();
            }
            catch(IOException error)
            {
                Console.WriteLine("Error de lectura de rememberUser.txt: "+error.Message);
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            if(movLogin)
            {
                this.Location = Cursor.Position;
            }
        }

        private void panelTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            movLogin = false;
        }

        private void boxPwd_TextChanged(object sender, EventArgs e)
        {
            boxPwd.UseSystemPasswordChar = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register registro = new Register();
            registro.Show();
        }
        private List<User> readUsers()
        {
            List<User> list = new List<User>();
            try
            {
                StreamReader file = new StreamReader("../../../data/users.txt");
                string line = file.ReadLine();
                while(line != null)
                {
                    string[] split = line.Split(';');
                    list.Add(new User(split[0],split[1],split[2],split[3]));
                    line = file.ReadLine();
                }
                file.Close();
                return list;
            }
            catch(IOException error)
            {
                Console.WriteLine("Error de lectura users.txt: "+error.Message);
                return null;
            }
        }
        private bool checkUser(List<User> listUsers)
        {
            bool be = false;
            foreach(User u in listUsers)
            {
                if(u.GetUser().Equals(boxUser.Text) && u.GetPwd().Equals(boxPwd.Text))
                {
                    be = true;
                }
            }
            return be;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();

            if(checkUser(readUsers()))
            {
                this.Hide();
                inicio.Show();
            }
            else
            {
                boxInfo.Text = "User no exist";
                Console.WriteLine("El usuario no se encuentra registrado");
            }
        }
        private void saveRemenberUser()
        {
            try
            {
                StreamWriter writer = new StreamWriter("../../../data/rememberUser.txt");
                writer.Write(boxUser.Text+";"+boxPwd.Text);
                writer.Close();
            }
            catch(IOException error)
            {
                Console.WriteLine("Error al guardar usuario: "+error.Message);
            }
        }
        private void cbRemember_CheckedChanged(object sender, EventArgs e)
        {
            saveRemenberUser();
        }
    }
}
