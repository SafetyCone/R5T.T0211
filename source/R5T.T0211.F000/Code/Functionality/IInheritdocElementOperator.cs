using System;
using System.Xml.Linq;

using R5T.L0089.T000;
using R5T.T0132;
using R5T.T0162;
using R5T.T0162.Extensions;
using R5T.T0203;
using R5T.T0203.Extensions;


namespace R5T.T0211.F000
{
    [FunctionalityMarker]
    public partial interface IInheritdocElementOperator : IFunctionalityMarker
    {
        /// <summary>
        /// Stuff
        /// </summary>
        /// Stuff stuff stuff
        public IIdentityName Get_Cref(IInheritdocElement inheritdocElement)
        {
            return this.Get_Cref(inheritdocElement.Value);
        }

        public IIdentityName Get_Cref(XElement inheritdocElement)
        {
            var output = Instances.XElementOperator.Get_AttributeValue(
                inheritdocElement,
                Instances.XmlDocumentationCommentElementNames.Cref)
                .ToIdentityName();

            return output;
        }

        public WasFound<IIdentityName> Has_Cref(XElement inheritdocElement)
        {
            var output = Instances.XElementOperator.Has_AttributeValue(
                inheritdocElement,
                Instances.XmlDocumentationCommentElementNames.Cref)
                .Convert(value => value.ToIdentityName());

            return output;
        }

        public WasFound<IIdentityName> Has_Cref(IInheritdocElement inheritdocElement)
        {
            return this.Has_Cref(inheritdocElement.Value);
        }

        public WasFound<IXPathText> Has_Path(IInheritdocElement inheritdocElement)
        {
            return this.Has_Path(inheritdocElement.Value);
        }

        public WasFound<IXPathText> Has_Path(XElement inheritdocElement)
        {
            var output = Instances.XElementOperator.Has_AttributeValue(
                inheritdocElement,
                Instances.XmlDocumentationCommentElementNames.Path)
                .Convert(value => value.ToXPathText());

            return output;
        }

        /// <summary>
        /// If the inherit doc
        /// </summary>
        /// <param name="inheritdocElement"></param>
        /// <returns></returns>
        public bool Is_Empty(XElement inheritdocElement)
        {
            return inheritdocElement.HasAttributes;
        }
    }
}
