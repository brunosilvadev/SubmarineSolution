const string path = @"../../../instructions.txt";

Solver s = new Solver(path);
Console.WriteLine(s.SolveFirstPuzzle());
Console.WriteLine(s.SolveSecondPuzzle());
