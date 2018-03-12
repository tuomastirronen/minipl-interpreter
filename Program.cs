﻿using System;

using MiniPL;

namespace Compiler
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser p = new Parser(new Scanner(new Source(args[0])));
               
            Node root = p.parse();
            // Console.WriteLine("AST: " + root.displayNode());
        }
    }
}
