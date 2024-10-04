// https://linqtotypescript.com/ is a great resource for converting C# LINQ to TypeScript.

namespace Examples;

class Example04 {
    static List<string> names = new() { "John", "Doe", "Alice", "Bob" };
    public static void run() {
        Console.WriteLine(names.FirstOrDefault(x => x.StartsWith("J")));
        Console.WriteLine(names.SingleOrDefault(x => x.Contains("c"))); // "o" will throw an error

        names.OrderBy(x=> x.Length).ThenBy(x => x);

        var oneToTen = Enumerable.Range(1, 10); // 1, 2, 3,...
        var tenOnes = Enumerable.Repeat(1, 10); // 1, 1, 1,...

        tenOnes.Distinct();

        groupBy();
        query();
    }

    private static void groupBy() {
        var grouped = names.GroupBy(x => x.Length);
        foreach (var group in grouped) {
            Console.WriteLine($"Group {group.Key}: {string.Join(", ", group)}");
        }
    }

    private static void query() {
        var query = from name in names
                    where name.Length > 3
                    select new { name, name.Length }; // Anonymous type and property name taken

        foreach (var name in query) {
            Console.WriteLine(name);
        }
    }
}