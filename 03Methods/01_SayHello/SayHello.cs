﻿using System;

class SayHello
{
    public static void sayHello()
    {
        Console.WriteLine("What's your name ?");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}", name);
    }
    static void Main()
    {
        sayHello();
    }
}