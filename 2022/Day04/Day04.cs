namespace AdventOfCode2022
{
    class Day04 {         
        static void Main(string[] args)
        {
            int sum = 0; 
            string text = System.IO.File.ReadAllText(@"./day04-input.txt");
            string [] data = text.Split('\n');

            for(int i = 0; i < data.Length; i++)
            {
                string leftRange = data[i].Split(',')[0];
                string rightRange = data[i].Split(',')[1];

                if(int.Parse(leftRange.Split('-')[0]) <= int.Parse(rightRange.Split('-')[1]) &&
                   int.Parse(rightRange.Split('-')[0]) <= int.Parse(leftRange.Split('-')[1]))
                {
                    //Console.WriteLine("LEFT CONTAINS RIGHT at " + i);
                    sum++;
                }
                // else if(int.Parse(leftRange.Split('-')[0]) >= int.Parse(rightRange.Split('-')[1]) &&
                //    int.Parse(rightRange.Split('-')[1]) <= int.Parse(leftRange.Split('-')[1]))
                // {
                //     Console.WriteLine("RIGHT CONTAINS LEFT at " + i);
                //     sum++;
                // }
            }

            Console.WriteLine("TOTAL SUM: " + sum);
        }
    }
}