// See https://aka.ms/new-console-template for more information
using Singleton;

Console.WriteLine("Hello, World!");

Counter First=Counter.GetInstance();
Counter Second=Counter.GetInstance();
First.AddOne();
Second.AddOne();

Console.WriteLine("First:"+First.counter);
Console.WriteLine("Second:"+Second.counter);


Second.AddOne();

Console.WriteLine("First:" + First.counter);
Console.WriteLine("Second:" + Second.counter);
