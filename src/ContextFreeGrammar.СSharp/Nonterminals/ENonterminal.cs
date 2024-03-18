using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextFreeGrammar.СSharp.Nonterminals;

internal class ENonterminal : INonteminal
{
    public bool TryParse(out IEnumerable<Node> nods, string input)
    {
        int plusIndex = input.LastIndexOf("+");
        if (plusIndex == -1)
        {
            nods = new Node[] { new Node(new TNonterminal(), input) };
            return true;
        }

        nods = new Node[]
        {
            new Node(new ENonterminal(), input.Substring(0, plusIndex)),
            new Node(new TNonterminal(), input.Substring(plusIndex + 1)),
        };
        return true;
    }

    public override string ToString()
    {
        return "<E>";
    }
}

