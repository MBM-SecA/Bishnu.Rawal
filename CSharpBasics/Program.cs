using LearnCollections;

public class Program
{
    static void Main()
    {
        var square = new Square(34.5);
        square.Display();
        square.GetDiagonal();

        var rectangle = new Rectangle(34.5, 54.2);
        rectangle.Display();
    }
}