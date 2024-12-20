using NonRecursiveFunctionalGrammarParser;

Console.WriteLine("tests: NonRecursiveFunctionalGrammarParser");

var file = Path.Combine(Directory.GetCurrentDirectory(),
    "..","..","..","..","..",
    "grammars",
    "ansi.txt"
    );

var gramar = File.ReadAllLines(file);

var parser = new Parser(gramar);

var end = true;
