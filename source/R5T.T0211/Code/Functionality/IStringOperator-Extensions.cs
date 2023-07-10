using System;

using R5T.T0132;


namespace R5T.T0211.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IXmlDocumentationComment"/>
        public IXmlDocumentationComment ToXmlDocumentationComment(string value)
        {
            var output = new XmlDocumentationComment(value);
            return output;
        }
    }
}
