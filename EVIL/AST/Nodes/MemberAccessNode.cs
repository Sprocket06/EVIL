using EVIL.AST.Base;

namespace EVIL.AST.Nodes
{
    public class MemberAccessNode : AstNode
    {
        public AstNode Indexable { get; }
        public string Identifier { get; }

        public MemberAccessNode(AstNode indexable, string identifier)
        {
            Indexable = indexable;
            Identifier = identifier;
        }
    }
}