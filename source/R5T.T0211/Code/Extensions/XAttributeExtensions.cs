using System;
using System.Xml.Linq;


namespace R5T.T0211.Extensions
{
    public static class XAttribueExtensions
    {
        /// <inheritdoc cref="IXAttributeOperator.ToCRefAttribute(XAttribute)"/>
        public static ICRefAttribute ToCRefAttribute(this XAttribute value)
        {
            return Instances.XAttributeOperator_Extensions.ToCRefAttribute(value);
        }

        /// <inheritdoc cref="IXAttributeOperator.ToHRefAttribute(XAttribute)"/>
        public static IHRefAttribute ToHRefAttribute(this XAttribute value)
        {
            return Instances.XAttributeOperator_Extensions.ToHRefAttribute(value);
        }
    }
}
