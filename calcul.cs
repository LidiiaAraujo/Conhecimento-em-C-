namespace Calculator_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora simples - siga as instruções do programa");
            while (true)
            {
                    double Valor1, Valor2, c; char h; c = 0.0;
                    Console.WriteLine("insira o primeiro número"); Valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Operação (+) (-) (*) (/) "); h = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("insira o segundo número"); Valor2 = Convert.ToDouble(Console.ReadLine());
                    switch (h)
                    {
                        case '+': c = Valor1 + Valor2;
                            break;
                        case '-': c = Valor1 - Valor2;
                            break;
                        case '/': c = Valor1 / Valor2;
                            break;
                        case '*': c = Valor1 * Valor2;
                            break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("= " + c);
                    Console.WriteLine("Limpar");
                    ConsoleKeyInfo e = Console.ReadKey();
                    if (e.KeyChar == 'n') break;
                    Console.WriteLine();

                    MessageBox.Show("Resultado" + с");
                
            }
 
        }
    }
}