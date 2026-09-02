using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

if (args.Length != 1)
{
    Console.Error.WriteLine("Usage: CSharpSyntaxValidator <directory>");
    return 2;
}

string root = Path.GetFullPath(args[0]);
if (!Directory.Exists(root))
{
    Console.Error.WriteLine($"Directory not found: {root}");
    return 2;
}

var files = Directory.GetFiles(root, "*.cs", SearchOption.AllDirectories)
    .OrderBy(path => path, StringComparer.OrdinalIgnoreCase)
    .ToList();

var failures = new List<string>();

foreach (string file in files)
{
    string source = File.ReadAllText(file);
    SyntaxTree tree = CSharpSyntaxTree.ParseText(source, path: file);

    foreach (Diagnostic diagnostic in tree.GetDiagnostics().Where(d => d.Severity == DiagnosticSeverity.Error))
        failures.Add(diagnostic.ToString());
}

if (failures.Count > 0)
{
    Console.Error.WriteLine("C# syntax errors found:");
    foreach (string failure in failures)
        Console.Error.WriteLine(failure);
    return 1;
}

Console.WriteLine($"C# syntax validation passed for {files.Count} files.");
return 0;
