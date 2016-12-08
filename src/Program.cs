using System;

namespace StringSumKata

{
    public class Program
    {
        public static void Main(string[] args)
        {
            int result = 0;
            if(args.Length == 1){
                string[] values = args[0].Split(',');
                foreach (var @value in values)
                {
                    result += int.Parse(@value);
                }
            }
            
            Console.Write(result);
        }
    }
}
