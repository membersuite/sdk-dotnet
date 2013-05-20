using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MemberSuite.SDK.Types
{
    public static class MetadataTypeResolver
    {
        static MetadataTypeResolver()
        {
            initialize();
        }

        private static Dictionary<string, Type> _cache;
        private static void initialize()
        {
            _cache = new Dictionary<string, Type>();
            foreach (var t in Assembly.GetExecutingAssembly().GetTypes())
                _cache[t.Name] = t;

        }

        public static Type Resolve(string name)
        {
            Type t;
            if (_cache.TryGetValue(name, out t))
                return t;

            return null;
        }
    }
}
