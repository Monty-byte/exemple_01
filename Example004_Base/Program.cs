int a = 1;
int b = 2;
int s = 6;
int d = 8;
int e = 4;

int max = a;

if(a > max) max = a;
if (b > max) max = b;
if (s > max) max = s;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);