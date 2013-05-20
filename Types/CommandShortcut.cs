using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [Serializable]
    [DataContract]
    public class CommandShortcut
    {
        public CommandShortcut()
        {
        }

        public CommandShortcut( string name, string context )
        {
            Name = name;
            Context = context;
        }

        [XmlAttribute]
        [DataMember]
        public string ID {get;set;}

        [XmlAttribute]
        [DataMember]
        public string Icon { get; set; }

        [XmlAttribute]
        [DataMember]
        public string HelpText { get; set; }

        [XmlAttribute]
        [DataMember]
        public string Label { get; set; }

        [XmlAttribute]
        [DataMember]
        public string State { get; set; }

        [XmlAttribute]
        [DataMember]
        public string Name { get; set; }

        [XmlAttribute]
        [DataMember]
        public string Context { get; set; }
        
        [XmlAttribute]
        [DataMember]
        public string Arg1 { get; set; }
        
        [XmlAttribute]
        [DataMember]
        public string Arg2 { get; set; }
        
        [XmlAttribute]
        [DataMember]
        public string Arg3 { get; set; }
        
        [XmlAttribute]
        [DataMember]
        public string Arg4 { get; set; }
        
        [XmlAttribute]
        [DataMember]
        public string ConfirmWith { get; set; }
        
        [XmlAttribute]
        [DataMember]
        public string AppliesIf { get; set; }

        /// <summary>
        /// Gets or sets the command session ID.
        /// </summary>
        /// <value>The command session ID.</value>
        [XmlAttribute]
        [DataMember]
        public string CommandSessionID { get; set; }

        [XmlAttribute]
        [DataMember]
        public DisplayTarget Target { get; set; }

        #region Methods

        public bool IsTransition()
        {
            return Name != null && Name.StartsWith("Transition:");
        }

        public string GetTransition()
        {
            if ( Name == null )
                return null;

            var m = regexTranistion.Match( Name );

            if ( ! m.Success )
                return null;

            return m.Groups[1].Value;
        }

        private static readonly Regex regexTranistion = new Regex( @"Transition:(\w+)", RegexOptions.Compiled );
     
       
        public CommandShortcut RedirectTo(string newState)
        {
            CommandShortcut cmd = (CommandShortcut) this.MemberwiseClone();

            cmd.State = newState ;

            return cmd;
        }

        public virtual CommandShortcut Copy()
        {
            return (CommandShortcut)MemberwiseClone();
        }

        #endregion
    }
}
