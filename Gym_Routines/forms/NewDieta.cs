using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Linq;

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

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            /*
            if (String.IsNullOrEmpty(textBox1Calories.Text) || String.IsNullOrEmpty(textBox1Fats.Text) ||
                String.IsNullOrEmpty(textBox1Food.Text) || String.IsNullOrEmpty(textBox1Hydrates.Text) ||
                String.IsNullOrEmpty(textBox1Proteins.Text) || String.IsNullOrEmpty(textBox2Calories.Text) ||
                String.IsNullOrEmpty(textBox2Fats.Text) || String.IsNullOrEmpty(textBox2Food.Text) ||
                String.IsNullOrEmpty(textBox2Hydrates.Text) || String.IsNullOrEmpty(textBox2Proteins.Text) ||
                String.IsNullOrEmpty(textBox3Calories.Text) || String.IsNullOrEmpty(textBox3Fats.Text) ||
                String.IsNullOrEmpty(textBox3Food.Text) || String.IsNullOrEmpty(textBox3Hydrates.Text) ||
                String.IsNullOrEmpty(textBox3Proteins.Text) || String.IsNullOrEmpty(textBox4Calories.Text) ||
                String.IsNullOrEmpty(textBox4Fats.Text) || String.IsNullOrEmpty(textBox4Food.Text) ||
                String.IsNullOrEmpty(textBox4Hydrates.Text) || String.IsNullOrEmpty(textBox4Proteins.Text) ||
                String.IsNullOrEmpty(textBox5Calories.Text) || String.IsNullOrEmpty(textBox5Fats.Text) ||
                String.IsNullOrEmpty(textBox5Food.Text) || String.IsNullOrEmpty(textBox5Hydrates.Text) ||
                String.IsNullOrEmpty(textBox5Proteins.Text) || String.IsNullOrEmpty(textBoxType.Text))
            {
                textBoxInfo.Text = "Fill in all fields";
                return false;
            }
            else
                return true;
            */
        }
        private bool isNumeric()
        {
            foreach (var textBox in this.Controls.OfType<TextBox>())
            {
                double num;
                if (!double.TryParse(textBox.Text, out num) && textBox != textBoxInfo && 
                    textBox != textBoxType && textBox != textBox1Food && textBox != textBox2Food &&
                    textBox != textBox3Food && textBox != textBox4Food && textBox != textBox5Food)
                {
                    textBoxInfo.Text = "Food macros have to be numerical";
                    return false;
                }
            }
            return true;
        }
        private bool isWord()
        {
            foreach (var textBox in this.Controls.OfType<TextBox>())
            {
                double num;
                if (double.TryParse(textBox.Text, out num) &&
                    textBox == textBoxType && textBox == textBox1Food && textBox == textBox2Food &&
                    textBox == textBox3Food && textBox == textBox4Food && textBox == textBox5Food)
                {
                    textBoxInfo.Text = "The name of the food must be words";
                    return false;
                }
            }
            return true;
        }
        private bool checks()
        {
            if (!isFill())
                return false;

            if (!isNumeric())
                return false;

            if (!isWord())
                return false;

            return true;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(checks())
                writeDietas();
            /*
            Thread.Sleep(1000);
            this.Hide();
            */
        }
    }
}
