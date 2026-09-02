using System;
using System.Collections.Generic;

var list = new LinkedList<string>();
list.AddLast("A");
list.AddLast("B");
list.AddFirst("Start");
foreach (var item in list) Console.WriteLine(item);
