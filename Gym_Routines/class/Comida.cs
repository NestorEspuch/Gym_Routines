using System;
using System.Collections.Generic;
using System.Text;

namespace Gym_Routines
{
    public class Comida : IComparable<Comida>
    {
        string nombre;
        double calorias;
        double proteinas;
        double hidratos;
        double grasas;
        public Comida(string nombre, double calorias, double proteinas, double hidratos, double grasas)
        {
            this.nombre = nombre;
            this.calorias = calorias;
            this.proteinas = proteinas;
            this.hidratos = hidratos;
            this.grasas = grasas;
        }
        public Comida() : this("",0,0,0,0) { }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public void SetCalorias(double calorias)
        {
            this.calorias = calorias;
        }
        public double GetCalorias()
        {
            return calorias;
        }
        public void SetProteinas(double proteinas)
        {
            this.proteinas = proteinas;
        }
        public double GetProteinas()
        {
            return proteinas;
        }
        public void SetHidratos(double hidratos)
        {
            this.hidratos = hidratos;
        }
        public double GetHidratos()
        {
            return hidratos;
        }
        public void SetGrasas(double grasas)
        {
            this.grasas = grasas;
        }
        public double GetGrasas()
        {
            return grasas;
        }
        public override string ToString()
        {
            return $"{nombre}\n" +
                $" - calorias: {calorias}\n" +
                $" - proteinas: {proteinas}\n" +
                $" - hidratos: {hidratos}\n" +
                $" - grasas: {grasas}";
        }
        public int CompareTo(Comida comida)
        {
            if (String.Compare(this.nombre, comida.nombre) < 0)
            {
                return -1;
            }
            else if (String.Compare(this.nombre, comida.nombre) > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
