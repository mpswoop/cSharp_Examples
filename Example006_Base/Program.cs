﻿int a = 1;
int b = 8;
int c = 2;
int d = 7;
int e = 6;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.WriteLine("max = ");
Console.WriteLine(max);
