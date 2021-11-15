using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveForm
{
   class Trekant:Figur
    {
        private double Højde;
        private double Grundlinje;

        public Trekant()
        { }
                
        public Trekant(double Højde, double Grundlinje)
        {
            this.Højde = Højde;
            this.Grundlinje = Grundlinje; 
        }

        public double højde
        {
            get { return Højde; }
            set { højde = value; }
        }

        public double grundlinje
        {
            get { return Grundlinje; } 
            set { Grundlinje = value; }
        }

        public override void Areal()
        {
            
            double areal = højde * Grundlinje;

            Console.WriteLine($"Arealen på trekanten er: {areal:n2} \nHøjden er: {højde} og grundlinjen er: {grundlinje}");
        }

    }
}
