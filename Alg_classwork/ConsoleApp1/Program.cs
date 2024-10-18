using System;
using System.Collections.Generic;


CustomDictionary<string, int> customDictionary = new CustomDictionary<string, int>();
customDictionary.Add("One", 1);
customDictionary.Add("Two", 2);
customDictionary.Add("Three", 3);

Console.WriteLine("Custom Dictionary:");
customDictionary.Display();
Console.WriteLine($"Get 'Two': {customDictionary.Get("Two")}");
customDictionary.Remove("Two");
customDictionary.Display();


int[] array = { 9, 8, 3, 7, 5, 6, 4, 1 };
Sorter sorter = new Sorter();

Console.WriteLine("\nArray before sorting:");
sorter.PrintArray(array);

sorter.ShellSort(array);

Console.WriteLine("Array after Shell Sort:");
sorter.PrintArray(array);