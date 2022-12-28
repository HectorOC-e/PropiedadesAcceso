using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadesAcceso
{
    internal class Program
    {
        static void Main()
        {
            Empleado Juan = new Empleado("Juan")
            {
                SALARIO = -75
            };

            Console.WriteLine($"El salario del empleado es: {Juan.SALARIO}");
        }
    }
    class Empleado
    {
        private string nombre;
        private double salario;
        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetNombre() => nombre;
        public void SetNombre(string nombre) => this.nombre = nombre; 
        public void SetSalario(double salario)
        {
            if (salario < 0)
            {
                Console.WriteLine("El salario no puede ser negativo. Se asignara 0 como salario"); ;
                this.salario = 0;
            } 
            else
            {
                this.salario = salario;
            }
        }
        public double GetSalario() => salario;
        private double EvaluaSalario(double salario)
        {
            if (salario < 0) return 0;
            else return salario;
        }
        public double SALARIO
        {
            get => salario;
            set => salario = EvaluaSalario(value);
        }
    }
}
