using System.Linq.Expressions;

namespace Examples;

class Example05 {
    public static void run() {
        // I
        object data = "Hello, World!";

        if (data is string message)
        {
            Console.WriteLine($"String length: {message.Length}");
        }

        // II
        propertyMatching();

        // III
        switchPattern(42);

        // IV
        switchExpression(42);
    }

    record Person(string Name, int Age);
    private static void propertyMatching() {
        var person = new Person("Alice", 30);

        if (person is { Name: "Alice", Age: > 18 })
        {
            Console.WriteLine("Alice is an adult");
        }
    }

    private static void switchPattern(object data) {
        switch (data)
        {
            case int number when number > 0:
                Console.WriteLine("Positive number");
                break;
            case int number when number < 0:
                Console.WriteLine("Negative number");
                break;
            case string text:
                Console.WriteLine($"Text: {text}");
                break;
            default:
                Console.WriteLine("Unknown type");
                break;
        }
    }

    private static void switchExpression(object data) {
        var result = data switch
        {
            int number when number > 0 => "Positive number",
            int number when number < 0 => "Negative number",
            string text => $"Text: {text}",
            _ => "Unknown type" // _ is default
        };

        Console.WriteLine(result);
    }
}