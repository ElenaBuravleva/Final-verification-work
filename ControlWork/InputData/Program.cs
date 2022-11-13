void InputData()
{
    Console.WriteLine("Чтобы ввести массив строк, вводите строку и нажмите <enter>");
    string[] stringarray = new string[15];
    int Nsimbol = 3;
    int count = 0;
    string str = "1";
    while (str != "q")
    {
        str = Console.ReadLine();
        if (str != " "
         && str != "  "
         && str != "   "
         && str != "q" 
         && str != "" 
         && str.Length <= Nsimbol 
         && count < 15)
        {
            stringarray[count] = str;
            count++;
        }
        Console.WriteLine("Введите следующую строку или <q>, чтобы закончить ввод");
    }
    if (count == 0) Console.WriteLine("Введенный массив не содержит строки, длина которых меньше либо равна 3 символа");
    else
    {
        string[] Newstringarray = new string[count];
        for (int i = 0; i < count; i++)
        {
            Newstringarray[i] = stringarray[i];
        }
        Console.Write("Сформирован массив ");
        PrintArray(Newstringarray);
        Console.WriteLine();
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
InputData();
