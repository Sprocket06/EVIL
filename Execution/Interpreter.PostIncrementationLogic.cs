﻿using EVIL.Abstraction;
using EVIL.AST.Nodes;

namespace EVIL.Execution
{
    public partial class Interpreter
    {
        public override DynValue Visit(IncrementationNode incrementationNode)
        {
            var numValue = Visit(incrementationNode.Target);

            if (numValue.Type != DynValueType.Number)
            {
                throw new RuntimeException(
                    "Cannot increment this value because it's not a number.", incrementationNode.Line
                );
            }

            if (incrementationNode.IsPrefix)
            {
                numValue.CopyFrom(new DynValue(numValue.Number + 1));
                return numValue;
            }
            else
            {
                var retVal = numValue.Copy();
                numValue.CopyFrom(new DynValue(numValue.Number + 1));

                return retVal;
            }
        }
    }
}