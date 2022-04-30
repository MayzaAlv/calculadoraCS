string continuar = "";
int opcao;
double n1, n2, resultado = 0;

do {
    Console.WriteLine("\n1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Sair");

    Console.Write("\nEscolha a operação: ");
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 5)
    {
        break;
    } else if (opcao > 5) {
        Console.WriteLine("Opção inválida!! Tente Novamente...");
        continue;
    }

    if (!continuar.Equals("S"))
    {
        Console.Write("\nInsira o primeiro número: ");
        n1 = double.Parse(Console.ReadLine());
        Console.Write("Insira o segundo número: ");
        n2 = double.Parse(Console.ReadLine());
    }
    else {
        Console.Write("\nInsira o próximo número: ");
        n1 = double.Parse(Console.ReadLine());
        n2 = resultado;
    }

    switch (opcao)
    {
        case 1:
            resultado = n1 + n2;
            Console.WriteLine("\nO resultado é " + resultado);
            break;
        case 2:
            resultado = n1 - n2;    
            Console.WriteLine("\nO resultado é " + resultado);
            break;
        case 3:
            resultado = n1 * n2;    
            Console.WriteLine("\nO resultado é " + resultado);
            break;
        case 4:
            resultado = n1 / n2;
            Console.WriteLine("\nO resultado é " + resultado);
            break;
    }

    Console.Write("Deseja continuar a conta com o resultado obtido (S ou N)? ");
    continuar = Console.ReadLine();
    continuar = continuar.ToUpper();

} while (true);

