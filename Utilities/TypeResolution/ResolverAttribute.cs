using System;

namespace MemberSuite.SDK.Utilities.TypeResolution
{
    public class ResolverAttribute: Attribute 
    {
        public ResolverAttribute(Type t)
        {
            Type = t;
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public Type Type { get; set; }
    }
}
