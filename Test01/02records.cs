namespace Examples;

record FamilyMember(string FirstName, string LastName, bool Mustache = false);


class Example02 {
    public static void run() {
        var aunt = new FamilyMember("Alex", "Doe");
        var uncle = aunt with { Mustache = true }; // { ...aunt, mustache = true }
        Console.WriteLine($"Uncle: {uncle}");

        // Immutable
        // aunt.FirstName = "Alice";

        var aunt2 = new FamilyMember("Alex", "Doe");
        Console.WriteLine($"Same aunt: {aunt == aunt2}"); // True


        FamilyMember grandma = new ("Auld", "Doe");

        var (first, last, _) = grandma; // Deconstruct

        Console.WriteLine($"Grandma: {first} {last}");
    }
}
