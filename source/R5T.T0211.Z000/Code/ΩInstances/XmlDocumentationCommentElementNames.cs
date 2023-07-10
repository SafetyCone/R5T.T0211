using System;


namespace R5T.T0211.Z000
{
    public class XmlDocumentationCommentElementNames : IXmlDocumentationCommentElementNames
    {
        #region Infrastructure

        public static IXmlDocumentationCommentElementNames Instance { get; } = new XmlDocumentationCommentElementNames();


        private XmlDocumentationCommentElementNames()
        {
        }

        #endregion
    }
}
