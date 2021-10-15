
using System;

namespace ConversaoDistancia.Application
{
    public static class ConversorDistancias
    {
        public static double MilhasParaKm(double milhas) => Math.Round(milhas * 1.609, 3);

        public static double KmParaMilhas(double km) => Math.Round(km / 1.609, 3);
    }
}
