using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using Gym_Routines.forms;
using System.Linq;

namespace Gym_Routines
{
    public partial class Inicio : Form
    {
        public void mostrarDietaHipertrofia(List<Dieta> dietas)
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
        public void mostrarDietaDefinicion(List<Dieta> dietas)
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
        public void mostrarRutinaHipertrofia(List<Rutina> rutinas)
        {
            List<Rutina> lista = new List<Rutina>();
            foreach (Rutina r in rutinas)
            {
                if (r.GetTipo() == "Hipertrofia")
                {
                    lista.Add(r);
                }
            }
            listBoxContenido.DataSource = lista;
        }
        public void mostrarRutinaDefinicion(List<Rutina> rutinas)
        {
            List<Rutina> lista = new List<Rutina>();
            foreach (Rutina r in rutinas)
            {
                if (r.GetTipo() == "Definicion")
                {
                    lista.Add(r);
                }
            }
            listBoxContenido.DataSource = lista;
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
            mostrarDietaDefinicion(readDietas());
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
            catch(IOException)
            {
                return null;
            }
        }
        private void mostrarDietas(List<Dieta> lista)
        {
            listBoxContenido.DataSource = lista;
        }
        private void mostrarRutinas(List<Rutina> lista)
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
            mostrarDietaHipertrofia(readDietas());
            ocultarSubmenu();
        }

        private void btnNewDieta_Click(object sender, EventArgs e)
        {
            NewDieta dieta = new NewDieta();
            dieta.Show();
        }

        private List<Rutina> readRutinas()
        {
            try
            {
                List<Rutina> lista = new List<Rutina>();

                StreamReader file = new StreamReader("../../../data/rutinas.txt");
                string line = file.ReadLine();

                while (line != null)
                {
                    string[] split = line.Split(',');
                    lista.Add(
                        new Rutina(
                                new List<Ejercicio>()
                                {
                                    new Ejercicio(split[0],split[1],split[2]),
                                    new Ejercicio(split[3],split[4],split[5]),
                                    new Ejercicio(split[6],split[7],split[8]),
                                    new Ejercicio(split[9],split[10],split[11]),
                                    new Ejercicio(split[12],split[13],split[14])
                                },
                                split[15],int.Parse(split[16])));
                    line = file.ReadLine();
                }
                file.Close();
                return lista;
            }
            catch(IOException)
            {
                return null;
            }
        }

        private void rutinaTodas_Click(object sender, EventArgs e)
        {
            mostrarRutinas(readRutinas());
            ocultarSubmenu();
        }

        private void rutinaDefinicion_Click(object sender, EventArgs e)
        {
            mostrarRutinaDefinicion(readRutinas());
            ocultarSubmenu();
        }

        private void rutinaHipertrofia_Click(object sender, EventArgs e)
        {
            mostrarRutinaHipertrofia(readRutinas());
            ocultarSubmenu();
        }

        private void btnNewRutina_Click(object sender, EventArgs e)
        {
            NewRutina rutina = new NewRutina();
            rutina.Show();
        }

        private List<Dieta> readDietaPlanSeleccionado()
        {
            List<Dieta> list = new List<Dieta>();
            try
            {
                StreamReader file = new StreamReader("../../../data/planSeleccionado.txt");
                string line = file.ReadLine();
                string[] split = line.Split(',');

                list.Add(new Dieta(
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
                return list;
            }
            catch(IOException error)
            {
                listBoxContenido.Text = "Error de lectura fichero planSeleccionado.txt: "+error.Message;
                return null;
            }
        }

        private List<Rutina> readRutinaPlanSeleccionado()
        {
            List<Rutina> list = new List<Rutina>();
            try
            {
                StreamReader file = new StreamReader("../../../data/planSeleccionado.txt");
                string line = file.ReadLine();
                line = file.ReadLine();
                string[] split = line.Split(',');

                list.Add(new Rutina(
                                new List<Ejercicio>()
                                {
                                    new Ejercicio(split[0],split[1],split[2]),
                                    new Ejercicio(split[3],split[4],split[5]),
                                    new Ejercicio(split[6],split[7],split[8]),
                                    new Ejercicio(split[9],split[10],split[11]),
                                    new Ejercicio(split[12],split[13],split[14])
                                },
                                split[15], int.Parse(split[16])));
                return list;
            }
            catch (IOException error)
            {
                listBoxContenido.Text = "Error de lectura fichero planSeleccionado.txt: " + error.Message;
                return null;
            }
        }

        private void mostrarPlanSeleccionado(List<Dieta> dieta,List<Rutina> rutina)
        {
            List<string> lista = new List<string>();
                lista.Add(dieta[0].ToString());
                lista.Add(rutina[0].ToString());

            listBoxContenido.DataSource = lista;
        }

        private void planSeleccionado_Click(object sender, EventArgs e)
        {
            mostrarPlanSeleccionado(readDietaPlanSeleccionado(),readRutinaPlanSeleccionado());
        }
    }
}
