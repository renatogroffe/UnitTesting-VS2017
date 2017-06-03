using System;

namespace Temperatura
{
    public static class ConversorTemperatura
    {
        public static double FahrenheitParaCelsius(double temperatura)
        {
            return Math.Round((temperatura - 32) / 1.8, 2);
        }
    }
}