using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Gym_Routines
{
    public partial class Inicio : Form
    {
        public void MostrarDietaHipertrofia(List<Dieta> dietas)
        {
            List<Dieta> lista = new List<Dieta>();
            foreach(Dieta d in dietas)
            {
                if(d.GetTipo() == "Hipertrofia")
                {
                    lista.Add(d);
                }
            }
            listBoxContenido.DataSource = lista;
        }
        public void MostrarDietaDefinicion(List<Dieta> dietas)
        {
            List<Dieta> lista = new List<Dieta>();
            foreach (Dieta d in dietas)
            {
                if (d.GetTipo() == "Definicion")
                {
                    lista.Add(d);
                }
            }
            listBoxContenido.DataSource = lista;
        }
        public void MostrarRutinaHipertrofia(List<Rutina> rutinas)
        {
            string result = "";
            foreach (Rutina r in rutinas)
            {
                if (r.GetTipo() == "Hipertrofia")
                {
                    result += r + "\n";
                }
            }
            Console.WriteLine(result);
        }
        public void MostrarRutinaDefinicion(List<Rutina> rutinas)
        {
            string result = "";
            foreach (Rutina r in rutinas)
            {
                if (r.GetTipo() == "Definición")
                {
                    result += r + "\n";
                }
            }
            Console.WriteLine(result);
        }
        public Inicio()
        {
            InitializeComponent();
            efectosPlantilla();
        }

        private void btn_dietas_Click(object sender, EventArgs e)
        {
            /*
            DataTable table = new DataTable();
            table.Columns.Add("Comidas");
            table.Columns.Add("Tipo");
            table.Rows.Add("macarrones","hipertrofia");

            List<Dieta> dietas = new List<Dieta>();

            MostrarDietaDefinicion(dietas);
            MostrarDietaHipertrofia(dietas);
            */
        }
        private void efectosPlantilla()
        {
            submenuDietas.Visible = false;
            submenuRutinas.Visible = false;
        }
        private void ocultarSubmenu()
        {
            if (submenuDietas.Visible == true)
                submenuDietas.Visible = false;
            if (submenuRutinas.Visible == true)
                submenuRutinas.Visible = false;
        }
        private void mostrarSubmenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                ocultarSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(submenuRutinas);
        }

        private void Dietas_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(submenuDietas);
        }

        private void dietaDefinicion_Click(object sender, EventArgs e)
        {
            MostrarDietaDefinicion(readDietas());
            ocultarSubmenu();
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {
            
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
            if (movLogin)
            {
                this.Location = Cursor.Position;
            }
        }

        private void panelTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            movLogin = false;
        }
        private void mostrarDietas()
        {

        }
        private List<Dieta> readDietas()
        {
            try
            {
                List<Dieta> dietas = new List<Dieta>();

                StreamReader file = new StreamReader("../../../data/dietas.txt");
                string line = file.ReadLine();

                while(line != null)
                {
                    string[] split = line.Split(',');
                    dietas.Add(
                        new Dieta(
                                new List<Comida>()
                                {
                                    new Comida(split[0],double.Parse(split[1]),double.Parse(split[2]),
                                    double.Parse(split[3]),double.Parse(split[4])), 
                                    new Comida(split[5], double.Parse(split[6]),
                                    double.Parse(split[7]), double.Parse(split[8]), double.Parse(split[9])),
                                    new Comida(split[10], double.Parse(split[11]),
                                    double.Parse(split[12]), double.Parse(split[13]), double.Parse(split[14])),
                                    new Comida(split[15], double.Parse(split[16]),
                                    double.Parse(split[17]), double.Parse(split[18]), double.Parse(split[19])),
                                    new Comida(split[20], double.Parse(split[21]),
                                    double.Parse(split[22]), double.Parse(split[23]), double.Parse(split[24]))
                                },
                                split[25]));
                    line = file.ReadLine();
                }
                file.Close();
                return dietas;
            }
            catch(IOException error)
            {
                return null;
                Console.WriteLine("Error de lectura dietas.txt: "+error.Message);
            }
        }
        private void mostrarDietas(List<Dieta> lista)
        {
            listBoxContenido.DataSource = lista;
        }
        private void dietaTodas_Click(object sender, EventArgs e)
        {
            mostrarDietas(readDietas());
            ocultarSubmenu();
        }

        private void dietaHipertrofia_Click(object sender, EventArgs e)
        {
            MostrarDietaHipertrofia(readDietas());
            ocultarSubmenu();
        }
    }
}
