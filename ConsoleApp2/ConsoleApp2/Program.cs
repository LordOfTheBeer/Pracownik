using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Pracownik
    {
        protected string nazwisko;
        protected string imie;
        protected double p_zasadnicza;
        public virtual double premia()
        {
            return p_zasadnicza * 0.2;
        }
        public Pracownik(string n, string i, double p)
        {
            nazwisko = n; imie = i; p_zasadnicza = p;
        }
    }

    class Kierownik:Pracownik
    {
        public Kierownik(string n, string i, double p) : base(n, i, p)
        {}
        public override double premia()
        {
            return p_zasadnicza * 0.5;
        }
       
        
    }
    class Dyrektor : Kierownik
    {
        public Dyrektor(string n, string i, double p) : base(n, i, p)
        { }
        public override double premia()
        {
            return base.premia() + 2000;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Pracownik p1 = new Pracownik("Rajcula", "Henryk", 5000);
            Pracownik k1 = new Kierownik("Wodeczka", "Irena", 8000);
            Pracownik d1 = new Dyrektor("Oszust", "Marian", 10000);
            List<Pracownik> Zaloga = new List<Pracownik>();
            Zaloga.Add(p1);
            Zaloga.Add(k1);
            Zaloga.Add(d1);
            Zaloga.Add(new Pracownik("Strus", "Jurek", 4500));
            Zaloga.Add(new Pracownik("Wiertara", "Piotr", 4000));

            double suma1 = 0, suma2 = 0;
            int ile1 = 0, ile2 = 0;

            foreach (var p in Zaloga) 
            {
                if (p.GetType().Name == "Pracownik")

                {
                    suma1 += p.premia(); ++ile1;
                }
                else
                {
                    suma2 += p.premia(); ++ile2;
                }
            }
            Console.WriteLine("Srednia premia pracownika: " + suma1 / ile1 + " Srednia premia Szefostwa: " + suma2 / ile2);




        }
    }
}
