using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextFreeGrammar.СSharp.Nonterminals;
internal class TNonterminal : INonteminal
{
    public bool TryParse(out IEnumerable<Node> nods, string input)
    {
        int multIndex = input.LastIndexOf("*");
        if (multIndex == -1)
        {
            nods = new Node[]{new Node(new PNonterminal(), input),};
            return true;
        }

        nods = new Node[]
        {
            new Node(new TNonterminal(), input.Substring(0, multIndex)),
            new Node(new PNonterminal(), input.Substring(multIndex + 1)),
        };
        return true;
    }

    public override string ToString()
    {
        return "<T>";
    }
}
