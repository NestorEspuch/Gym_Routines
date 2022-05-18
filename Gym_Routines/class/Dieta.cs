using System;
using System.Collections.Generic;
using System.Text;

namespace Gym_Routines
{
    public class Dieta
    {
        List<Comida> comidas;
        string tipo;
        double totalCalorias;
        double totalProteinas;
        double totalHidratos;
        double totalGrasas;
        public Dieta(List<Comida> comidas, string tipo)
        {
            this.comidas = comidas;
            this.tipo = tipo;
            this.totalCalorias = CalcularTotalCalorias();
            this.totalProteinas = CalcularTotalProteinas();
            this.totalHidratos = CalcularTotalHidratos();
            this.totalGrasas = CalcularTotalGrasas();
        }
        public Dieta() : this(new List<Comida>(),"") { }
        public void SetComidas(List<Comida> comidas)
        {
            this.comidas = comidas;
        }
        public List<Comida> GetComidas()
        {
            return comidas;
        }
        public void AddComida(Comida comida)
        {
            comidas.Add(comida);
        }
        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public string GetTipo()
        {
            return tipo;
        }
        public void SetTotalCalorias(double totalCalorias)
        {
            this.totalCalorias = totalCalorias;
        }
        public double GetTotalCalorias()
        {
            return totalCalorias;
        }
        public void SetTotalProteinas(double totalProteinas)
        {
            this.totalProteinas = totalProteinas;
        }
        public double GetTotalProteinas()
        {
            return totalProteinas;
        }
        public void SetTotalHidratos(double totalHidratos)
        {
            this.totalHidratos = totalHidratos;
        }
        public double GetTotalHidratos()
        {
            return totalHidratos;
        }
        public void SetTotalGrasas(double totalGrasas)
        {
            this.totalGrasas = totalGrasas;
        }
        public double GetTotalGrasas()
        {
            return totalGrasas;
        }
        public override string ToString()
        {
            string result = $"{tipo}\n";
            foreach(Comida c in comidas)
            {
                result += " - " + c + "\n";
            }
            result += $"Calorias totales: {totalCalorias}\n" +
                $"Proteinas totales: {totalProteinas}\n" +
                $"Hidratos totales: {totalHidratos}\n" +
                $"Grasas totales: {totalGrasas}";
            return result;
        }
        public double CalcularTotalCalorias()
        {
            double total = 0;
            foreach(Comida c in comidas)
            {
                total += c.GetCalorias();
            }
            return total;
        }
        public double CalcularTotalProteinas()
        {
            double total = 0;
            foreach (Comida c in comidas)
            {
                total += c.GetProteinas();
            }
            return total;
        }
        public double CalcularTotalHidratos()
        {
            double total = 0;
            foreach (Comida c in comidas)
            {
                total += c.GetHidratos();
            }
            return total;
        }
        public double CalcularTotalGrasas()
        {
            double total = 0;
            foreach (Comida c in comidas)
            {
                total += c.GetGrasas();
            }
            return total;
        }
    }
}
