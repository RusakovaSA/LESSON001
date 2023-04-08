// Задача с гирями

int a = 4;
int b = 7;
int c = 1;
int d = 3;
int e = 5;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write ("Самая большая гиря весит ");
Console.WriteLine (max);