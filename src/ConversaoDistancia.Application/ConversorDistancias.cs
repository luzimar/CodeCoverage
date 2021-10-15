
using System;

namespace ConversaoDistancia.Application
{
    public static class ConversorDistancias
    {
        public static double MilhasParaKm(double milhas)
        {
            return Math.Round(milhas * 1.609, 3);
        }

        public static double KmParaMilhas(double km)
        {
            return Math.Round(km / 1.609, 3);
        }

        public static double KmParaMetros(double km)
        {
            return Math.Round(km / 1000, 3);
        }
    }
}
