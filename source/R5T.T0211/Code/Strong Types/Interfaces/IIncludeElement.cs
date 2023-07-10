using System;
using System.Xml.Linq;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0211
{
    /// <summary>
    /// Strongly-types a XElement as a &lt;include&gt; tag in an XML documentation comment.
    /// <para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#include</para>
    /// </summary>
    [StrongTypeMarker]
    public interface IIncludeElement : IStrongTypeMarker,
        ITyped<XElement>
    {
    }
}