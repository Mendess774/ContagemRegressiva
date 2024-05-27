Console.WriteLine("---soletrando---");
Console.WriteLine("---digite c para começar a contagem regressiva---");

string texto = Console.ReadLine()!;

Console.WriteLine("---iniciando contagem regressiva...---");

Thread.Sleep(1000);

Console.ForegroundColor = ConsoleColor.Green;

Console.Write(" Preparar...");
Thread.Sleep(1000);

Console.ForegroundColor = ConsoleColor.Yellow;

Console.Write(" Apontar...");
Thread.Sleep(1000);

Console.ForegroundColor = ConsoleColor.Red;

Console.Write(" FOGO!!!");