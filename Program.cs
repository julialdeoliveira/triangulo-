Console.WriteLine("Calculadora de Triângulo");

//Dado 3 lados, descubra se estes formam um triângulo válido
//onde nenhum lado é menor ou igual a zero e nenhum pode ser maior que a soma dos outros dois
//Se for um triângulo válido, calcular o perímetro do perímetro (soma de todos os lados)
//e o tipo (equilátero, isósceles ou escaleno)

Console.WriteLine("informe o lado1 do triângulo");
double lado1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("informe o lado2 do triângulo");
double lado2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("informe o lado3 do triângulo");
double lado3 = Convert.ToDouble(Console.ReadLine());

Triangulo t = new Triangulo(lado1, lado2, lado3);
string tipo = t.Tipo;
double perimetro = t.CalcularPerimetro();

Console.WriteLine("O perímerotro do triângulo é " + perimetro);
Console.WriteLine("O tipo do triângulo é " + tipo);



class Triangulo
{
    public Triangulo(double l1, double l2, double l3)
    {
        if (l1 <= 0 || l2 <= 0 || l3 <= 0)
        {
            Console.WriteLine("Um lado não pode ser menor ou igual a zero!");
            throw new Exception("Isso não é um triângulo");
        }
        ValidarIntegridade(11, 12, 13);
        //inicialização
        this.Lado1 = l1;
        this.Lado2 = l2;
        this.Lado3 = l3;

    }
    private void ValidarIntegridade(double lado1, double lado2, double lado3)
    {
        if (lado1 > lado2 + lado3 || lado2 > lado1 + lado3 || lado3 > lado1 + lado2)
        {
            Console.WriteLine("Um lado não pode ser maior que a soma dos outros dois!");
            throw new Exception("Isso não é um triângulo");
        }
    }

    public double CalcularPerimetro()
    {
        return Lado1 + Lado2 + Lado3;
    }


    public double Lado1 { get; private set; }
    public double Lado2 { get; private set; }
    public double Lado3 { get; private set; }

    public string Tipo
    {
        get
        {
            if (Lado1 == Lado2 && Lado2 == Lado3)
            {
                return "Equilátero";
            }
            else if (Lado1 == Lado2 || Lado1 == Lado3 || Lado2 == Lado3)
            {
                return "Isósceles";
            }
            return "Escaleno";

        }
    }
}
