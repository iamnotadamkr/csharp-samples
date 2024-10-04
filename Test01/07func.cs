namespace Examples;

class Example07 {
    public static void run() {
        Action greet = () => Console.WriteLine("Hello, World!");
        Action introduce = () => Console.WriteLine($"It's me!");
        // greet();

        var doIt = greet + introduce;
        doIt();

        Func<int, int> square = x => x * x;
        Func<string, string, string> name = (first, last) => $"{first} {last}";
        Console.WriteLine($"Square of 5: {square(5)}");
    }
}