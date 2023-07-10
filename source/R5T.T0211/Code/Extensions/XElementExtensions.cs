using System;
using System.Xml.Linq;


namespace R5T.T0211.Extensions
{
    public static class XElementExtensions
    {
        /// <inheritdoc cref="IXElementOperator.ToCElement(XElement)"/>
        public static ICElement ToCElement(this XElement value)
        {
            return Instances.XElementOperator_Extensions.ToCElement(value);
        }

        /// <inheritdoc cref="IXElementOperator.ToCodeElement(XElement)"/>
        public static ICodeElement ToCodeElement(this XElement value)
        {
            return Instances.XElementOperator_Extensions.ToCodeElement(value);
        }

        /// <inheritdoc cref="IXElementOperator.ToExampleElement(XElement)"/>
        public static IExampleElement ToExampleElement(this XElement value)
        {
            return Instances.XElementOperator_Extensions.ToExampleElement(value);
        }

        /// <inheritdoc cref="IXElementOperator.ToExceptionElement(XElement)"/>
        public static IExceptionElement ToExceptionElement(this XElement value)
        {
            return Instances.XElementOperator_Extensions.ToExceptionElement(value);
        }

        /// <inheritdoc cref="IXElementOperator.ToIncludeElement(XElement)"/>
        public static IIncludeElement ToIncludeElement(this XElement value)
        {
            return Instances.XElementOperator_Extensions.ToIncludeElement(value);
        }

        /// <inheritdoc cref="IXElementOperator.ToInheritdocElement(XElement)"/>
        public static IInheritdocElement ToInheritdocElement(this XElement value)
        {
            return Instances.XElementOperator_Extensions.ToInheritdocElement(value);
        }

        /// <inheritdoc cref="IXElementOperator.ToListElement(XElement)"/>
        public static IListElement ToListElement(this XElement value)
        {
            return Instances.XElementOperator_Extensions.ToListElement(value);
        }

        /// <inheritdoc cref="IXElementOperator.ToParaElement(XElement)"/>
        public static IParaElement ToParaElement(this XElement value)
        {
            return Instances.XElementOperator_Extensions.ToParaElement(value);
        }

        /// <inheritdoc cref="IXElementOperator.ToParamElement(XElement)"/>
        public static IParamElement ToParamElement(this XElement value)
        {
            return Instances.XElementOperator_Extensions.ToParamElement(value);
        }

        /// <inheritdoc cref="IXElementOperator.ToParamRefElement(XElement)"/>
        public static IParamRefElement ToParamRefElement(this XElement value)
        {
            return Instances.XElementOperator_Extensions.ToParamRefElement(value);
        }

        /// <inheritdoc cref="IXElementOperator.ToRemarksElement(XElement)"/>
        public static IRemarksElement ToRemarksElement(this XElement value)
        {
            return Instances.XElementOperator_Extensions.ToRemarksElement(value);
        }

        /// <inheritdoc cref="IXElementOperator.ToReturnsElement(XElement)"/>
        public static IReturnsElement ToReturnsElement(this XElement value)
        {
            return Instances.XElementOperator_Extensions.ToReturnsElement(value);
        }

        /// <inheritdoc cref="IXElementOperator.ToSeeAlsoElement(XElement)"/>
        public static ISeeAlsoElement ToSeeAlsoElement(this XElement value)
        {
            return Instances.XElementOperator_Extensions.ToSeeAlsoElement(value);
        }

        /// <inheritdoc cref="IXElementOperator.ToSeeElement(XElement)"/>
        public static ISeeElement ToSeeElement(this XElement value)
        {
            return Instances.XElementOperator_Extensions.ToSeeElement(value);
        }

        /// <inheritdoc cref="IXElementOperator.ToSummaryElement(XElement)"/>
        public static ISummaryElement ToSummaryElement(this XElement value)
        {
            return Instances.XElementOperator_Extensions.ToSummaryElement(value);
        }

        /// <inheritdoc cref="IXElementOperator.ToTypeParamElement(XElement)"/>
        public static ITypeParamElement ToTypeParamElement(this XElement value)
        {
            return Instances.XElementOperator_Extensions.ToTypeParamElement(value);
        }

        /// <inheritdoc cref="IXElementOperator.ToTypeParamRefElement(XElement)"/>
        public static ITypeParamRefElement ToTypeParamRefElement(this XElement value)
        {
            return Instances.XElementOperator_Extensions.ToTypeParamRefElement(value);
        }

        /// <inheritdoc cref="IXElementOperator.ToValueElement(XElement)"/>
        public static IValueElement ToValueElement(this XElement value)
        {
            return Instances.XElementOperator_Extensions.ToValueElement(value);
        }
    }
}
