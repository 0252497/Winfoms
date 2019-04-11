/* Programme pour se pratiquer avec les nullables. 
 * 
 * Auteure : Véronique Giguère
 * Création : 10 avril 2019
 */
using System;
using static System.Console;

namespace AfficherNullable
{
    static class Program
    {
        static void Main(string[] args)
        {
            Title = nameof(AfficherNullable);

            InfoEntierNullable(10);
            InfoEntierNullable(null);
        }

        static void InfoEntierNullable(int? i) // Nullable<int> i => équivalent
        {
            WriteLine($"Entier: {i}");
            WriteLine("L'entier " + (i.HasValue ? "n'est pas" : "est") + " null");
            WriteLine($"< 20 : {i < 20}");
            WriteLine($"(i + 1) * 2 : {(i + 1) * 2}");

            try
            {
                // int j = (int)i; // Ok, mais exception si est null
                int j = i.Value;    // Agit comme un cast, exception possible
                WriteLine($"j : {j}");
            }
            catch (InvalidOperationException)
            {
                WriteLine($"j : exception!");
            }

            WriteLine($"i + 1 : {(i ?? 0) + 1}");   // On remplace i par 0 si i est null

            // On applique ToString à i seulement si i n'est pas null, sinon "null" :
            WriteLine($"Entier: {i?.ToString() ?? "null"}");    

            WriteLine();
        }
    }
}
