using System;


namespace R5T.T0211.Extensions
{
    public class XElementOperator : IXElementOperator
    {
        #region Infrastructure

        public static IXElementOperator Instance { get; } = new XElementOperator();


        private XElementOperator()
        {
        }

        #endregion
    }
}
