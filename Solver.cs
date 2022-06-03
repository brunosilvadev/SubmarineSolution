public class Solver{
    public string Solve() {
        int horizontal = 0;
        int vertical = 0;
        const string path = "instructions.txt";
        string[] readText = File.ReadAllLines(path);
        foreach(var s in readText){
            string[] instruction = s.Split(' ');
            if(instruction.Length > 0){
                switch (instruction[0]){
                    case "forward":
                    horizontal = horizontal + Convert.ToInt32(instruction[1]);
                    break;
                    case "down":
                    vertical = vertical - Convert.ToInt32(instruction[1]);
                    break;
                    case "up":
                    vertical = vertical + Convert.ToInt32(instruction[1]);
                    break;
                }
            }
        }
        return "The answer is ";
    }
}