using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Gym_Routines.forms
{
    public partial class NewDieta : Form
    {
        public NewDieta()
        {
            InitializeComponent();
        }
        private void writeDietas()
        {
            try
            {
                StreamWriter file = File.AppendText("../../../data/dietas.txt");
                file.Write("\n"+textBox1Food.Text+","+textBox1Calories.Text+","+textBox1Proteins.Text+","+textBox1Hydrates.Text+
                    ","+textBox1Fats.Text+","+ textBox2Food.Text + "," + textBox2Calories.Text + "," + textBox2Proteins.Text + 
                    "," + textBox2Hydrates.Text + textBox2Fats.Text+","+ textBox3Food.Text + "," + textBox3Calories.Text + "," + 
                    textBox3Proteins.Text + "," + textBox3Hydrates.Text +","+textBox3Fats.Text+","+
                    textBox4Food.Text + "," + textBox4Calories.Text + "," + textBox4Proteins.Text + "," + textBox4Hydrates.Text +
                    ","+textBox4Fats.Text+","+ textBox5Food.Text + "," + textBox5Calories.Text + "," + textBox5Proteins.Text + 
                    "," + textBox5Hydrates.Text +","+textBox5Fats.Text+","+textBoxType.Text);
                file.Close();
                textBoxInfo.Text = "Properly stored diet";
            }
            catch(IOException error)
            {
                Console.WriteLine("Error de escritura en dietas.txt: "+error.Message);
                textBoxInfo.Text = "Error";
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            writeDietas();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
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
    }
}
