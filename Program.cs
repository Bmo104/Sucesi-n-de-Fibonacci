class Fibonacci
{
    public List<long> fib(byte x)
    {
        List<long> fib = new List<long>();
        long a = 0, b = 1, c = 0;
        for (byte i = 0 ; i <= x; i++)
        {
            fib.Add(c);
            a = b;
            b = c;
            c = a + b;
        }
        return fib;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Fibonacci f = new Fibonacci();
        Console.WriteLine("Introduzca cuantos dígitos quiere (máximo 96)");
        List<long> fibo = f.fib (byte.Parse(Console.ReadLine()));
        Console.Clear();
        Console.WriteLine("Los números de Fibonacci son: ");
        Console.WriteLine(string.Join(", ", fibo));
    }
}