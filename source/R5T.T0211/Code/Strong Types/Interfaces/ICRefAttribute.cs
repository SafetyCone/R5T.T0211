using System;
using System.Xml.Linq;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0211
{
    /// <summary>
    /// Strongly-types a XAttribute as a &lt;cref&gt; attribute in an XML documentation comment.
    /// <para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#cref-attribute</para>
    /// </summary>
    [StrongTypeMarker]
    public interface ICRefAttribute : IStrongTypeMarker,
        ITyped<XAttribute>
    {
    }
}