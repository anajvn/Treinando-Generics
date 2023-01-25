namespace TreinandoGenerics
{
    // Classe para teste genérico
    public class Test
    { }
    internal class Program
    {
        // Crie um overload de métodos para comparar se string, int e double são iguais.

        static bool Compare(int a, int b) => a == b;

        static bool Compare(string a, string b) => a == b;

        static bool Compare(double a, double b) => a==b;

        static void Main(string[] args)
        {
            // Teste não genericos

            Console.WriteLine("Teste overload: \n");

            Console.WriteLine("1 e 1: " + Compare(1, 1)); // True
            Console.WriteLine("\"1\" e \"2\": " + Compare("1", "2")); // False
            Console.WriteLine("1.0 e 1.0: " + Compare(1.0, 1.0)); // True

            Console.WriteLine("\nTeste Generics: \n");
            // Teste genéricos

            Test t1 = new Test();
            Test t2 = new Test();
            var t3 = t1;

            Console.WriteLine("1 e 1: " + Compare(1, 1)); // True
            Console.WriteLine("\"1\" e \"2\": " + CompareGenerics.Compare("1", "2")); // False
            Console.WriteLine("1.0 e 1.0: " + CompareGenerics.Compare(1.0, 1.0)); // True
            Console.WriteLine("T1 e T2: " + CompareGenerics.Compare(t1, t2)); // False
            Console.WriteLine("T1 e T3: " + CompareGenerics.Compare(t1, t3)); // True

        }
    }
}