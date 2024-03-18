namespace ContextFreeGrammar.СSharp
{
    internal interface INonteminal
    {
        bool TryParse(out IEnumerable<Node> nodes, string input);
    }
}