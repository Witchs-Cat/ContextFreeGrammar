using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextFreeGrammar.СSharp.Nonterminals;

internal class SNonterminal : INonteminal
{
    public bool TryParse(out IEnumerable<Node> nods, string input)
    {
        input = input.Replace(" ", "");

        if (String.IsNullOrEmpty(input))
        {
            nods = Array.Empty<Node>();
            return false;
        }

        nods = new Node[] { new Node(new ENonterminal(), input) };

        return true;
    }

    public override string ToString()
    {
        return "<S>";
    }
}

