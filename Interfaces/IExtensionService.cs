using System.Collections.Generic;
using System.ServiceModel;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Interfaces
{
    /// <summary>
    ///     Defines an extension service that can be called from
    ///     MemberSuite to retrieve a value or trigger an action.
    /// </summary>
    [ServiceContract]
    public interface IExtensionService
    {
        /// <summary>
        ///     Checks to see if the service is operational.
        /// </summary>
        /// <returns>True if operational.</returns>
        /// <remarks>
        ///     MemberSuite will call this method when attempting to make sure the service
        ///     works properly. At a base level, you should implement this method and return TRUE -
        ///     but you can use this method to signal to MemberSuite that, for whatever reason, this
        ///     service is out of commission.
        /// </remarks>
        [OperationContract]
        bool Ping();

        /// <summary>
        ///     Fires the trigger of an extension service
        /// </summary>
        /// <param name="typeOfTrigger">The type of trigger.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="context">The context.</param>
        /// <param name="prevObj">The prev obj.</param>
        [OperationContract(IsOneWay = true)]
        void FireTrigger(
            TriggerType typeOfTrigger,
            string objectType,
            string context,
            MemberSuiteObject prevObj);

        /// <summary>
        ///     Populates a dropdown list based on the current record values
        /// </summary>
        /// <param name="recordType">Type of the record.</param>
        /// <param name="fieldName">The field name.</param>
        /// <param name="msoCurrentObjectValues">The mso current object values.</param>
        /// <returns></returns>
        /// <remarks>This extension service allows for powerful cascading dropdown and conditional population logic</remarks>
        [OperationContract]
        List<NameValueStringPair> PopulateDropdownList(string recordType,
            string fieldName, MemberSuiteObject msoCurrentObjectValues);
    }
}