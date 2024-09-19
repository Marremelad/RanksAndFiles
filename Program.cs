namespace RanksAndFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isNumber; // Variable to store whether the input is a valid number.
            int boardSize;  // Variable to store the size of the board.

            // Repeat until a valid board size is entered.
            do {
                Console.WriteLine("Please enter size of board");
                
                // Attempt to parse the user input as an integer.
                isNumber = int.TryParse(Console.ReadLine(), out boardSize);

                // Check if the parsed number is greater than or equal to 1.
                if (boardSize >= 1)
                {
                    // Create a 2D array to represent the board with dimensions boardSize x boardSize.
                    var myArray = new string[boardSize, boardSize];

                    for (int i = boardSize; i > 0; i--) 
                    {
                        for (int j = 0; j < boardSize; j++) 
                        {
                            string boardPosition = $"{(char)(j + 97)}{i}";
                            myArray[i - 1, j] = boardPosition;
                        }
                    }

                    // Print the board to the console.
                    for (int i = boardSize; i > 0; i--) 
                    {
                        for (int j = 0; j < boardSize; j++) Console.Write(myArray[i - 1, j]);
                        Console.WriteLine();
                    }
                }
                // Continue prompting until valid input is provided.
            } while (!isNumber || boardSize <= 0);
        }
    }
}
