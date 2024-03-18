using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextFreeGrammar.СSharp.Nonterminals;

internal class PNonterminal : INonteminal
{
    public bool TryParse(out IEnumerable<Node> nods, string input)
    {
        nods = Array.Empty<Node>();
        if (input.Length < 1)
            return false;
        return !(input.Contains('*') || input.Contains('+'));
    }

    public override string ToString()
    {
        return "<P>";
    }
}
