namespace AdventOfCode2022
{
    class Day05 {         
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"./day05-input.txt");
            string [] data = text.Split('\n');

            for(int i = 0; i < data.Length; i++)
            {
                string [] words = data[i].Split(' ');
                Console.WriteLine(words[1]);
            }
        }
    }
}