using System;

namespace OpgaveForm
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            Cirkel C = new Cirkel(2);
            C.Areal();
            Console.WriteLine();
            Trekant T = new Trekant(3, 5);
            T.Areal();

            Figur[] figur = new Figur[2];
            figur[0] = C;
            figur[1] = T;
            for (int i = 0; i < figur.Length; i++)
                figur[i].Areal();
                

        }
    }
}
