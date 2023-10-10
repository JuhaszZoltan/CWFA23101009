using System.Text;

namespace NobelDijCLI
{
    internal class Program
    {
        static void Main()
        {
            List<Dijazott> dijazottak = new();
            using StreamReader sr = new(@"..\..\..\src\orvosi_nobeldijak.txt", Encoding.UTF8);
            _ = sr.ReadLine();
            while (!sr.EndOfStream) dijazottak.Add(new(sr.ReadLine()));

            Console.WriteLine($"3. feladat: Díjazottak száma: {dijazottak.Count} fő");

            int f4 = dijazottak.Max(d => d.Ev);
            Console.WriteLine($"4. feladat: Utolsó év: {f4}");

            Console.Write("5. feladat: kérem adja meg az ország kódját: ");
            string okInput = Console.ReadLine();
            var f5 = dijazottak.Where(d => d.Orszag == okInput).ToList();

            if (f5.Count == 0) Console.WriteLine("\tA megadott országból nem volt díjazott.");
            else if (f5.Count == 1)
            {
                Console.WriteLine("\tA megadott ország díjazottja:");
                Console.WriteLine($"\tNév: {f5[0].Nev}");
                Console.WriteLine($"\tÉv: {f5[0].Ev}");
                Console.WriteLine($"\tSz/H: {f5[0].SzHStr}");
            }
            else Console.WriteLine($"\tA megadott országból {f5.Count} díjazott volt.");

            Console.WriteLine("6. feladat: Statisztika");
            var f6 = dijazottak
                .GroupBy(d => d.Orszag)
                .Where(ig => ig.Count() > 5)
                .ToDictionary(k => k.Key, v => v.Count());
            foreach (var kvp in f6) Console.WriteLine($"\t{kvp.Key, 3} - {kvp.Value, 2} fő");

            var f7 = dijazottak
                .Where(d => d.SzH.Halal is not null)
                .Average(d => d.SzH.Halal - d.SzH.Szuletes);
            Console.WriteLine($"7. feladat: a keresett átlag: {f7:0.0} év");
        }
    }
}