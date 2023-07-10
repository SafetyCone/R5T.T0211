using System;


namespace R5T.T0211.F000
{
    public class InheritdocElementOperator : IInheritdocElementOperator
    {
        #region Infrastructure

        public static IInheritdocElementOperator Instance { get; } = new InheritdocElementOperator();


        private InheritdocElementOperator()
        {
        }

        #endregion
    }
}
