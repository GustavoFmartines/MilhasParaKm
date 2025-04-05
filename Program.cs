        int milhas;
        double quilometros = 1.609;
        double quilometros2;

    Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.BackgroundColor = ConsoleColor.Cyan;

Console.WriteLine("|___Conversor de milhas para Quilômetros!___|");

        Console.ResetColor();

Console.WriteLine(@"
Digite sua quantidade de milhas: ");
milhas = Convert.ToInt32(Console.ReadLine()!);

        quilometros2 = milhas * quilometros;

Console.WriteLine(@$"
Suas {milhas} milhas são iguais a {quilometros2}km ");
