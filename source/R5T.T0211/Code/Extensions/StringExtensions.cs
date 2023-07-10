using System;


namespace R5T.T0211.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToXmlDocumentationComment(string)"/>
        public static IXmlDocumentationComment ToXmlDocumentationComment(this string value)
        {
            return Instances.StringOperator_Extensions.ToXmlDocumentationComment(value);
        }
    }
}
