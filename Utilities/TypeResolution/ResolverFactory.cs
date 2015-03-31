using System;
using System.Collections.Generic;
using System.Reflection;

namespace MemberSuite.SDK.Utilities.TypeResolution
{
    /// <summary>
    /// Responsible for managing resolvers in MemberSuite, which essentially
    /// use dependency injection to "resolve" objects based on string references
    /// </summary>
    public static class ResolverFactory
    {
       
        static ResolverFactory()
        {
            initialize();
        }

        /// <summary>
        /// Initializes this factory
        /// </summary>
        private static void initialize()
        {
           // unityContainer = new UnityContainer();

           //// string path = Path.Combine(Environment.CurrentDirectory, "unity");
           // ExeConfigurationFileMap map = new ExeConfigurationFileMap() { ExeConfigFilename = "unity.config" };
           // Configuration config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
            
           // // get the section
           // var section = (UnityConfigurationSection)config.GetSection("unity");

           // if (section == null) throw new ApplicationException("unable to locate unity configuration file");
           // section.Containers["ResolverFactory"].Configure(unityContainer);
            
        }

      

        public static void InitializeResolverCache<T>(Assembly targetAssembly, Type attributeType, bool storeSingletons,
         Dictionary<Type, T> cache)
        {
            if (targetAssembly == null) throw new ArgumentNullException("targetAssembly");
            if (attributeType == null) throw new ArgumentNullException("attributeType");
            if (cache == null) throw new ArgumentNullException("cache");

            if (!attributeType.IsSubclassOf(typeof(ResolverAttribute)))
                throw new ApplicationException(string.Format("Attribute type '{0}' does not derive from ResolverAttribute.", attributeType));

            foreach (Type t in targetAssembly.GetTypes())
            {
                if (t.IsAbstract || !t.IsSubclassOf(typeof(T)))
                    continue; // nothing to see here

                var attributes = t.GetCustomAttributes(attributeType, false);

                if (attributes == null || attributes.Length == 0)
                    continue;

                foreach (ResolverAttribute attr in attributes)
                {
                    if (cache.ContainsKey(attr.Type))
                        throw new ApplicationException(string.Format("{0} for '{1}' has been specified twice: {2} and {3}",
                                                     typeof(T), attr.Type, cache[attr.Type].GetType(), t));

                    if (storeSingletons)
                        cache.Add(attr.Type, (T)MemberSuite.Container.GetOrCreateInstance(t)); // create a singleton
                    else
                        throw new NotSupportedException();
                }
            }
        }

        public static T Resolve<T>(Type typeBeingDescribed, IDictionary<Type, T> cache) where T : class
        {
            T resolverTarget;

            if (cache.TryGetValue(typeBeingDescribed, out resolverTarget))
                return resolverTarget;

            if (typeBeingDescribed.BaseType == null  )
                return null;

            resolverTarget = Resolve(typeBeingDescribed.BaseType, cache); // recurse! recurse!

            if (resolverTarget == null)
                throw new ResolverException("Unable to resolve {1} for '{0}'", typeBeingDescribed, typeof(T).Name);

            cache[typeBeingDescribed] =  resolverTarget;   // cache it so we don't have to do the walk again

            return resolverTarget;
        }

    }
}