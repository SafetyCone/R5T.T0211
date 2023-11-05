using System;

using R5T.T0178;
using R5T.T0203;


namespace R5T.T0211
{
    /// <summary>
    /// Strongly-types a string as the text of an XML documentation comment.
    /// <para>Useful for representing the XML documentation comments in .NET C# code.</para>
    /// </summary>
    /// <remarks>
    /// Does not include the "///" prefix of how XML documentation comments appear in code.
    /// Does not include the wrapping &lt;member&gt; element of how XML documentation comments actually appear in the XML documentation file output.
    /// Includes only the text of the XML documentation comment.
    /// <para>
    /// Example:
    /// <br/>&lt;summary&gt;
    /// <br/>Documentation &lt;inheritdoc&gt; element expansion experiment.
    /// <br/>&lt;/summary&gt;
    /// </para>
    /// </remarks>
    [StrongTypeMarker]
    public interface IXmlDocumentationComment : IStrongTypeMarker,
        IXmlText
    {
    }
}