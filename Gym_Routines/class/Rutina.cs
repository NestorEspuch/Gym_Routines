using System;
using System.Collections.Generic;
using System.Text;

namespace Gym_Routines
{
    public class Rutina
    {
        List<Ejercicio> ejercicios;
        string dificultad;
        string tipo;
        int diasEntrenamiento;

        public Rutina(List<Ejercicio> ejercicios, string tipo, int diasEntrenamiento)
        {
            this.ejercicios = ejercicios;
            this.dificultad = calcularDificultad();
            this.tipo = tipo;
            this.diasEntrenamiento = diasEntrenamiento;
        }
        public Rutina() : this(new List<Ejercicio>(),"",0) { }

        #region "Get/Set/Add"
        public void SetEjercicios(List<Ejercicio> ejercicios)
        {
            this.ejercicios = ejercicios;
        }
        public List<Ejercicio> GetEjercicios()
        {
            return ejercicios;
        }
        public void AddEjercicio(Ejercicio ejercicio)
        {
            ejercicios.Add(ejercicio);
        }
        public void SetDificultad(string dificultad)
        {
            this.dificultad = dificultad;
        }
        public string GetDificultad()
        {
            return dificultad;
        }
        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public string GetTipo()
        {
            return tipo;
        }
        public void SetDiasEntrenamiento(int diasEntrenamiento)
        {
            this.diasEntrenamiento = diasEntrenamiento;
        }
        public int GetDiasEntrenamiento()
        {
            return diasEntrenamiento;
        }
        #endregion

        public override string ToString()
        {
            string result = "";
            result += "";
            foreach(Ejercicio e in ejercicios)
            {
                result += e + "\n";
            }
            result += $"Dificultad: {dificultad}, Tipo: {tipo}\n" +
                $"Dias de entrenamiento: {diasEntrenamiento}";
            return result;
        }

        private string calcularDificultad()
        {
            int baja = 0, media = 0, alta = 0;
            foreach(Ejercicio e in ejercicios)
            {
                switch(e.GetDificultad().ToLower())
                {
                    case "baja":
                        baja++;
                        break;
                    case "media":
                        media++;
                        break;
                    case "alta":
                        alta++;
                        break;
                }
            }
            if(baja > media && baja > alta)
            {
                return "baja";
            }
            else
            {
                if(media > alta)
                {
                    return "media";
                }
                else
                {
                    return "alta";
                }
            }
        }
    }
}
