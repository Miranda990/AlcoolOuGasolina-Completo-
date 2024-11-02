ExibirTitulo();

Console.Write("Informe um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

bool ehPar = DefinirPar(numero);
Console.WriteLine($"O numero {numero} é {(ehPar ? "Par" : "Ímpar")}");

Aparecer();


void ExibirTitulo()
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("--------------------");
    Console.WriteLine("-- Par  ou  Impar --");
    Console.WriteLine("--------------------\n");
    Console.ResetColor();
}

bool DefinirPar(int numero)
{
    bool ehPar = numero % 2 == 0;
    return ehPar;
}

void Aparecer()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("-------------------");
    Console.WriteLine("-Seu numero apareceu!");
    Console.WriteLine("--------------------");
    Console.ResetColor();
    Console.Beep();
}