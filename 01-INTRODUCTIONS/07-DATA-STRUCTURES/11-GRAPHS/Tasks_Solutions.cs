using System;
using System.Collections.Generic;

var graph = new Dictionary<string, List<string>>
{
    ["A"] = new() { "B", "C" },
    ["B"] = new() { "D" },
    ["C"] = new(),
    ["D"] = new()
};

var q = new Queue<string>();
var seen = new HashSet<string>();
q.Enqueue("A");
seen.Add("A");

while (q.Count > 0)
{
    var node = q.Dequeue();
    Console.WriteLine(node);
    foreach (var n in graph[node])
        if (seen.Add(n)) q.Enqueue(n);
}
