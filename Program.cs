//declara 5 variáveis do tipo string
string especie, raca, alcunha, idade, cor;

//Escreve no console a string "PET HOTEL"
Console.WriteLine("PET HOTEL");

//Escreve no console a string "Digite a espécie do pet: "
Console.WriteLine("Digite a espécie do pet: ");
//Lê a entrada do usuário a partir do console e atribui o valor à variável especie
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
//Escreve uma linha horizontal no console com uma borda superior e inferior formada por
//símbolos de igual e a cor definida anteriormente
Console.WriteLine("+=========================================================+");

//Define a cor do texto que será impresso no console como verde
Console.ForegroundColor = ConsoleColor.Green;

//Escreve no console uma string contendo o nome do hotel e o apelido do pet no centro, 
//entre duas barras verticais
Console.WriteLine("|                Pet Hotel - Peteleco                     |");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");

//Define a cor do texto que será impresso no console como verde
Console.ForegroundColor = ConsoleColor.Green;

//Escreve no console a string " Espécie:" sem pular uma linha
Console.Write($"| Espécie:");

//Retorna a cor do texto para a cor padrão do console.
Console.ResetColor();

//Define a cor do texto que será impresso no console como vermelho
Console.ForegroundColor = ConsoleColor.Red;

//Escreve no console o valor da variável especie, alinhado à esquerda e preenchido com 
//pontos para que ocupe 20 caracteres
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
