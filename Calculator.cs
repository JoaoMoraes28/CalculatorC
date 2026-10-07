namespace Calculator
{
    internal class Calculator
    {
        public void StartCalculator()
        {
            Console.WriteLine("Selecione a operação desejada:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("------------------------------");

            string? answer = Console.ReadLine();

            Console.WriteLine("Primeiro valor:");
            string? v1 = Console.ReadLine();
            Console.WriteLine("Segundo valor:");
            string? v2 = Console.ReadLine();

            float result = 0;

            if (v1 == null || v2 == null)
                Console.WriteLine("Valores inválidos!");
            else
            {
                switch (answer)
                {
                    case "1":
                        result = Sum(v1!, v2!);
                        break;

                    case "2":
                        result = Subtraction(v1!, v2!);
                        break;

                    case "3":
                        result = Division(v1!, v2!);
                        break;

                    case "4":
                        result = Multiplication(v1!, v2!);
                        break;

                    default:
                        Console.WriteLine("Nenhuma operação selecionada.");
                        break;
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"O resultado da operação é {result}");
        }

        static public float Sum(string v1, string v2)
        {
            return float.Parse(v1) + float.Parse(v2);
        }

        static public float Subtraction(string v1, string v2)
        {
            return float.Parse(v1) - float.Parse(v2);
        }

        static public float Division(string v1, string v2)
        {
            return float.Parse(v1) / float.Parse(v2);
        }

        static public float Multiplication(string v1, string v2)
        {
            return float.Parse(v1) * float.Parse(v2);
        }
    }
}
