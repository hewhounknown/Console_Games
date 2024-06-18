// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

int playerTurn = 1;
int choice;

do
{
    ReloadBoard();

    Console.WriteLine("Player1 : O and Player2 : X \n");

    if (playerTurn == 1)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Player1 Turn \n");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Player2 Turn \n");
    }
    Console.Write("Enter choice :");

    if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 9)
    {
        WaitLoading("Enter only 1 to 9");
        continue;
    }

    if (arr[choice] != 'X' && arr[choice] != 'O')
    {
        arr[choice] = playerTurn == 1 ? 'O' : 'X';
        playerTurn = playerTurn == 1 ? 2 : 1;
    }
    else
    {
        WaitLoading("already filled");
    }
    CheckWinning();
    
} while (true);

void ReloadBoard()
{
    Console.Clear();
    for (int i = 1; i <= 9; i++)
    {
        Console.ForegroundColor = arr[i] == 'O' ? ConsoleColor.Cyan : arr[i] == 'X' ? ConsoleColor.Red : ConsoleColor.White;
        Console.Write("  {0}  ", arr[i]);
        Console.ForegroundColor = ConsoleColor.White;
        if (i % 3 == 0)
        {
            Console.WriteLine();
            if (i != 9) Console.WriteLine("_____|_____|_____ \n     |     |      ");
        }
        else Console.Write("|");
    }
    Console.WriteLine("     |     |      ");
    // Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.White;
}

void WaitLoading(string msg)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\n" + msg);
    Console.WriteLine("Please wait 2 second board is loading again.....");
    Thread.Sleep(2000);
    Console.ResetColor();
}

void CheckWinning()
{
    if ((arr[1] == arr[2] && arr[2] == arr[3]) ||
        (arr[4] == arr[5] && arr[5] == arr[6]) ||
        (arr[7] == arr[8] && arr[8] == arr[9]) ||
        (arr[1] == arr[4] && arr[4] == arr[7]) ||
        (arr[2] == arr[5] && arr[5] == arr[8]) ||
        (arr[3] == arr[6] && arr[6] == arr[9]) ||
        (arr[1] == arr[5] && arr[5] == arr[9]) ||
        (arr[3] == arr[5] && arr[5] == arr[7]))
    {
        string msg = playerTurn - 1 == 1 ? "player1 is winner" : "player2 is winner";
        EndMessage(msg);
    }
    else if (!arr.Contains('1') && !arr.Contains('2') && !arr.Contains('3') &&
         !arr.Contains('4') && !arr.Contains('5') && !arr.Contains('6') &&
         !arr.Contains('7') && !arr.Contains('8') && !arr.Contains('9'))
    {
        EndMessage("It's draw");
    }
}

void EndMessage(string msg)
{
    ReloadBoard();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(msg);
    Console.WriteLine("Press any key to exit.");
    Console.ReadKey();
    Environment.Exit(0);
    Console.ResetColor();
}