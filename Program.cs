namespace RanksAndFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isNumber;

            do {
                Console.WriteLine("Please enter size of board");
                isNumber = int.TryParse(Console.ReadLine(), out int boardSize);

                var myArray = new string[boardSize, boardSize];

                for (int i = boardSize; i > 0; i--) {
                    for (int j = 0; j < boardSize; j++) {
                        string boardPosition = $"{(char)(j + 97)}{i}";
                        myArray[i - 1, j] = boardPosition;
                    }
                }

                for (int i = boardSize; i > 0; i--) {
                    for (int j = 0; j < boardSize; j++) Console.Write(myArray[i - 1, j]);
                    Console.WriteLine();
                }
            } while (!isNumber);
        }
    }
}
