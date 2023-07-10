using System;
using System.Xml.Linq;

using R5T.T0132;


namespace R5T.T0211.Extensions
{
    [FunctionalityMarker]
    public partial interface IXAttributeOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="ICRefAttribute"/>
        public ICRefAttribute ToCRefAttribute(XAttribute value)
        {
            var output = new CRefAttribute(value);
            return output;
        }

        /// <inheritdoc cref="IHRefAttribute"/>
        public IHRefAttribute ToHRefAttribute(XAttribute value)
        {
            var output = new HRefAttribute(value);
            return output;
        }
    }
}
