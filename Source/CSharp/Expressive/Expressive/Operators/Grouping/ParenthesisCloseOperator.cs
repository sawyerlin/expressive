﻿using Expressive.Expressions;

namespace Expressive.Operators.Grouping
{
    internal class ParenthesisCloseOperator : OperatorBase
    {
        #region OperatorBase Members

        public override string[] Tags { get { return new[] { ")" }; } }

        public override IExpression BuildExpression(string previousToken, IExpression[] expressions)
        {
            return expressions[0] ?? expressions[1];
        }

        public override OperatorPrecedence GetPrecedence(string previousToken)
        {
            return OperatorPrecedence.ParenthesisClose;
        }

        #endregion
    }
}