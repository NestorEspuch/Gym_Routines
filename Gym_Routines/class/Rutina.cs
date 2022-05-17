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
        public Rutina(List<Ejercicio> ejercicios, string dificultad, string tipo, int diasEntrenamiento)
        {
            this.ejercicios = ejercicios;
            this.dificultad = dificultad;
            this.tipo = tipo;
            this.diasEntrenamiento = diasEntrenamiento;
        }
        public Rutina() : this(new List<Ejercicio>(),"","",0) { }
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
        public override string ToString()
        {
            string result = "";
            result += "Ejercicios: \n";
            foreach(Ejercicio e in ejercicios)
            {
                result +="- "+ e + "\n";
            }
            result += $"Dificultad: {dificultad}, Tipo: {tipo}\n" +
                $"Dias de entrenamiento: {diasEntrenamiento}";
            return result;
        }
    }
}
