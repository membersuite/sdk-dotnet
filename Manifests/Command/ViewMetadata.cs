using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MemberSuite.SDK.Manifests.Command.Views;
using MemberSuite.SDK.Manifests.Resource;
using MemberSuite.SDK.Types;
using MemberSuite.SDK.Utilities;

namespace MemberSuite.SDK.Manifests.Command
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("ViewMetadata", Namespace = "http://membersuite.com/schemas/",
       IsNullable = false)]
    [Serializable]
    [DataContract]
    public class ViewMetadata
    {
        [XmlAttribute]
        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string DisplayName { get; set; }

        [XmlAttribute]
        [DataMember]
        public string Name { get; set; }

        [XmlAttribute]
        [DataMember]
        public string CopyFrom { get; set; }

        [DataMember]
        public BreadcrumbBarStructure BreadcrumbBar { get; set; }

        [XmlArrayItem("DataBinding")]
        [DataMember]
        public List<ControlMetadata> DataBindings { get; set; }

        [DataMember]
        public SpecificViewMetadataCollection SpecificViewMetadata { get; set; }

        [XmlArrayItem("Transition")]
        [DataMember]
        public List<ViewTransition> Transitions { get; set; }

        /// <summary>
        /// If this is set, the transition is "long running" and an ajax message will appear
        /// </summary>
        /// <value>The ajax message.</value>
        [DataMember]
        public string AjaxTransitionMessage { get; set; }

        [XmlArrayItem("Resource")]
        [DataMember]
        public List<StringResource> Resources { get; set; }

        [XmlType(Namespace = "http://membersuite.com/schemas/")]
        [DataContract]
        public class DataBinding
        {
            [XmlAttribute]
            [DataMember]
            public string Control { get; set; }

            [XmlAttribute]
            [DataMember]
            public string Property { get; set; }

            [XmlAttribute]
            [DataMember]
            public string Expression { get; set; }
        }

        [XmlType(Namespace = "http://membersuite.com/schemas/")]
        [Serializable]
        [DataContract]
        public class BreadcrumbBarStructure
        {
            [DataMember]
            public string Color { get; set; }

            [XmlArrayItem("Command")]
            [DataMember]
            public List<CommandShortcut> Commands { get; set; }
        }

        [XmlType(Namespace = "http://membersuite.com/schemas/")]
        [Serializable]
        [DataContract]
        public class SpecificViewMetadataCollection
        {
            [DataMember]
            public DataEntryViewMetadata DataEntryViewMetadata { get; set; }

            [DataMember]
            public Data360ViewMetadata Data360ViewMetadata { get; set; }

            [DataMember]
            public TabularDataViewMetadata TabularDataViewMetadata { get; set; }

            [DataMember]
            public PageLayoutEditorMetadata PageLayoutEditorMetadata { get; set; }

            [DataMember]
            public DashboardMetadata DashboardMetadata { get; set; }

            [DataMember]
            public SearchViewMetadata SearchViewMetadata { get; set; }

            [DataMember]
            public ShowAnnouncementViewMetadata ShowAnnouncementViewMetadata { get; set; }
        }

        [XmlType(Namespace = "http://membersuite.com/schemas/")]
        [Serializable]
        [DataContract]
        public class ControlSection
        {
            public ControlSection()
            {
                LeftControls = new List<ControlMetadata>();
                RightControls = new List<ControlMetadata>();
            }

            [XmlAttribute]
            [DataMember]
            public string Name { get; set; }

            [XmlAttribute]
            [DataMember]
            public string CopyFrom { get; set; }

            [XmlAttribute]
            [DataMember]
            public string Label { get; set; }

            [XmlAttribute]
            [DataMember]
            public string Module { get; set; }

            [XmlAttribute]
            [DataMember]
            public bool Collapsible { get; set; }

            [XmlAttribute]
            [DataMember]
            public string Icon{ get; set; }

            [XmlAttribute]
            [DataMember]
            public int DisplayOrder { get; set; }

            /// <summary>
            /// Gets or sets the text.
            /// </summary>
            /// <value>The text.</value>
            [XmlElement]
            [DataMember]
            public string Text { get; set; }



            [XmlArrayItem("Control")]
            [DataMember]
            public List<ControlMetadata> LeftControls { get; set; }

            [XmlArrayItem("Control")]
            [DataMember]
            public List<ControlMetadata> RightControls { get; set; }

            [XmlArrayItem("Command")]
            [DataMember]
            public List<CommandShortcut> Commands { get; set; }

            [XmlArrayItem("Report")]
            [DataMember]
            public List<ReportLink> Reports
            {
                get;
                set;
            }

            [XmlArrayItem("SubSection")]
            [DataMember]
            public List<ControlSection> SubSections { get; set; }

            /// <summary>
            /// Gets or sets the searches to display.
            /// </summary>
            /// <value>The searches to display.</value>
            /// <remarks>This is particularly relevant for the Data 360 layout</remarks>
            [XmlArrayItem("SearchID")]
            [DataMember]
            public List<string> SearchesToDisplay { get; set; }

            


            public bool IsEmpty()
            {
                if (!String.IsNullOrEmpty(Text))
                    return false;

                if (Commands != null && Commands.Count > 0)
                    return false;

                if (LeftControls != null && LeftControls.Count > 0)
                    return false;

                if (RightControls != null && RightControls.Count > 0)
                    return false;

                if (Reports != null && Reports.Count > 0)
                    return false;

                if (SubSections != null && SubSections.Count > 0)
                    return false;

                return true;
            }

            public bool ContainsField(string fieldName)
            {
                if ( LeftControls != null && LeftControls.Exists( f1=>String.Equals( f1.DataSourceExpression, fieldName, StringComparison.CurrentCultureIgnoreCase ) ) )
                    return true;

                 if ( RightControls != null && RightControls.Exists( f1=>String.Equals( f1.DataSourceExpression, fieldName, StringComparison.CurrentCultureIgnoreCase ) ) )
                    return true;

                return false;
            }
 
            public ControlMetadata FindFieldWithPrefix(string prefixToLookFor)
            {
                ControlMetadata cm = null;
                if (LeftControls != null)
                {
                    cm =
                        LeftControls.Find(
                            x => x.DataSourceExpression != null && x.DataSourceExpression.StartsWith(prefixToLookFor));
                    if (cm != null)
                        return cm;
                }

                if (RightControls != null)
                {
                    cm =
                        RightControls.Find(
                            x => x.DataSourceExpression != null && x.DataSourceExpression.StartsWith(prefixToLookFor));
                    if (cm != null)
                        return cm;
                }

                return null;
            }
        }

        [XmlType(Namespace = "http://membersuite.com/schemas/")]
        [Serializable]
        [DataContract]
        public class ViewTransition : CommandShortcut 
        {


            [XmlAttribute]
            [DataMember]
            public string ShowIf { get; set; }

            [XmlAttribute]
            [DataMember]
            public bool IsDefault { get; set; }

            [XmlAttribute]
            [DataMember]
            public bool SuppressValidation { get; set; }

          
        }

        [Serializable]
        [DataContract]
        public class ReportLink
        {
            [XmlAttribute]
            [DataMember]
            public string ID { get; set; }

            [XmlAttribute]
            [DataMember]
            public ReportLinkType Type { get; set; }

            [XmlAttribute]
            [DataMember]
            public string Label { get; set; }

            [XmlAttribute]
            [DataMember]
            public string Description { get; set; }

            [XmlAttribute]
            [DataMember]
            public bool Customizable { get; set; }
            
            [XmlAttribute]
            [DataMember]
            public bool ExcelAvailable { get; set; }
            
            [XmlAttribute]
            [DataMember]
            public bool PDFAvailable { get; set; }
        }

        public enum ReportLinkType
        {
            Report,
            BuiltInSearch
        }

        public Data360ViewMetadata Get360Metadata()
        {
            if (this.SpecificViewMetadata == null) return null;
            return SpecificViewMetadata.Data360ViewMetadata;
        }


    }

    [Serializable]
    [DataContract]
    public class ControlMetadata : FieldMetadataOverride
    {
        public ControlMetadata()
        {
            Enabled = true;
        }


        [XmlAttribute]
        [DataMember]
        public string ID { get; set; }



        [XmlIgnore] // don't serialize this - we're goin to use ID
        [DataMember]
        public override string Name
        {
            get
            {
                return base.Name;
            }
            set
            {
                base.Name = value;
            }
        }

        [XmlAttribute]
        [DataMember]
        public string DataSource { get; set; }

        [XmlAttribute]
        [DataMember]
        public string DataSourceExpression { get; set; }

        /// <summary>
        /// Gets or sets the acceptable values data source.
        /// </summary>
        /// <value>The acceptable values data source.</value>
        [XmlAttribute]
        [DataMember]
        public string AcceptableValuesDataSource { get; set; }

        /// <summary>
        /// Gets or sets the acceptable values data source expression.
        /// </summary>
        /// <value>The acceptable values data source expression.</value>
        [XmlAttribute]
        [DataMember]
        public string AcceptableValuesDataSourceExpression { get; set; }

        [XmlAttribute]
        [DataMember]
        public string AcceptableValuesDataTextField { get; set; }

        [XmlAttribute]
        [DataMember]
        public string AcceptableValuesDataValueField { get; set; }

        [XmlAttribute]
        [DataMember]
        public bool UseEntireRow { get; set; }

        [XmlIgnore]
        [DataMember]
        public bool Enabled { get; set; }

        [XmlAttribute]
        [DataMember]
        public int Columns { get; set; }

        [XmlArray("Properties")]
        [XmlArrayItem("Property")]
        [DataMember]
        public List<ControlProperty> Properties { get; set; }

        [XmlAttribute]
        [DataMember]
        public string ErrorMessage_RequiredField { get; set; }

        #region Nullable Serialization Overloads
 
        public bool ShouldSerializeUseEntireRow()
        {
            return UseEntireRow;
        }

        public bool ShouldSerializeEnabled()
        {
            return !Enabled;
        }

        [XmlAttribute("Enabled")]
        [DataMember]
        public string EnabledString
        {
            get { return Enabled.ToString(); }
            set
            {
                if (value == null)
                {
                    Enabled= true;
                    return;
                }

                try
                {
                    Enabled = Convert.ToBoolean(value);
                }
                catch
                {
                    Enabled = true;
                }
            }
        }
        #endregion

        public ControlMetadata Clone()
        {
            return (ControlMetadata)MemberwiseClone();
        }

        [Serializable]
        [DataContract]
        public class ControlProperty
        {
            [XmlAttribute]
            [DataMember]
            public string Name { get; set; }

            [XmlText]
            [DataMember]
            public string Expression { get; set; }
        }

        public static ControlMetadata FromFieldMetadata(FieldMetadata fieldMetadata)
        {
            ControlMetadata result = new ControlMetadata
                                         {
                                             DisplayType = fieldMetadata.DisplayType,
                                             DataType = fieldMetadata.DataType,
                                             PickListEntries = fieldMetadata.PickListEntries,
                                             Label = fieldMetadata.Label,
                                             Name = fieldMetadata.Name,
                                             HelpText = fieldMetadata.HelpText,
                                             PortalPrompt = fieldMetadata.PortalPrompt,
                                             DefaultValue = fieldMetadata.DefaultValue,
                                             IsRequired = fieldMetadata.IsRequired,
                                             IsRequiredInPortal = fieldMetadata.IsRequiredInPortal,
                                             IsReadOnly = fieldMetadata.IsReadOnly,
                                             PortalAccessibility =  fieldMetadata.PortalAccessibility,
                                             ReferenceType = fieldMetadata.ReferenceType,
                                             ReferenceContext = fieldMetadata.ReferenceTypeContext,
                                             DataSourceExpression = Formats.GetSafeFieldName(fieldMetadata.Name),
                                             LookupTableID = fieldMetadata.LookupTableID    // MS-6019 (Modified 1/9/2015) Need to account for lookup tables
                                         };
            return result;
        }

       

    }
}