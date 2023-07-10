using System;
using System.Xml.Linq;

using R5T.T0132;


namespace R5T.T0211.Extensions
{
    [FunctionalityMarker]
    public partial interface IXElementOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="ICElement"/>
        public ICElement ToCElement(XElement value)
        {
            var output = new CElement(value);
            return output;
        }

        /// <inheritdoc cref="ICodeElement"/>
        public ICodeElement ToCodeElement(XElement value)
        {
            var output = new CodeElement(value);
            return output;
        }

        /// <inheritdoc cref="IExampleElement"/>
        public IExampleElement ToExampleElement(XElement value)
        {
            var output = new ExampleElement(value);
            return output;
        }

        /// <inheritdoc cref="IExceptionElement"/>
        public IExceptionElement ToExceptionElement(XElement value)
        {
            var output = new ExceptionElement(value);
            return output;
        }

        /// <inheritdoc cref="IIncludeElement"/>
        public IIncludeElement ToIncludeElement(XElement value)
        {
            var output = new IncludeElement(value);
            return output;
        }

        /// <inheritdoc cref="IInheritdocElement"/>
        public IInheritdocElement ToInheritdocElement(XElement value)
        {
            var output = new InheritdocElement(value);
            return output;
        }

        /// <inheritdoc cref="IListElement"/>
        public IListElement ToListElement(XElement value)
        {
            var output = new ListElement(value);
            return output;
        }

        /// <inheritdoc cref="IParaElement"/>
        public IParaElement ToParaElement(XElement value)
        {
            var output = new ParaElement(value);
            return output;
        }

        /// <inheritdoc cref="IParamElement"/>
        public IParamElement ToParamElement(XElement value)
        {
            var output = new ParamElement(value);
            return output;
        }

        /// <inheritdoc cref="IParamRefElement"/>
        public IParamRefElement ToParamRefElement(XElement value)
        {
            var output = new ParamRefElement(value);
            return output;
        }

        /// <inheritdoc cref="IRemarksElement"/>
        public IRemarksElement ToRemarksElement(XElement value)
        {
            var output = new RemarksElement(value);
            return output;
        }

        /// <inheritdoc cref="IReturnsElement"/>
        public IReturnsElement ToReturnsElement(XElement value)
        {
            var output = new ReturnsElement(value);
            return output;
        }

        /// <inheritdoc cref="ISeeAlsoElement"/>
        public ISeeAlsoElement ToSeeAlsoElement(XElement value)
        {
            var output = new SeeAlsoElement(value);
            return output;
        }

        /// <inheritdoc cref="ISeeElement"/>
        public ISeeElement ToSeeElement(XElement value)
        {
            var output = new SeeElement(value);
            return output;
        }

        /// <inheritdoc cref="ISummaryElement"/>
        public ISummaryElement ToSummaryElement(XElement value)
        {
            var output = new SummaryElement(value);
            return output;
        }

        /// <inheritdoc cref="ITypeParamElement"/>
        public ITypeParamElement ToTypeParamElement(XElement value)
        {
            var output = new TypeParamElement(value);
            return output;
        }

        /// <inheritdoc cref="ITypeParamRefElement"/>
        public ITypeParamRefElement ToTypeParamRefElement(XElement value)
        {
            var output = new TypeParamRefElement(value);
            return output;
        }

        /// <inheritdoc cref="IValueElement"/>
        public IValueElement ToValueElement(XElement value)
        {
            var output = new ValueElement(value);
            return output;
        }
    }
}
