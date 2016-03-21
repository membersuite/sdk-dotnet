using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    /// <summary>
    ///     Defines all of the elements of the system that a particular
    ///     user or security role can access.
    /// </summary>
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [Serializable]
    [DataContract]
    public class KeyChain : IMemberSuiteComponent
    {
        public KeyChain()
        {
            RecordTypes = new SerializableDictionary<string, SecurityLockAccessLevel>();
            Commands = new List<string>();
            Reports = new List<string>();
            Tabs = new List<string>();
            SecurityRoles = new List<string>();
        }

        [DataMember]
        public List<string> SecurityRoles { get; set; }

        /// <summary>
        ///     Gets or sets the commands.
        /// </summary>
        /// <value>The commands.</value>
        [DataMember]
        public List<string> Commands { get; set; }

        [DataMember]
        public bool CanAccessAllCommands { get; set; }

        /// <summary>
        ///     Gets or sets the reports.
        /// </summary>
        /// <value>The reports.</value>
        [DataMember]
        public List<string> Reports { get; set; }

        [DataMember]
        public bool CanAccessAllReports { get; set; }

        /// <summary>
        ///     Gets or sets the tabs that people in this role can see
        /// </summary>
        /// <value>The tabs.</value>
        [DataMember]
        public List<string> Tabs { get; set; }

        [DataMember]
        public bool CanAccessAllTabs { get; set; }

        /// <summary>
        ///     Gets or sets the record types that
        ///     can be accessed
        /// </summary>
        /// <value>The record types.</value>
        [DataMember]
        public SerializableDictionary<string, SecurityLockAccessLevel> RecordTypes { get; set; }

        [DataMember]
        public bool HasFullAccessToAllRecordTypes { get; set; }

        /// <summary>
        ///     Absorbs the permissions from another keychain.
        /// </summary>
        /// <param name="keyChain">The key chain.</param>
        public void AbsorbPermissionsFrom(KeyChain keyChain)
        {
            absorbCommandPermissionsFrom(keyChain);
            absorbReportPermissionsFrom(keyChain);
            absorbTabPermissionsFrom(keyChain);
            absorbRecordTypePermissionsFrom(keyChain);
        }

        private void absorbRecordTypePermissionsFrom(KeyChain chain)
        {
            if (chain.HasFullAccessToAllRecordTypes)
                HasFullAccessToAllRecordTypes = true;

            if (chain.RecordTypes == null)
                return;

            foreach (var foreginRecordLevel in chain.RecordTypes)
            {
                SecurityLockAccessLevel currentCommandLevel;

                if (!RecordTypes.TryGetValue(foreginRecordLevel.Key, out currentCommandLevel))
                {
                    RecordTypes.Add(foreginRecordLevel.Key, foreginRecordLevel.Value);
                    continue; // add it - it's not already there
                }

                if (foreginRecordLevel.Value > currentCommandLevel) // then this is a higher permission
                    RecordTypes[foreginRecordLevel.Key] = foreginRecordLevel.Value; // use that permission
            }
        }

        private void absorbTabPermissionsFrom(KeyChain chain)
        {
            if (chain.CanAccessAllTabs)
                CanAccessAllTabs = true;

            if (chain.Tabs == null)
                return;

            foreach (var cmd in chain.Tabs)
                if (!Tabs.Contains(cmd))
                    Tabs.Add(cmd);
        }

        private void absorbReportPermissionsFrom(KeyChain chain)
        {
            if (chain.CanAccessAllReports)
                CanAccessAllReports = true;

            if (chain.Reports == null)
                return;

            foreach (var cmd in chain.Reports)
                if (!Reports.Contains(cmd))
                    Reports.Add(cmd);
        }

        private void absorbCommandPermissionsFrom(KeyChain chain)
        {
            if (chain.CanAccessAllCommands)
                CanAccessAllCommands = true;

            if (chain.Commands == null)
                return;


            foreach (var cmd in chain.Commands)
                if (!Commands.Contains(cmd))
                    Commands.Add(cmd);
        }
    }
}