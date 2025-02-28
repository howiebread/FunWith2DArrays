namespace FunWith2DArrays;

class Program
{
    const string USER_PICKS_CHESSBOARD = "c";
    const string USER_PICKS_INDICES = "i";
    static int rows;
    static int columns; 
     

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of rows: ");
        rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of columns: ");
        columns = int.Parse(Console.ReadLine());
        Console.WriteLine($"Enter mode you want to display grid.  For chessboard press {USER_PICKS_CHESSBOARD} for indices press {USER_PICKS_INDICES}. ");
        string userInput = Console.ReadLine();
        while (true)
        {
            if (userInput == USER_PICKS_CHESSBOARD)
            {
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
                
                // Outputting the 2D Array with a chess board pattern.
                Console.WriteLine("\nThe elements of the Array are: ");
                for (int row = 0; row < rows; row++)
                {
                    for (int column = 0; column < columns; column++)
                    {
                        //Determine which color to use.
                        if ((row + column) % 2 == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black; // This is to ensure text is readable
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        // Print the cell with padding.
                        Console.Write($" {array2D[row, column]}\t");
                        // Reset default colors after printing each cell.
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                }
                break;
            }
            else if (userInput == USER_PICKS_INDICES)
            {
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
                break;
            }
            else
            {
                Console.WriteLine("Wrong input, please try again.");
                userInput = Console.ReadLine();
            }
        }
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
