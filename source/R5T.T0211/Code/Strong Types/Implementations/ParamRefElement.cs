using System;
using System.Xml.Linq;

using R5T.T0178;
using R5T.T0179.N001;


namespace R5T.T0211
{
    /// <inheritdoc cref="IParamRefElement"/>
    [StrongTypeImplementationMarker]
    public class ParamRefElement : TypedBase<XElement>, IStrongTypeMarker,
        IParamRefElement
    {
        public ParamRefElement(XElement value)
            : base(value)
        {
        }

        protected override int Value_CompareTo(XElement a, XElement b)
        {
            throw new NotImplementedException();
        }

        protected override bool Value_Equals(XElement a, XElement b)
        {
            throw new NotImplementedException();
        }
    }
}