string especie, raca, alcunha, idade, cor;

Console.WriteLine("PET HOTEL");


Console.WriteLine("Digite a espécie do pet: ");
especie = Console.ReadLine()!;

Console.WriteLine("Digite a raça do pet: ");
raca = Console.ReadLine()!;

Console.WriteLine("Digite a alcanha do pet: ");
alcunha = Console.ReadLine()!;

Console.WriteLine("Digite a idade do pet: ");
idade = Console.ReadLine()!;

Console.WriteLine("Digite a cor do pet: ");
cor = Console.ReadLine()!;

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("|                Pet Hotel - Peteleco                     |");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"| Espécie:");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"{especie.PadLeft(20, '.')}");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"| Raça: ");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"{raca.PadLeft(20, '.')}");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("|");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");


Console.ForegroundColor = ConsoleColor.Green;
Console.Write("| Atende pela alcunha de: ");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"{alcunha.PadLeft(32, '.')}");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("|");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("| Idade:");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"{idade.PadLeft (18, '.')}");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.Write(" Pelagem/cor: ");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"{cor.PadLeft(18, '.')}");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("|");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");
