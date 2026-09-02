using System;
using System.Collections.Generic;

var graph = new Dictionary<int,List<int>>
{
    [1]=new(){2,3}, [2]=new(){4}, [3]=new(), [4]=new()
};
var q=new Queue<int>();
var seen=new HashSet<int>{1};
q.Enqueue(1);
while(q.Count>0){var v=q.Dequeue(); Console.WriteLine(v); foreach(var n in graph[v]) if(seen.Add(n)) q.Enqueue(n);}
