namespace FunWith2DArrays;

class Program
{
    static int rows;
    static int columns;

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of rows: ");
        rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of columns: ");
        columns = int.Parse(Console.ReadLine());


    }
// Prints a horizontal border line. +---+---+---+
    void PrintBorder(int columns)
    {
        for (int column = 0; column < columns; column++)
        {
            Console.Write("+---");
        }
        Console.WriteLine("+");
    }
}