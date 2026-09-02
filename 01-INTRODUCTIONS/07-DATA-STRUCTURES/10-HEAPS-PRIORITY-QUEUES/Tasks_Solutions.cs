using System;
using System.Collections.Generic;

var jobs = new PriorityQueue<string, int>();
jobs.Enqueue("backup", 3);
jobs.Enqueue("security alert", 1);
jobs.Enqueue("report", 2);
while (jobs.TryDequeue(out var job, out var priority))
    Console.WriteLine($"{priority}: {job}");
