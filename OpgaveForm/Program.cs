﻿using System;

namespace OpgaveForm
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            Cirkel C = new Cirkel(2);
            C.Areal();
            Console.WriteLine();
            Trekant T = new Trekant(3,5);
            T.Areal();



        }
    }
}
