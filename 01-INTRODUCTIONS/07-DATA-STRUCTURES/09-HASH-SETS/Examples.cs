using System;
using System.Collections.Generic;

var tags = new HashSet<string> { "python", "csharp", "python" };
Console.WriteLine(tags.Count);
Console.WriteLine(tags.Contains("csharp"));
