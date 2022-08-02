const string path = @"../../../instructions.txt";

var s = new Solver(path);
Console.WriteLine(s.SolveFirstPuzzle());
Console.WriteLine(s.SolveSecondPuzzle());
