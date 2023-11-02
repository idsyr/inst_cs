using System;
using System.Text;
class Program 
{
    public static void Main() 
    {
        Console.WriteLine("_____________________________EX1____________________________");
        string[] lines = new string[]{"Gjgrf juehwf", "rfhnjirf ,fhcerf"};
        Console.WriteLine(DecodeMessage(lines));
        Console.WriteLine("");

        Console.WriteLine("_____________________________EX2____________________________");
        Console.WriteLine("Решения до 3 в этом файле в виде функций")
    }

    public static string DecodeMessage(string[] lines)
    {
        List<string> result = new List<string>();
        for(int i = 0; i<lines.Length; i++)
        {
            lines[i]=" "+lines[i]+" ";
            string local = lines[i];
            for(int k = 0; k<local.Length-1; k++)
            {
                string el = "";
                if(local[k]==' ' && Char.IsUpper(local[k+1]))
                {
                    k++;
                    while (local[k]!=' ' && k<local.Length)
                    {
                         el += local[k];
                         k++;
                    }                   
                }
                if(el.Length>0)
                    result.Add(el);
            }
        }
        string answer = "";
        for (int i = 0; i<result.Count; i++)
        {
            answer += result[i];
        }
        return answer;
    }

    private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
    {
        var dictionary = new Dictionary<string, List<string>>();
        foreach (var contact in contacts) 
	    {
		    var name = contact.Substring(0, 2).Replace(":", "");
		    if (!dictionary.ContainsKey(name))
			    dictionary[name] = new List<string>();
		    dictionary[name].Add(contact);
	    }
        return dictionary;
    }

    private static string ApplyCommands(string[] commands)
    {
        var answer = new StringBuilder();
        foreach (var line in commands){if(line[1]=='u'){answer.Append(line.Substring(5));break;}else{answer.Length -= int.Parse(line.Substring(4));break;}}
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        return answer.ToString();
    }


}
