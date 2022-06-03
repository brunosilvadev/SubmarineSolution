public class Solver{
    public string Solve() {
        long horizontal = 0;
        long vertical = 0;
        const string path = @"../../../instructions.txt";
        string[] readText = File.ReadAllLines(path);

        foreach(var s in readText){
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
}