void SetDataArray()
{
    string[] stringarray1 = { "hallo!", "2", "world", ":=)" };
    string[] stringarray2 = { "1234", "1567", "-2", "computer science" };
    string[] stringarray3 = { "Russia", "Denmark", "Kazan" };
    Console.WriteLine("Заданный массив -> сформированный массив");
    DisplayResult(stringarray1);
    DisplayResult(stringarray2);
    DisplayResult(stringarray3); 
}
void DisplayResult(string[] stringarray)
{
    PrintArray(stringarray);
    Console.Write(" -> ");
    FormingNewArray(stringarray);
    Console.WriteLine();
}
void FormingNewArray(string[] stringarray)
{
    int Nsimbol = 3;
    int length = stringarray.Length;
    string[] Tempstringarray = new string[length];
    int Newlength = 0;
    for (int i = 0; i < length; i++)
    {
        if (stringarray[i].Length <= Nsimbol)
        {
            Tempstringarray[Newlength] = stringarray[i];
            Newlength++;
        }
    }
    if (Newlength == 0) Console.WriteLine("[]");
    else
    {
        string[] Newstringarray = new string[Newlength];
        for (int i = 0; i < Newlength; i++)
        {
            Newstringarray[i] = Tempstringarray[i];
        }
        PrintArray(Newstringarray);
    }
}
void PrintArray(string[] stringarray)
{
    Console.Write("[");
    for (int i = 0; i < stringarray.Length - 1; i++)
    {
        Console.Write(stringarray[i] + ", ");
    }
    Console.Write(stringarray[stringarray.Length - 1] + "]");
}
SetDataArray();