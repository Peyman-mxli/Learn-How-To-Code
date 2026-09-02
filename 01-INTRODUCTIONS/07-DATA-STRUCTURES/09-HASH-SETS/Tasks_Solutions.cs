using System;
using System.Collections.Generic;

var a = new HashSet<int> { 1, 2, 3, 4 };
var b = new HashSet<int> { 3, 4, 5 };
a.IntersectWith(b);
Console.WriteLine(string.Join(", ", a));
