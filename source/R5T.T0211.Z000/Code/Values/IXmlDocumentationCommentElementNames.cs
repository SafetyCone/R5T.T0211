using System;

using R5T.T0131;
using R5T.L0030.T000;
using R5T.L0030.T000.Extensions;


namespace R5T.T0211.Z000
{
    [ValuesMarker]
    public partial interface IXmlDocumentationCommentElementNames : IValuesMarker
    {
        public IElementName Summary => "summary".ToElementName();
        public IElementName Remarks => "remarks".ToElementName();

        public IElementName Returns => "returns".ToElementName();
        public IElementName Param => "param".ToElementName();
        public IElementName Paramref => "paramref".ToElementName();
        public IElementName Exception => "exception".ToElementName();
        public IElementName Value => "value".ToElementName();

        public IElementName Para => "para".ToElementName();
        public IElementName List => "list".ToElementName();
        public IElementName C => "c".ToElementName();
        public IElementName Code => "code".ToElementName();
        public IElementName Example => "example".ToElementName();

        public IElementName Inheritdoc => "inheritdoc".ToElementName();
        public IElementName Include => "include".ToElementName();

        public IElementName See => "see".ToElementName();
        public IElementName Seealso => "seealso".ToElementName();

        public IAttributeName Cref => "cref".ToAttributeName();
        public IAttributeName Href => "href".ToAttributeName();

        public IAttributeName Name => "name".ToAttributeName();
        /// <summary>
        /// path
        /// </summary>
        public IAttributeName Path => "path".ToAttributeName();

        public IElementName Typeparam => "typeparam".ToElementName();
        public IElementName Typeparamref => "typeparamref".ToElementName();
    }
}
