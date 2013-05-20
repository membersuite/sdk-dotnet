using System.Reflection;

namespace MemberSuite.SDK.Utilities
{
    /// <summary>
    /// Helper class for managing references to assemblies
    /// </summary>
    public static  class AssemblyManager
    {
       
        private static Assembly _domainModelAssembly;

        static AssemblyManager()
        {
             
        }

       

        public static Assembly GetDomainModelAssembly()
        {
            if ( _domainModelAssembly == null )
                _domainModelAssembly = Assembly.Load("MemberSuite.Domain.Model");

            return _domainModelAssembly;
        }

        
    }
}