using System;
using System.Xml.Linq;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0211
{
    /// <summary>
    /// Strongly-types a XElement as a &lt;param&gt; tag in an XML documentation comment.
    /// <para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#param</para>
    /// </summary>
    [StrongTypeMarker]
    public interface IParamElement : IStrongTypeMarker,
        ITyped<XElement>
    {
    }
}