namespace Examples;

class Example06 {
    public static async Task run()
    {
        try
        {
            // Call an async method that returns a promise (Task)
            string result = await FetchDataAsync();
            Console.WriteLine($"Data received: {result}");
        }
        catch (Exception ex)
        {
            // Handle any errors that occur during the async operation
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    static async Task<string> FetchDataAsync()
    {
        await Task.Delay(1000);

        Random random = new Random();
        if (random.Next(0, 2) == 0) // 50% chance of failure
        {
            throw new Exception("Failed to fetch data!");
        }
        return "Hello, async world!";
    }
}