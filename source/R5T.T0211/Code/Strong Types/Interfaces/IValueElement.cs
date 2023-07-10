using System;
using System.Xml.Linq;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0211
{
    /// <summary>
    /// Strongly-types a XElement as a &lt;value&gt; tag in an XML documentation comment.
    /// <para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#value</para>
    /// How does the &lt;value&gt; tag add value over the &lt;summary&gt; tag? See: <see href="https://stackoverflow.com/questions/15901716/the-purpose-of-using-both-value-and-summary-tags-in-visual-studio-xml-docume"/>
    /// </summary>
    [StrongTypeMarker]
    public interface IValueElement : IStrongTypeMarker,
        ITyped<XElement>
    {
    }
}