using System;
using System.Collections.Generic;

var graph = new Dictionary<string, List<string>>
{
    ["A"] = new() { "B", "C" },
    ["B"] = new() { "A", "D" },
    ["C"] = new() { "A" },
    ["D"] = new() { "B" }
};

foreach (var neighbor in graph["A"]) Console.WriteLine(neighbor);
