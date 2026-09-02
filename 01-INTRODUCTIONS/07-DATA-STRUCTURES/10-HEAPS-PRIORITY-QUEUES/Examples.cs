using System;
using System.Collections.Generic;

var queue = new PriorityQueue<string, int>();
queue.Enqueue("low", 3);
queue.Enqueue("urgent", 1);
queue.Enqueue("normal", 2);
while (queue.Count > 0) Console.WriteLine(queue.Dequeue());
