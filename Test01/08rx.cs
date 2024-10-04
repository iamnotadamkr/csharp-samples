using System.Reactive.Linq;
using System.Reactive;

namespace Examples;

class Example08 {
    public static void run() {
        //ticks();
        numbers();
    }

    static void ticks() {
        IObservable<long> ticks = Observable.Timer(
            dueTime: TimeSpan.Zero,
            period: TimeSpan.FromSeconds(1));

        ticks.Subscribe(
            tick => Console.WriteLine($"Tick {tick}"));

        Console.ReadLine();
    }

    static void numbers()
    {
        // Create a source observable that emits numbers
        var numbers = Observable.Range(1, 10);

        // Use a reactive pipeline to transform and filter the data
        var pipeline = numbers
            .Where(n => n % 2 == 0)         // Only even numbers
            .Select(n => n * n)             // Square the numbers
            .Delay(TimeSpan.FromSeconds(3)) // Delay each emission by 1 second
            .Do(n => Console.WriteLine($"Processing number: {n}")); // Debugging

        // Subscribe to the pipeline
        pipeline.Subscribe(
            n => Console.WriteLine($"Received: {n}"),
            () => Console.WriteLine("Sequence completed")
        );

        // Keep the console open to see the emitted values
        Console.ReadLine();
    }
}
