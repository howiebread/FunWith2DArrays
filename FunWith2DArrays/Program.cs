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
        
        // Putting info in the array the user inputs.
        Console.WriteLine("Enter the elements of the array:  Can use a numbers 0-9 or special characters! ");
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                string userInput;
                // Loop until only one character is entered.
                while (true)
                {
                    Console.Write($"Element at [{row}, {column}]: ");
                    userInput = Console.ReadLine();
                    
                    // Condition to break the loop if the user selects one character.
                    if (!string.IsNullOrEmpty(userInput) && userInput.Length == 1)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.  Please enter exactly one character!");
                    }
                }
                array2D[row, column] = userInput[0];
            }
        }
        // Outputting the 2D Array
        Console.WriteLine("\nThe elements of the Array are: ");
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Console.Write(array2D[row, column] + "\t");
            }
            Console.WriteLine();
        }
    }

}   