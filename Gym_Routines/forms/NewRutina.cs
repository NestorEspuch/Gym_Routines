using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace Gym_Routines.forms
{
    public partial class NewRutina : Form
    {
        bool movLogin = false;


        public NewRutina()
        {
            InitializeComponent();
            textBoxInfo.TabStop = false;
        }

        #region "Checks"
        private bool isFill()
        {
            foreach (var textBox in this.Controls.OfType<TextBox>())
            {
                if (String.IsNullOrEmpty(textBox.Text) && textBox != textBoxInfo)
                {
                    textBoxInfo.Text = "Fill in all fields";
                    return false;
                }
            }
            return true;
        }

        private bool checks()
        {
            if (!isFill())
                return false;

            if (!isWord())
                return false;

            if (!isNumeric())
                return false;

            return true;
        }

        private bool isWord()
        {
            foreach (var textBox in this.Controls.OfType<TextBox>())
            {
                double num;
                if (double.TryParse(textBox.Text, out num) && textBox != textBoxInfo &&
                    textBox != textBoxTrainingDays)
                {
                    textBoxInfo.Text = "Fields must contain text";
                    return false;
                }
            }
            return true;
        }

        private bool isNumeric()
        {
            int num;
            if (!int.TryParse(textBoxTrainingDays.Text, out num))
            {
                textBoxInfo.Text = "Training days must be numerical";
                return false;
            }
            else
                return true;
        }

        #endregion

        private void writeRutinas()
        {
            try
            {
                StreamWriter file = File.AppendText("../../../data/rutinas.txt");

                file.Write("\n"+textBox1Exercise.Text+","+textBox1Dificulty.Text+","+textBox1Muscle.Text+","+
                    textBox2Exercise.Text+","+textBox2Dificulty.Text+","+textBox2Muscle.Text+","+
                    textBox3Exercise.Text+","+textBox3Dificulty.Text+","+textBox3Muscle.Text+","+
                    textBox4Exercise.Text+","+textBox4Dificulty.Text+","+textBox4Muscle.Text+","+
                    textBox5Exercise.Text+","+textBox5Dificulty.Text+","+textBox5Muscle.Text+","+
                    textBoxType.Text+","+textBoxTrainingDays.Text);

                file.Close();
                textBoxInfo.Text = "Properly stored diet";
            }
            catch (IOException error)
            {
                Console.WriteLine("Error de escritura en rutinas.txt: " + error.Message);
                textBoxInfo.Text = "Error";
            }
        }

        #region "Styles"

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(checks())
                writeRutinas();
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
