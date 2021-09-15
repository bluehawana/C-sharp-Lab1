using System;
class StringLength
{
    static void Main(string[] args)
    {

        string str = "29535123p48723487597645723645";
        string newStr = "";
        string newStr1 = "";
        String newStr2 = "";
        long sum =0;
        for (int i = 0; i < str.Length - 1; i++)
        {
            for (int j = i; j < str.Length - 1; j++)
            {
                if (Char.IsDigit(str[i]))
                {
                    if (!Char.IsDigit(str[j]))
                    {
                        break;
                    }

                    if (str[i] == str[j] && j != i)
                    {
                        long result;
                        long.TryParse(newStr, out result);
                        sum += result;

                        newStr = str.Substring(i, j - i + 1);
                        newStr1 = str.Substring(0, str.IndexOf(newStr));
                        newStr2 = str.Substring(newStr.Length + newStr1.Length, (str.Length) -(newStr.Length + newStr1.Length));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(newStr1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(newStr);
                        Console.ResetColor();
                        Console.WriteLine(newStr2);
                       
                        break;
                    }

                    

                }


            }
            
        }
        Console.WriteLine();
        Console.ResetColor();
        Console.WriteLine("The total sum of green numbers is ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(sum);
        Console.WriteLine();
        Console.ForegroundColor=ConsoleColor.White;
    }
}