public class Solver{

    private string[] readFile { get; set; }

    public Solver(string path)
    {
        this.readFile = File.ReadAllLines(path);
    }    

    public string SolveFirstPuzzle() {
        long horizontal = 0;
        long vertical = 0;        

        foreach(var s in this.readFile){
            string[] instruction = s.Split(' ');
            if(instruction.Length > 0){
                long command = Convert.ToInt64(instruction[1]);
                switch (instruction[0]){
                    case "forward":
                    horizontal += command;
                    break;
                    case "down":
                    vertical += command;
                    break;
                    case "up":
                    vertical -= command;
                    break;
                }
            }
        }


        return "Based on the first interpretation, the puzzle answer is " + (horizontal * vertical).ToString();
    }

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
                long command = Convert.ToInt64(instruction[1]);
                switch (instruction[0])
                {
                    case "forward":
                        horizontal += command;
                        depth += (aim * command);
                        break;
                    case "down":
                        aim += command;
                        break;
                    case "up":
                        aim -= command;
                        break;
                }
            }
        }

        return "Based on the second interpretation, the puzzle answer is " + (horizontal * depth).ToString();
    }
}
