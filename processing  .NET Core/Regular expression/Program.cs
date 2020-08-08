using System;
using System.Text.RegularExpressions;

namespace Regular_expression
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  // 1. Regex.IsMatch(string regex)-> boolean

              string name = "Information123technology";
              bool match = Regex.IsMatch(name,@"^\w+\d+\w+$");
              Console.WriteLine("Output:  "+match);

              // 2. Regex.Split(string,string) -> divide a string into substring-> return array

              string text = "this\t\t is \n my \t text";
              Console.WriteLine(text);

              // defined as a regex
              String regex = @"\s+";

              String[] substring = Regex.Split(text, regex);

              Console.WriteLine("The length of substring is " + substring.Length);
              Console.WriteLine("The elements of substring including: \n");
              foreach(string str in substring)
              {
                  Console.WriteLine(str);
              }

              // 3. Regex.Replace -> return new string
              Console.WriteLine("Replace text by new text: ");
              string newText = Regex.Replace(text, @"\s", "\n");
              Console.WriteLine(newText);

              // 4. MathCollection & Match method (*)
              // fuction: We use it to search substrings of a string matching with regex 
              // expression and this method returns MathCollection which is an object
              Console.WriteLine("------ 4--------");
              string regex_expression = @"\w+";
              string TEXT = "This \t is a \t\t\t String";
              MatchCollection matchColl = Regex.Matches(TEXT, regex_expression);

              foreach(Match a in matchColl)
              {
                  Console.WriteLine("***********");
                  Console.WriteLine("Value: " + a.Value);
                  Console.WriteLine("Index: " + a.Index);
                  Console.WriteLine("Length: " + a.Length);
              }

              // 5. Group
              // a regex that you can split lots of group.

              string regex1 = @"\s+=\d+";
              string regex2 = @"(\s)(=)(\d+)"; // regex1 is written 3 groups by ()
            */

            string TEXT = " int a = 100;  float b= 130;  float c= 110 ; ";

            // Sử dụng (?<groupName>pattern) để định nghĩa một Group có tên: groupName
            // Định nghĩa group có tên 'declare': sử dụng (?<declare> ...)
            // Và một group có tên 'value': sử dụng: (?<value> ..)
            string regex = @"(?<declare>\s*(int|float)\s+[a-z]\s*)=(?<value>\s*\d+\s*);";

            MatchCollection matchCollection = Regex.Matches(TEXT, regex);


            foreach (Match match in matchCollection)
            {
                string group = match.Groups["declare"].Value;
                Console.WriteLine("Full Text: " + match.Value);
                Console.WriteLine("<declare>: " + match.Groups["declare"].Value);
                Console.WriteLine("<value>: " + match.Groups["value"].Value);
                Console.WriteLine("------------------------------");
            }

            Console.Read();


        }
    }
}
