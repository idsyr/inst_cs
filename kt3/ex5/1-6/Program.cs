using System;

					
public class Program
{
    public enum Suits
    {
        Wands,
        Coins,
        Cups,
        Swords
    }

    public enum Mark
    {
        Empty,
        Cross,
        Circle
    }
    public enum GameResult
    {
        CrossWin,
        CircleWin,
        Draw
    }

	public static void Main()
	{
		Console.WriteLine("Практическя работа №5: Массивы.");
        Console.WriteLine("");

        Console.WriteLine("_________________EX1.1__________________");
        int[] EX1a_arg = GetFirstEvenNumbers(6);
        foreach (int i in EX1a_arg)
            Console.WriteLine(i);
        Console.WriteLine("");

        Console.WriteLine("_________________EX1.2__________________");
        int[] EX1b_arg = new int[] {1, 1, 2, 1};
        Console.WriteLine(GetElementCount(EX1b_arg, 1));
        Console.WriteLine("");

        Console.WriteLine("_________________EX2____________________");
        double[] EX2_arg = new double[] {1, 2, 3, 5, 4};
        Console.WriteLine(Max(EX2_arg));
        Console.WriteLine("");

        Console.WriteLine("_________________EX3____________________");
        int[] array = new int[] {1,2,3,4,3,4};
        int[] subArray = new int[] {3,4};
        Console.WriteLine(FindSubarrayStartIndex(array, subArray));
        Console.WriteLine("");

        Console.WriteLine("_________________EX4____________________");
        Console.WriteLine(GetSuit(Suits.Wands));
        Console.WriteLine(GetSuit(Suits.Coins));
        Console.WriteLine(GetSuit(Suits.Cups));
        Console.WriteLine(GetSuit(Suits.Swords));
        Console.WriteLine("");

        Console.WriteLine("_________________EX5____________________");
        var arrayToPower = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};
        PrintArray(GetPoweredArray(arrayToPower, 1));
        PrintArray(GetPoweredArray(arrayToPower, 2));
        PrintArray(GetPoweredArray(arrayToPower, 3));
        Console.WriteLine("");

        Console.WriteLine("_________________EX6____________________");
        Run("XXX OO. ...");
        Run("OXO XO. .XO");
        Run("OXO XOX OX.");
        Run("XOX OXO OXO");
        Run("... ... ...");
        Run("XXX OOO ...");
        Run("XOO XOO XX.");
        Run(".O. XO. XOX");
        Console.WriteLine("");
	}


    public static int[] GetFirstEvenNumbers(int count)
    {
        int[] answer = new int[count];
        for(int i = 0; i<count; i++)
        {
            answer[i] = (i+1)*2;
        }
        return answer;
    }


    public static int GetElementCount(int[] items, int itemCount)
    {   
        int answer = 0;
        for(int i = 0; i<items.Length; i++)
        {
            if(items[i] == itemCount)
            answer++;
        }
        return answer;
    }


    public static int Max(double[] array)
    {
        if(array.Length==0)
        {
            return -1;
        }
        int index = 0;
        double maxResult = 0;
        for(int i = 0; i< array.Length; i++)
        {
            if(array[i]>maxResult)
            {
                maxResult = array[i];
                index = i;
            }
        }
        return index;
    }


    public static int FindSubarrayStartIndex(int[] array, int[] subArray)
    {
        for(int i = 0; i < array.Length; i++)
        {
            for(int k = 0; k < subArray.Length && i+k < array.Length; k++)
            {
                if(array[i+k]!=subArray[k])
                {
                    break;
                }
                if(subArray.Length-1==k)
                {
                    return i;
                }
            }
        }
        return -1;
    }


    public static string GetSuit(Suits suit)
    {
        string[] answer = new string[] {"жезлов", "монет", "кубков", "мечей"};
        return answer[(int)suit];
    }

  public static void PrintArray(int[] array)
    {
        for (int i = 0; i< array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("");
    }

    public static int[] GetPoweredArray (int[] array, int multi)
    {
        int[] array2 = new int[array.Length];
        for (int i = 0; i< array2.Length; i++)
            array2[i] = Convert.ToInt32(Math.Pow(Convert.ToDouble(array[i]), Convert.ToDouble(multi)));

        return array2;
    }

    private static void Run(string description)
    {
        Console.WriteLine(description.Replace(" ", Environment.NewLine));
        Console.WriteLine(GetGameResult(CreateFromString(description)));
        Console.WriteLine();
    }
    private static Mark[,] CreateFromString(string str)
    {
        var field = str.Split(' ');
        var ans = new Mark[3, 3];
        for (int x = 0; x < field.Length; x++)
            for (var y = 0; y < field.Length; y++)
                ans[x, y] = field[x][y] == 'X' ? Mark.Cross: (field[x][y] == 'O' ? Mark.Circle : Mark.Empty);
        return ans;
    }

public static GameResult GetGameResult(Mark[,] field)
{
    bool CrossWin = false;
    bool CircleWin = false;

    for(int i = 0;i<3; i++)
    {
        if(field[i,0]==field[i,1] && field[i,1]==field[i,2])
        {
            if(field[i,0]==Mark.Circle)
                CircleWin = true;
            if(field[i,0]==Mark.Cross)
                CrossWin = true;
        }
    }
    
    for(int i = 0;i<3; i++)
    {
        if(field[0,i]==field[1,i] && field[1,i]==field[2,i])
        {
            if(field[0,i]==Mark.Circle)
                CircleWin = true;
            if(field[0,i]==Mark.Cross)
                CrossWin = true;
        }
    }

    if(field[0,0]==field[1,1] && field[1,1]==field[2,2])
    {
        if(field[0,0]==Mark.Circle)
            CircleWin = true;
         if(field[0,0]==Mark.Cross)
            CrossWin = true;
    }

    if(field[0,2]==field[1,1] && field[1,1] == field[2,0])
    {
        if(field[0,0]==Mark.Circle)
            CircleWin = true;
        if(field[0,0]==Mark.Cross)
            CrossWin = true;
    }

    if(CrossWin==CircleWin)
        return GameResult.Draw;
    if(CrossWin)
        return GameResult.CrossWin;
    if(CircleWin)
        return GameResult.CircleWin;
    return GameResult.Draw;
}







}