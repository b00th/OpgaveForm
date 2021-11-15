using System;

namespace OpgaveForm
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            Cirkel C = new Cirkel(2);
            //C.Areal();
            
            Trekant T = new Trekant(3, 5);
            // T.Areal();

            Figur F = new Figur();
            

            Figur[] figur = new Figur[3];
            figur[0] = C;
            figur[1] = T;
            figur[2] = F;
            for (int i = 0; i < figur.Length; i++)
                figur[i].Areal();
                

        }
    }
}
