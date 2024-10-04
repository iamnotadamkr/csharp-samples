namespace S01;

interface IPerson {
    [property: System.Diagnostics.CodeAnalysis.NotNull]
    public string Name { get; }
    public bool HasMustache { get; }
}

class Person1 : IPerson
{
    public string Name { get; }
    public bool HasMustache { get; }
    public Person1(string name, bool hasMustache)
    {
        this.Name = name ?? String.Empty;
        HasMustache = hasMustache;
    }

    public override string ToString() => $"{Name}, ${nameof(HasMustache)}: {HasMustache}"; // Person1, HasMustache: True
}

class Person2(string name, bool hasMustache = false) : IPerson
{
    public string Name { get; } = name;
    public bool HasMustache { get; } = hasMustache;
}

// var person = new Person2("John Doe", true);

record Employee(string Name, int Age, bool HasMustache, decimal Salary, double Weight) : IPerson;