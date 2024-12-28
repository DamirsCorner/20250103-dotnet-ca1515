using System.Runtime.CompilerServices;
using Ca1515Warnings;

[assembly: InternalsVisibleTo("Ca1515Warnings.Tests")]

var calculator = new Calculator();
calculator.Add(42);
Console.WriteLine(calculator.Value);
