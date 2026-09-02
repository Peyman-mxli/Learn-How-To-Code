using System;
int[] a = {1,2,3,4,6,8};
int l=0,r=a.Length-1;
while(l<r){int s=a[l]+a[r]; if(s==10){Console.WriteLine("Found"); break;} if(s<10)l++; else r--;}
