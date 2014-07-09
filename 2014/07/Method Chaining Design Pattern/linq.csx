using System;
using System.Diagnostics;

var query = Process.GetProcesses()
                   .Where(p => p.Threads.Count > 5)
                   .OrderBy(p => p.ProcessName)
                   .Select(p => p.ProcessName);

int counter = 1;

foreach (var process in query)
{
    Console.WriteLine("{0}: {1}", counter, process);
    counter += 1;
}

Console.WriteLine();