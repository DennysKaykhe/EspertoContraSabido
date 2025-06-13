using System.Numerics;

Console.Clear();

int distribuídos;

Console.WriteLine("--- Esperto Contra Sabido ---");

Console.Write("Quantos alimentos serão distribuídos?: ");

distribuídos = Convert.ToInt16(Console.ReadLine());

if (distribuídos <= 0) return;

int restante = distribuídos;
int ParaVocê = 0, ParaMim = 0;
int RoubandoPaMim = 0, RoubandoPaVocê = 0;

while (restante > 0)
{
    RoubandoPaVocê++;
    ParaVocê += 1;
    restante -= 1;

    Console.Write($"\n{ParaVocê} para você. ");

    RoubandoPaMim = 0;
    while (restante > 0 && RoubandoPaMim < RoubandoPaVocê)
    {

        RoubandoPaMim ++;
        ParaMim += 1;
        restante -= 1;

        Console.Write($"{RoubandoPaMim}");

        if (restante > 0 && RoubandoPaMim < RoubandoPaVocê)
        {
            Console.Write(",");
        }

        Console.Write(" ");
    }

    if (RoubandoPaMim > 0)
    {
        Console.WriteLine("para mim.");
    }
}

if (RoubandoPaMim == 0)
{
    Console.WriteLine();
}

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine($"Pica-pau recebeu {ParaVocê} alimento(s).");

Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine($"Raposinha recebeu {ParaMim} alimento(s).");

Console.ResetColor();