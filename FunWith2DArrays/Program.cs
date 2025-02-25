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
        
        
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                
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