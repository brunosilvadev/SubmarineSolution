public class Solver{

    private string[] readFile { get; set; }
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="path"></param>
    public Solver(string path)
    {
        this.readFile = File.ReadAllLines(path);
    }    
    /// <summary>
    /// Solution to the first challenge in the puzzle
    /// </summary>
    /// <returns></returns>
    public string SolveFirstPuzzle() {
        long horizontal = 0;
        long vertical = 0;        

        foreach(var s in this.readFile){
            string[] instruction = s.Split(' ');
            if(instruction.Length > 0){
                switch (instruction[0]){
                    case "forward":
                    horizontal = horizontal + Convert.ToInt64(instruction[1]);
                    break;
                    case "down":
                    vertical = vertical + Convert.ToInt64(instruction[1]);
                    break;
                    case "up":
                    vertical = vertical - Convert.ToInt64(instruction[1]);
                    break;
                }
            }
        }


        return "Based on the first interpretation, the puzzle answer is " + (horizontal * vertical).ToString();
    }
    /// <summary>
    /// Solution to the second challenge in the puzzle
    /// </summary>
    /// <returns></returns>
    public string SolveSecondPuzzle()
    {
        long horizontal = 0;
        long aim = 0;
        long depth = 0;

        foreach (var s in this.readFile)
        {
            string[] instruction = s.Split(' ');
            if (instruction.Length > 0)
            {
                switch (instruction[0])
                {
                    case "forward":
                        horizontal = horizontal + Convert.ToInt64(instruction[1]);
                        depth = depth + (aim * Convert.ToInt64(instruction[1]));
                        break;
                    case "down":
                        aim = aim + Convert.ToInt64(instruction[1]);
                        break;
                    case "up":
                        aim = aim - Convert.ToInt64(instruction[1]);
                        break;
                }
            }
        }

        return "Based on the second interpretation, the puzzle answer is " + (horizontal * depth).ToString();
    }
}