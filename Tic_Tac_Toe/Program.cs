// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

char[] arr = new char[10];

for(int i = 0;  i < arr.Length; i++)
{
    arr[i] = ' ';
}

string dashboard = "     |     |      " + "\n" +
                  $"  {arr[1]}  |  {arr[2]}  |   {arr[3]}  "+ "\n" +
                   "_____|_____|_____ " + "\n" +
                   "     |     |      " + "\n" +
                  $"  {arr[4]}  |  {arr[5]}  |   {arr[6]}  " + "\n" +
                   "_____|_____|_____ " + "\n" +
                   "     |     |      " + "\n" +
                 $"  {arr[7]}  |  {arr[8]}  |   {arr[9]}  " + "\n" +
                   "     |     |      " + "\n";

Console.WriteLine(dashboard);
Console.ReadKey();