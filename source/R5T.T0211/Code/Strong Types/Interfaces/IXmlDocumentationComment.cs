using System;

using R5T.T0178;
using R5T.T0203;


namespace R5T.T0211
{
    /// <summary>
    /// Strongly-types a string as the text of an XML documentation comment.
    /// <para>Useful for representing the XML documentation comments in .NET C# code.</para>
    /// </summary>
    [StrongTypeMarker]
    public interface IXmlDocumentationComment : IStrongTypeMarker,
        IXmlText
    {
    }
}