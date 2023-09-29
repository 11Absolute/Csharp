
bool isContinue;

do
{
    Console.WriteLine("Ширина?");
    int.TryParse(Console.ReadLine(), out int W);

    Console.WriteLine("Высота?");
    int.TryParse(Console.ReadLine(), out int H);

    Console.WriteLine("Символ рисования?");
    string symbol = Console.ReadLine();

    Console.WriteLine("Заполнить фигуру? [Y/N] ->");
    string YorN = Console.ReadLine();

    if (YorN.Equals("Y", StringComparison.OrdinalIgnoreCase) ||
            YorN.Equals("Yes", StringComparison.OrdinalIgnoreCase))
    {
        for (int k = 0; k < H; k++)
        {
            for (int i = 0; i < W; i++)
            {
                if (k == 0 || k == H - 1) Console.Write(symbol);
                else if (i == 0 || i == W - 1) Console.Write(symbol);
                else Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }
    else if (YorN.Equals("N", StringComparison.OrdinalIgnoreCase) ||
        YorN.Equals("NO", StringComparison.OrdinalIgnoreCase))
    {
        {
            for (int k = 0; k < H; k++)
            {
                for (int i = 0; i < W; i++)
                {
                    if (k == 0 || k == H - 1) Console.Write(symbol);
                    else if (i == 0 || i == W - 1) Console.Write(symbol);
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное значение");
    }
    Console.WriteLine("Повторить? [Y/N] ->");
    isContinue = Console.ReadLine().ToUpper() == "Y";

} while (isContinue);