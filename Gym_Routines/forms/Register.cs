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
using System.Linq;

namespace Gym_Routines
{
    public partial class Register : Form
    {
        bool movLogin = false;

        public Register()
        {
            InitializeComponent();
            boxInfo.TabStop = false;
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

        #region "Chekcs"
        private bool checks()
        {
            if(!isNullBox())
            {
                boxInfo.Text = "Fill in all fields";
                return false;
            }

            if (!isSamePwd())
            {
               boxInfo.Text = "Passwords do not match";
               return false;
            }

            if(!isCorrectEmail())
            {
                boxInfo.Text = "The email address is incorrect";
                return false;
            }

            if (!isCharCorrect())
            {
                boxInfo.Text = "Unwanted characters";
                return false;
            }

            return true;
        }

        private bool isNullBox()
        {
            if (String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(textBoxUser.Text) ||
                String.IsNullOrEmpty(textBoxPwd.Text) || String.IsNullOrEmpty(textBoxRPassword.Text) ||
                String.IsNullOrEmpty(textBoxEmail.Text))
                return false;
            else
                return true;
        }

        private bool isCorrectEmail()
        {
            textBoxEmail.Text = textBoxEmail.Text.Trim();
            if (textBoxEmail.Text.Length < 4)
                return false;

            if(!textBoxEmail.Text.Contains("@"))
                return false;

            int positionAt = textBoxEmail.Text.IndexOf("@");

            if (positionAt != textBoxEmail.Text.LastIndexOf("@"))
                return false;

            string beforeAt = textBoxEmail.Text.Substring(positionAt);

            if (beforeAt.Length < 4 && !beforeAt.Contains("."))
                return false;

            int positionDot = beforeAt.IndexOf(".");
            string beforeDot = beforeAt.Substring(positionDot);

            if (beforeDot.Contains(".") && beforeDot.Length < 2)
                return false;

            return true;
        }

        private bool isSamePwd()
        {
            if (textBoxPwd.Text.Equals(textBoxRPassword.Text))
                return true;
            else
                return false;
        }

        private bool isCharCorrect()
        {
            string pattern = "^[A-Za-z0-9]+$";
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(pattern);

            foreach (var textBox in this.Controls.OfType<TextBox>())
            {
                if (!regex.IsMatch(textBox.Text) && textBox != boxInfo && textBox != textBoxEmail)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

        private void textBoxPwd_TextChanged(object sender, EventArgs e)
        {
            textBoxPwd.UseSystemPasswordChar = true;
        }

        private void textBoxRPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxRPassword.UseSystemPasswordChar = true;
        }

        #region "Styles"
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (checks())
                saveUser();
            /*
             * Thread.Sleep(1900);
             this.Hide();*/
        }

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
        #endregion
    }
}