/*using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;


namespace MemberSuite.SDK.Utilities.TypeResolution
{
    /// <summary>
    /// Represents a class that is responsible for resolving another class
    /// </summary>
    public abstract class Resolver<T>  
    {
        public Resolver()
        {
            Initialize();
        }

        /// <summary>
        /// Set when the resolver has been initialized
        /// </summary>
        private bool _hasBeenInitialized;
        
        /// <summary>
        /// The unity container used
        /// </summary>
        protected IUnityContainer unityContainer;

        public void Initialize()
        {
            unityContainer = new UnityContainer();

           
            ExeConfigurationFileMap map = new ExeConfigurationFileMap() { ExeConfigFilename = "unity.config" };
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);

            // get the section
            var section = (UnityConfigurationSection)config.GetSection("unity");

            if (section == null) throw new ApplicationException("unable to locate unity configuration file");

            // pull up the container
            section.Containers[getUnityContainerName()].Configure(unityContainer);
            
            _hasBeenInitialized = true;
        }

        /// <summary>
        /// Gets the name of the unity container.
        /// </summary>
        /// <returns></returns>
        protected virtual string getUnityContainerName()
        {
            return GetType().Name;
        }

        public virtual T _resolve<T1>()
        {
            return Resolve(typeof(T1));
        }

        public virtual T Resolve(Type type)
        {
            if (!_hasBeenInitialized)
                throw new ResolverException("Error while resolving '{0}' - resolver has not been initalized.", type);

            return (T)unityContainer.Resolve(GetType(), type.Name);
            
        }


    }
}*/