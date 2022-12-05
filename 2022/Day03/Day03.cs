namespace AdventOfCode2022
{
    class Day03 {         
        static void Main(string[] args)
        {
            int sum = 0; 
            string text = System.IO.File.ReadAllText(@"./input.txt");
            string [] data = text.Split('\n');
            string [] totalValues = new string [data.Length];

            // for (int i = 0; i < data.Length; i++)
            // {
            //     string first = data[i].Substring(0, (int)(data[i].Length/2));
            //     string last = data[i].Substring((int)(data[i].Length/2), (int)(data[i].Length/2));

            //     //totalValues[i] = GetRepeatedValues(first, last);

            //     sum += GetLetterValues(totalValues[i].ToCharArray()[0]);
            //     //sum += GetLetterValues(first.Intersect(last).First());
            // }

            for (int i = 0; i < data.Length; i+= 3)
            {
                string first    = data[i];
                string second   = data[i+1];
                string third    = data[i+2];

                //totalValues.Add(GetRepeatedValues(first, second, third));

                totalValues[i] = GetRepeatedValues(first, second, third);

                sum += GetLetterValues(totalValues[i].ToCharArray()[0]);
            }

            System.Console.Write("TOTAL: " + sum);
        }

        public static int GetLetterValues(char _letter)
        {
            int result = 0;
            if(char.IsUpper(_letter))
            {
                result = (char.ToLower(_letter) - 'a') + 27;
            }

            else
            {
                result = _letter - 'a' + 1;
            }

            return result;
        }

        public static string GetRepeatedValues(string _first, string _last)
        {
            string repeatedValues = "";
            
            for (int i = 0; i < _first.Length; i++)
            {
                char current = _first.ToCharArray()[i];
                if(_last.Contains(current))
                {
                    repeatedValues += current;
                }
            }

            return repeatedValues;
        }

        public static string GetRepeatedValues(string _first, string _second, string _third)
        {
            string repeatedValues = "";
            
            for (int i = 0; i < _first.Length; i++)
            {
                char current = _first.ToCharArray()[i];
                if(_second.Contains(current) && _third.Contains(current))
                {
                    repeatedValues += current;
                }
            }

            return repeatedValues;
        }
    }
}