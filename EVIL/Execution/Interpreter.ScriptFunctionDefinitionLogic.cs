﻿using EVIL.Abstraction;
using EVIL.AST.Nodes;

namespace EVIL.Execution
{
    public partial class Interpreter
    {
        public override DynValue Visit(FunctionDefinitionNode scriptFunctionDefinitionNode)
        {
            var name = scriptFunctionDefinitionNode.Name;

            if (name != null)
            {
                Environment.RegisterFunction(
                    name,
                    new ScriptFunction(
                        scriptFunctionDefinitionNode.StatementList,
                        scriptFunctionDefinitionNode.ParameterNames
                    )
                );

                return DynValue.Zero;
            }

            return new DynValue(
                new ScriptFunction(
                    scriptFunctionDefinitionNode.StatementList,
                    scriptFunctionDefinitionNode.ParameterNames
                )
            );
        }
    }
}