using System;
using System.Collections.Generic;

namespace alumno
{
    struct Alumno
    {
        public string nom, ape;
        public int cal;
       public void Imprimesaludo()
        {
            Console.WriteLine("hola {0} {1} mi calificacion es: {2}", nom, ape, cal);
        }
        public void Califica(int Cal)
        {
            cal = Cal;
        }
    }
    class Program
    {
        public void Imprimesaludo(Alumno a)
        {
            Console.WriteLine("hola {0} {1} mi calificacion es: {2}", a.nom, a.ape, a.cal);
        }
        public void Califica(ref Alumno a, int Cal)
        {
            a.cal = Cal;
        }

        static void Main(string[] args)
        {
            int x = 10;
            Alumno ana = new Alumno();
            ana.nom = "Pedro";
            ana.ape = "Lei";
            ana.Califica(85);
            //Califica(ref ana, 85);
            //ana.cal = 85;
            Alumno timmy = new Alumno();
            timmy.nom = "Benson";
            timmy.ape = "Law";
            timmy.Califica(79);
            //Console.WriteLine("hola {0} {1}", ana.nom, ana.ape);
            ana.Imprimesaludo();
            //Imprimesaludo(ana);
            timmy.Imprimesaludo();
            
            Console.ReadKey();
        }
    }
}
