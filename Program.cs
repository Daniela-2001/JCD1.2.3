namespace JCD1._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Escreva quatro números");
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());
            double number4 = double.Parse(Console.ReadLine());

            double res1 = number1 / (number2 + number3 + number4);
            double res2 = number2 / (number1 + number3 + number4);
            double res3 = number3 / (number1 + number2 + number4);
            double res4 = number4 / (number1 + number2 + number3);

            if (res1 < res2 && res1 < res3 && res1 < res4)
            {
                Console.WriteLine($"O número menor é o {res1}");

            } else if (res2 < res1 && res2 < res3 && res2 < res4)

            {
                Console.WriteLine($"O número menor é o {res2}");

            } else if (res3 < res1 && res3 < res2 && res3 < res4)
            {
                Console.WriteLine($"O número menor é o {res3}");

            } else
                Console.WriteLine($"O número menor é o {res4}");

            */

            // Existe outra maneira de se fazer esta questão

            //Receber quatro números do usuário

            Console.WriteLine("Digite o primeiro número");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número");
            double number3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o quarto número");
            double number4 = Convert.ToDouble(Console.ReadLine());

            // Chamar a função para encontrar o menor resultado da divisão

            double resultado = EncontrarMenorDivisao(number1, number2, number3, number4);

            // Exibir o resultado
            Console.WriteLine($"O menor resultado da divisão é: {resultado}");

            static double EncontrarMenorDivisao(double num1, double num2, double num3, double num4)
            {
                //Calcaular as divisões e encontrar o menor resultado

                double divisao1 = num1 / (num2 * num3 * num4);
                double divisao2 = num2 / (num1 * num3 * num4);
                double divisao3 = num3 / (num1 * num2 * num4);
                double divisao4 = num4 / (num1 * num2 * num3);

                double menorDivisao = Math.Min(Math.Min(divisao1, divisao2), Math.Min(divisao3, divisao4));
                

                return menorDivisao;
            }


        }
    }
}
