* Create a .NET Framework “Hello world” console application using the code below
```
using System;

namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world");
            Console.ReadKey();
        }
    }
}
```

* Run the application in the IDE
* Build the application and run it from the /bin/Debug or /bin/Release directory, outside Visual Studio

Challenge: Add a Debug.WriteLine() statement to the code, run the application in the debuggger, and find your debug statement in the output pane
