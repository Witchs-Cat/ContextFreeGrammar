// See https://aka.ms/new-console-template for more information
using ContextFreeGrammar.СSharp;
using ContextFreeGrammar.СSharp.Nonterminals;

Node node = new(new SNonterminal(), "1*2*3*фис");
Console.WriteLine(node.TryGrow());
Console.ReadLine();