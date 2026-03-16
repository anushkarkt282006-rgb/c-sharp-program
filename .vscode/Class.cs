public class Rectangle
{
    private double length;
    private double width;

    // Default constructor
    public Rectangle()
    {
        length = 0;
        width = 0;
    }

    // Parameterized constructor
    public Rectangle(double len, double wid)
    {
        length = len;
        width = wid;
    }

    // Method to calculate area
    public double GetArea()
    {
        return length * width;
    }

    // Method to display values
    public void Display()
    {
        Console.WriteLine($"Length: {length}");
        Console.WriteLine($"Width: {width}");
        Console.WriteLine($"Area: {GetArea()}");
    }
}