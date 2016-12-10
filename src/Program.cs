using System;
using System.Collections.Generic;

namespace StringSumKata

{
    public class Program
    {
        public static void Main(string[] args)
        {
            int result = 0;
            char delimiter;
            List<char> delimiters = new List<char>(){',', '\n'};
            if(args.Length == 1){
                if(args[0].ToCharArray().Length > 2){
                                    if(args[0].Substring(0,2) == "//")
                {
                    delimiter = args[0].Substring(2, 1).ToCharArray()[0];
                    delimiters.Add(delimiter);
                }
                }

                string[] values = args[0].Split(delimiters.ToArray());
                int integerValue;

                foreach (var @value in values)
                {
                    if(int.TryParse(@value, out integerValue))
                    result += integerValue;
                }
            }
            
            Console.Write(result);
        }
    }
}
