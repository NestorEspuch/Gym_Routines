using System;
using System.Collections.Generic;
using System.Text;

namespace Gym_Routines
{
    public class Ejercicio : IComparable<Ejercicio>
    {
        string nombre;
        string dificultad;
        string musculo;

        public Ejercicio(string nombre, string dificultad, string musculo)
        {
            this.nombre = nombre;
            this.dificultad = dificultad;
            this.musculo = musculo;
        }

        public Ejercicio() : this("","","") { }

        #region "Get/Set"
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public void SetDificultad(string dificultad)
        {
            this.dificultad = dificultad;
        }
        public string GetDificultad()
        {
            return dificultad;
        }
        public void SetMusculo(string musculo)
        {
            this.musculo = musculo;
        }
        public string GetMusculo()
        {
            return musculo;
        }

        #endregion

        public override string ToString()
        {
            return $" Dificultad: {dificultad}, Musculo: {musculo}";
        }

        public int CompareTo(Ejercicio ejercicio)
        {
            if (String.Compare(this.nombre, ejercicio.nombre) < 0)
            {
                return -1;
            }
            else if (String.Compare(this.nombre, ejercicio.nombre) > 0)
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
