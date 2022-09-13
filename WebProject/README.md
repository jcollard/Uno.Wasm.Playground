# How it works:

First replace `Console.ReadLine()` with `(await Console.ReadLine())`

Then replace `Thread.Sleep` with `await WebThread.Sleep`