using System;
int[] a={4,2,1,7,8,1};
int k=2,sum=a[0]+a[1],best=sum;
for(int i=k;i<a.Length;i++){sum+=a[i]-a[i-k]; best=Math.Max(best,sum);}
Console.WriteLine(best);
