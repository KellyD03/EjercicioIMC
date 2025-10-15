namespace Imc.Model
{
    public static class IndiceDeMasaCorporalLib
    {
        public static decimal IndiceDeMasaCorporal(decimal peso, decimal estatura)
        {
            return peso / (estatura *estatura);
        }
        public static string DeterminaEstadoNutricional(decimal imc)
        {
            if (imc < 18.5m)
            {
                return "Peso bajo";
            }
            if (imc < 25.00m)
            {
                return "Peso normal";
            }
            if (imc < 30.00m)
            {
                return "Sobrepeso";
            }
            if (imc < 40.00m)
            {
                return "Obesidad";
            }
            return "Obesidad extrema";

        }
    }
}
