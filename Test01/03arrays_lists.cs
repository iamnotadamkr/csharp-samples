namespace Examples;

class Example03 {
    public static void run() {
        string[] arrayOfItems = [ "John", "Doe" ];
        string[] anotherArray = [ ..arrayOfItems, "Name" ];

        List<string> listOfItems = new() { "John", "Doe" };
        var anotherList = new List<string>(arrayOfItems);

        // Print all items
        listOfItems.ForEach(Console.WriteLine);

        // foreach(var item in listOfItems) {
        //     Console.WriteLine(item);
        // }
    }
}