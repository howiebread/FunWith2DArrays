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
        // Print the grid
        for (int row = 0; row < rows; row++)
        {
            // Print the top border.
            PrintBorder(columns);
            // Print the row contents.
            for (int column = 0; column < columns; column++)
            {
                Console.Write($"|{row},{column}");
            }
            Console.WriteLine("|");
        }
        // Print the bottom border.
        PrintBorder(columns);
    }
// Prints a horizontal border line. +---+---+---+
    static void PrintBorder(int columns)
    {
        for (int column = 0; column < columns; column++)
        {
            Console.Write("+---");
        }
        Console.WriteLine("+");
    }
}
