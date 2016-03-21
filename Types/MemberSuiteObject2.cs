using System;
using System.Collections.Generic;
using MemberSuite.SDK.Utilities;

namespace MemberSuite.SDK.Types
{
    /// <summary>
    ///     This is essentially a MemberSuite object that is designed to be serializable
    /// </summary>
    [Serializable]
    public class MemberSuiteObject2
    {
        public MemberSuiteObject2()
        {
            Fields = new List<NameValuePair>();
        }

        public string ClassType { get; set; }
        public List<string> ParentTypes { get; set; }
        public List<NameValuePair> Fields { get; set; }

        public static MemberSuiteObject2 FromMemberSuiteObject(MemberSuiteObject src)
        {
            var obj2 = new MemberSuiteObject2();

            obj2.ClassType = src.ClassType;
            obj2.ParentTypes = src.ParentTypes;

            foreach (var entry in src.Fields)
            {
                var value = entry.Value;
                var childList = value as IList<MemberSuiteObject>;

                // if we have a list of membersuite objects, we need to do something about it
                if (childList != null)
                    //{
                    //    List<MemberSuiteObject2> childList2 = new List<MemberSuiteObject2>();
                    //    foreach (var obj in childList)
                    //        childList2.Add(MemberSuiteObject2.FromMemberSuiteObject(obj));

                    //    value = childList2;

                    //} else if (value is MemberSuiteObject)
                    //    value = MemberSuiteObject2.FromMemberSuiteObject((MemberSuiteObject) value);
                    continue;

                obj2.Fields.Add(new NameValuePair(entry.Key, value));
            }

            return obj2;
        }

        /// <summary>
        ///     Safely the get value.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>System.Object.</returns>
        public object SafeGetValue(string fieldName)
        {
            return Fields.Find(x => x.Name == fieldName).Value;
        }

        /// <summary>
        ///     Safely the get value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>``0.</returns>
        public T SafeGetValue<T>(string fieldName)
        {
            var obj = SafeGetValue(fieldName);
            if (obj == null)
                return default(T);

            if (typeof (T).IsEnum)
            {
                if (obj is int)
                    return (T) obj;

                if (obj is string)
                    return ((string) obj).ToEnum<T>();
            }

            try
            {
                return (T) obj;
            }
            catch
            {
                return default(T);
            }
        }
    }
}