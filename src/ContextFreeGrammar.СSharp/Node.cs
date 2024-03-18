using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextFreeGrammar.СSharp;

internal class Node
{
    private readonly List<Node> _childs;
    public readonly string Input;
    public readonly INonteminal Nonterminal;
    
    public Node(INonteminal nonterminal, string input)
    {
        Nonterminal = nonterminal;
        Input = input;
        _childs = new();
    }

    public bool TryGrow()
    {
        Stack<Node> nods = new();
        nods.Push(this);

        while (nods.TryPop(out Node? node)) {
            if (!node.Nonterminal
                    .TryParse(
                        out IEnumerable<Node> childs, 
                        node.Input))
                return false;
            
            foreach (Node child in childs)
                nods.Push(child);
            
            node.AddChilds(childs);
        }
        return true;
    }

    public void AddChilds(IEnumerable<Node> childs)
        => _childs.AddRange(childs);

    public override string ToString()
    {
        return $"{Nonterminal} = {Input}";
    }
}
