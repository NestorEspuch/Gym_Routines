using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Gym_Routines
{
    public partial class Inicio : Form
    {
        public void MostrarDietaHipertrofia(List<Dieta> dietas)
        {
            string result = "";
            foreach(Dieta d in dietas)
            {
                if(d.GetTipo() == "Hipertrofia")
                {
                    result += d + "\n";
                }
            }
            Console.WriteLine(result);
        }
        public void MostrarDietaDefinicion(List<Dieta> dietas)
        {
            string result = "";
            foreach (Dieta d in dietas)
            {
                if (d.GetTipo() == "Definición")
                {
                    result += d + "\n";
                }
            }
            Console.WriteLine(result);
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
            /*
             * 
             * 
             * 
             */
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
    }
}
