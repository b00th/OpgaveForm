using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveForm
{
     class Cirkel:Figur
    {
        private double radius;

        public Cirkel()
        {
        }

        public Cirkel(double radius) 
        { 
            this.radius = radius; 
        }

        public double Radius 
        {
            get { return radius;}
            set { radius = value; }
        }
        public override void Areal()
        {
            
            double rad = Math.Pow(Radius, 2);
            double areal = Math.PI * rad; 

            Console.WriteLine($"Arealet på cirklen er {areal:n2}\nMed en radius på {radius:n2}");
        }

    }
}
