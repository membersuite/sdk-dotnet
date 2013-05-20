using System;
using System.Reflection;
using Spring.Expressions;

namespace MemberSuite.SDK.Types
{
    /// <summary>
    /// Required to force Spring to get values the way we want them to
    /// </summary>
    [Serializable]
    public class MemberSuiteObjectValueAccessor : IValueAccessor
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="MemberSuiteObjectValueAccessor"/> class.
        /// </summary>
        /// <param name="nameOfMember">The name of member.</param>
        public MemberSuiteObjectValueAccessor(string nameOfMember)
        {
            _nameOfMember = nameOfMember;
        }

        private string _nameOfMember;

        #region IValueAccessor Members

        /// <summary>
        /// Gets the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public object Get(object context)
        {
            MemberSuiteObject p = (MemberSuiteObject)context;

            if (_nameOfMember == "ClassName" || _nameOfMember == "ClassType")
                return p.ClassType ;

            object o;
            p.Fields.TryGetValue(_nameOfMember, out o);
            return o;


        }

        /// <summary>
        /// Gets a value indicating whether this instance is readable.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is readable; otherwise, <c>false</c>.
        /// </value>
        public bool IsReadable
        {
            get { return true; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is volatile.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is volatile; otherwise, <c>false</c>.
        /// </value>
        public bool IsVolatile
        {
            get { return false; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is writeable.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is writeable; otherwise, <c>false</c>.
        /// </value>
        public bool IsWriteable
        {
            get { return false; }
        }

        /// <summary>
        /// Gets a value indicating whether [requires context].
        /// </summary>
        /// <value><c>true</c> if [requires context]; otherwise, <c>false</c>.</value>
        public bool RequiresContext
        {
            get { return true; }
        }

        /// <summary>
        /// Requireses the refresh.
        /// </summary>
        /// <param name="contextType">Type of the context.</param>
        /// <returns></returns>
        public bool RequiresRefresh(Type contextType)
        {
            return typeof(MemberSuiteObject) != contextType;
        }

        /// <summary>
        /// Sets the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="value">The value.</param>
        public void Set(object context, object value)
        {
            MemberSuiteObject p = (MemberSuiteObject)context;
            
            p.Fields[_nameOfMember] = value;

        }

        /// <summary>
        /// Gets the type of the target.
        /// </summary>
        /// <value>The type of the target.</value>
        public Type TargetType
        {
            get { return typeof(MemberSuiteObject); }
        }

        /// <summary>
        /// Gets the member info.
        /// </summary>
        /// <value>The member info.</value>
        public MemberInfo MemberInfo
        {
            get { return null; }
        }

        #endregion
    }
}
