using System;

class Individuo
{
    public double Peso;
    public double Estatura;

    public Individuo(double peso, double estatura)
    {
        Peso = peso;
        Estatura = estatura;
    }

    public double Formula()
    {
        return Peso / (Estatura * Estatura);
    }


    public string INDICE()
    {
        double IMC = Formula();

        if (IMC < 18.5)
            return $"Su IMC es de {IMC} el estado nutricional es de peso bajo";

        else if (IMC > 18.5 && IMC < 25)
            return $"Su IMC es de {IMC} el estado nutricional es de peso normal";

        else if (IMC > 25 && IMC < 30)
            return $"Su IMC es de {IMC} el estado nutricional es de sobre peso";

        else if (IMC > 30 && IMC < 40)
            return $"Su IMC es de {IMC} el estado nutricional es de Obesidad";

        else if (IMC >= 40)
            return $"Su IMC es de {IMC} el estado nutricional es de Obesidad Extrema";

        else return "Ingrese un valor valido";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido, ingrese sus datos para conocer su IMC");

        Console.WriteLine("Ingrese su peso en kg: ");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese su estatura en m: ");
        double estatura = double.Parse(Console.ReadLine());

        Individuo persona1 = new Individuo (peso, estatura);

        Console.WriteLine($"Resultado: {persona1.INDICE()}");


    }
}

