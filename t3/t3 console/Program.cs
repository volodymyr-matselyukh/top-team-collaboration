// See https://aka.ms/new-console-template for more information

using t3_proj;

var t3 = new Task3();
var array = Enumerable.Range(1, 100000).Select(i => 3).ToArray();
int average = 3;
var result = t3.Task3Function(array, average);
var expectedResult = 1000000000;
Console.WriteLine($"Actual Result: {result}");
Console.WriteLine($"Expected Result: {expectedResult}");
Console.WriteLine($"Success: {expectedResult == result}");
