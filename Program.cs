Console.WriteLine($"Введите на экран те элементы нашего массива, размер которых будет равен или меньше заданного");
Console.WriteLine("Введите какое количество символов в нашем элементе будет контрольным");
int sizeStr= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество слов, которое вы хотите проверить");
int quantity= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Необходимые слова введите через ENTER");
string[]words= new string[quantity]; //создали массив из строчных элементов
for(int k=0; k<quantity; k++)
{
    words[k]= Console.ReadLine();
}
int count=0;
for(int i=0; i<words.Length; i++)  //проверка на количество символов в каждом элементе
{
    if(words[i].Length<sizeStr)
    {
        count++;
    }
}
string[] normalWords = new string [count];    //контрольный массив
int l=0;
for(int j=0; j< words.Length; j++)
{
    if (words[j].Length < sizeStr)
    {
        normalWords[l]=words[j];
        l++;
    }
}
Console.WriteLine("Ваш введенный массив выглядит так: ");
Console.WriteLine(String.Join(", ", words));
Console.WriteLine($"Массив , каждый элемент которого по длине меньше или равен {sizeStr} выглядит так: ");
Console.WriteLine (String.Join(", ", normalWords));  //вывод контрольного массива
