int row = 7;
int col = 7;
string[,] grid = new string[row, col];
char[] btnNum = { '1', '2', '3', '4', '5', '6', '7' };

for(int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        grid[i, j] = "     ";
    }
}

do
{
    ReloadBoard();

    Console.Write("choose the row number :");

    int choice = int.Parse(Console.ReadLine());


    for (int i = row - 1 ; i >= 0; i--)
    {
        grid[i, choice] = "  !  ";
    }
} while (true);



void ReloadBoard()
{
    Console.Clear();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write("|{0}|", grid[i, j]);
        }
        Console.WriteLine();
    }

    Console.WriteLine("\n");
    for (int i = 0; i < btnNum.Length; i++)
    {
        Console.Write("|  {0}  |", btnNum[i]);
    }

    Console.WriteLine("\n");
}