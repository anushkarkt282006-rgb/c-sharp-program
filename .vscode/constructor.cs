public class Person
{
    // Instance variables
    private string name;
    private int age;
    private string email;

    // Default constructor
    public Person()
    {
        name = "Unknown";
        age = 0;
        email = "unknown@example.com";
    }

    // Parameterized constructor
    public Person(string name, int age, string email)
    {
        this.name = name;
        this.age = age;
        this.email = email;
    }

    // Method to display information
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Email: {email}");
    }

    // Method to update information
    public void UpdateInfo(string newName, int newAge, string newEmail)
    {
        name = newName;
        age = newAge;
        email = newEmail;
    }

    // Property accessors
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}