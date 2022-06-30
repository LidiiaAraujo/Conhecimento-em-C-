 string nome1, nome2;
            int peso1, peso2;
 
            Console.WriteLine("Usuário x, por favor digite seu nome: ");
            nome1 = Console.ReadLine();
            Console.WriteLine("Por favor, digite o seu peso: ");
            peso1 = int.Parse(Console.ReadLine());
 
            Console.WriteLine("Usuário y, por favor digite seu nome: ");
            nome2 = Console.ReadLine();
            Console.WriteLine("Por favor, digite o seu peso: ");
            peso2 = int.Parse(Console.ReadLine());
 
            if (peso1 > peso2)
            {
                Console.WriteLine("O usuário se chama: " + nome1);
                Console.WriteLine("O peso do " + nome1 + " é: " + peso1.ToString());
            }
            else
            {
                Console.WriteLine("O usuário se chama: " + nome2);
                Console.WriteLine("O peso do " + nome2 + " é: " + peso2.ToString());