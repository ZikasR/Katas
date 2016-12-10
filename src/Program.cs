using System;
using System.Collections.Generic;
using System.Linq;

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

                List<int> numbers = getIntegersFromString(args[0], delimiters.ToArray());

                List<int> negativeNumbers = numbers.Where(n=> n<0).ToList();

                if(negativeNumbers.Count > 0){
                    throw new ArgumentException("negatives not allowed : " + string.Join(",", negativeNumbers.ToArray()));
                }

                foreach (var @value in numbers)
                {
                    result += @value;
                }
            }
            
            Console.Write(result);
        }

        private static List<int> getIntegersFromString(string values, char[] delimiters){

            string[] stringValues = values.Split(delimiters);
            List<int> result = new List<int>();
            int integerValue;

            foreach (string item in stringValues)
            {
                if(int.TryParse(item, out integerValue))
                {                
                    result.Add(integerValue);
                }
            }

            return result;        

        }
    }
}
