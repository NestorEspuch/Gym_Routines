﻿using System;
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
                writer.Write("\n" + textBoxName.Text + ";" + textBoxUser.Text + ";" +
                    textBoxPwd.Text + ";" + textBoxEmail.Text);

                writer.Close();
                boxInfo.Text = "USUARIO CREADO";
            }
            catch (IOException error)
            {
                boxInfo.Text = "ERROR";
                Console.WriteLine("Error de escritura en archivo users.txt: " + error.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (checkPwd() && checkEmail())
            {
                saveUser();
            }
            else
            {
                boxInfo.Text = "Passwords do not match";
            }
            /*
             * Thread.Sleep(1900);
             this.Hide();*/
        }
        private bool checkEmail()
        {
            textBoxEmail.Text = textBoxEmail.Text.Trim();
            if (textBoxEmail.Text.Length < 4)
                return false;

            if(!textBoxEmail.Text.Contains("@"))
                return false;

            int positionAt = textBoxEmail.Text.IndexOf("@");
            string beforeAt = textBoxEmail.Text.Substring(positionAt);

            if (beforeAt.Length < 4 && (!beforeAt.Contains(".") || beforeAt.Contains("@")))
                return false;

            int positionDot = beforeAt.IndexOf(".");
            string beforeDot = beforeAt.Substring(positionDot);

            if (beforeDot.Contains(".") && beforeDot.Length < 2)
                return false;

            return true;
        }

        private bool checkPwd()
        {
            if (textBoxPwd.Text.Equals(textBoxRPassword.Text))
                return true;
            else
                return false;
        }

        private void textBoxPwd_TextChanged(object sender, EventArgs e)
        {
            textBoxPwd.UseSystemPasswordChar = true;
        }

        private void textBoxRPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxRPassword.UseSystemPasswordChar = true;
        }
    }
}
