using System.Diagnostics;

double compteur;
double bpm;
Console.WriteLine("Vous allez devoir appuyer sur espace 15 fois en même temps que votre battement de coeur\n le programme va calculer tout seul votre BPM");
Thread.Sleep(5000);
Console.WriteLine("le compteur va commencer dans 3 secondes :");
Thread.Sleep(1000);
Console.WriteLine("3,");
Thread.Sleep(1000);
Console.WriteLine("2,");
Thread.Sleep(1000);
Console.WriteLine("1,");
Thread.Sleep(1000);
Console.WriteLine("Cliquez !");
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
for (compteur = 0; compteur < 15;)
{

    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        if (key.Key == ConsoleKey.Spacebar)
        {
          compteur++;
          Console.WriteLine($"{compteur}/15");
        }
        

    }
}

stopwatch.Stop();
TimeSpan tempsPasse = stopwatch.Elapsed;
var tempsPasseTotalSeconds = tempsPasse.TotalSeconds;
bpm = 15*60 / tempsPasse.TotalSeconds;

bpm = Math.Round(bpm, 0);
Console.WriteLine($"fini ton bpm c'est {bpm}");
Thread.Sleep(1000);