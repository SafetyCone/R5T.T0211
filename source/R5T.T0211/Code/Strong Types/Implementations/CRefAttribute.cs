using System;
using System.Xml.Linq;

using R5T.T0178;
using R5T.T0179.N001;


namespace R5T.T0211
{
    /// <inheritdoc cref="ICRefAttribute"/>
    [StrongTypeImplementationMarker]
    public class CRefAttribute : TypedBase<XAttribute>, IStrongTypeMarker,
        ICRefAttribute
    {
        public CRefAttribute(XAttribute value)
            : base(value)
        {
        }

        protected override int Value_CompareTo(XAttribute a, XAttribute b)
        {
            throw new NotImplementedException();
        }

        protected override bool Value_Equals(XAttribute a, XAttribute b)
        {
            throw new NotImplementedException();
        }
    }
}