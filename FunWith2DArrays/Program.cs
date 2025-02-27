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
        char[,] array2D = new char [rows, columns];
        
        // Define allowed characters (digits and some special characters).
        string allowedCharacters = "0123456789!@#$%^&*";
        
        // Create a Random object.
        Random random = new Random();
        // Fill the array with random characters.
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                // Randomly select a character from allowedCharacters.
                array2D[row, column] = allowedCharacters[random.Next(allowedCharacters.Length)];
            }
        }
        // Displaying the 2D Array with indices and borders.
        Console.WriteLine("\nThe elements of the Array are: ");
        // Print top border with column indices.
        Console.Write("   "); // Space for row index
        for (int col = 0; col < columns; col++)
        {
            Console.Write($" {col} ");
        }
        Console.WriteLine();
        
        Console.Write("     ");  // Space for row index.
        Console.WriteLine(" " + new string('-', columns * 3)); // Top border
        }
    }

}   