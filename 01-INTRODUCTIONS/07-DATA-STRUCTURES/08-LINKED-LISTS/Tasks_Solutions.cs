using System;
using System.Collections.Generic;

var list = new LinkedList<int>(new[] { 1, 2, 3, 4, 5 });
list.AddFirst(0);
list.AddLast(6);
list.Remove(3);
for (var node = list.First; node != null; node = node.Next)
    Console.WriteLine(node.Value);
