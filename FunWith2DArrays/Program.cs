namespace FunWith2DArrays;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of columns: ");
        int columns = int.Parse(Console.ReadLine());
        
        //Declaring 2D Array user selected.
        int[,] array2D = new int [rows, columns];
        
        // Putting info in the array the user inputs.
        Console.WriteLine("Enter the elements of the array: ");
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Console.Write($"Element at [{row}, {column}]: ");
                array2D[row, column] = int.Parse(Console.ReadLine());
            }
        }
    }

}   