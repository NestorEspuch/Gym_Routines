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
                file.WriteLine(textBox1Food+","+textBox1Calories+","+textBox1Proteins+","+textBox1Hydrates+
                    ","+textBox1Fats+","+ textBox2Food + "," + textBox2Calories + "," + textBox2Proteins + 
                    "," + textBox2Hydrates + textBox2Fats+","+ textBox3Food + "," + textBox3Calories + "," + 
                    textBox3Proteins + "," + textBox3Hydrates +","+textBox3Fats+","+
                    textBox4Food + "," + textBox4Calories + "," + textBox4Proteins + "," + textBox4Hydrates +
                    ","+textBox4Fats+","+ textBox5Food + "," + textBox5Calories + "," + textBox5Proteins + 
                    "," + textBox5Hydrates +","+textBox5Fats+","+textBoxType);
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
    }
}
