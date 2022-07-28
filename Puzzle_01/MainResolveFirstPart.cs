namespace AdventOfCode.Puzzle_01
{
    public class MainResolveFirstPart
    {
        static void Main(string[] args)
        {
            var fileData = new StreamReader("D:/ProyectosProgramacion/Visual/AdventOfCode/Puzzle_01/input.txt");
            var result = fileData.ReadToEnd();

            var dataArray = result.Split('\n');

            string? previousData = null;
            int increases = 0;

            foreach(var d in dataArray)
            {
                if(previousData is null)
                {
                    previousData = d;
                }
                else
                {
                    if(Convert.ToInt32(d) > Convert.ToInt32(previousData) && (d != null))
                    {
                        increases++;
                    }

                    previousData = d;
                }
                if (d == null) { break; }
            }

            Console.WriteLine(increases);
            Console.ReadLine();
        }
    }
}