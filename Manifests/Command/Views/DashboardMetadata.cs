using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MemberSuite.SDK.Manifests.Reporting;

namespace MemberSuite.SDK.Manifests.Command.Views
{
    /// <summary>
    /// Holds information about all of the widgets on a dashboard.
    /// </summary>
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("DashboardMetadata", Namespace = "http://membersuite.com/schemas/",
       IsNullable = false)]
    [Serializable]
    [DataContract]
    public class DashboardMetadata : MetadataBase 
    {
        
         /// <summary>
        /// Gets or sets the left widgets.
        /// </summary>
        /// <value>The left widgets.</value>
        [XmlArrayItem("Widget")]
        [DataMember]
        public List<WidgetDefinition> LeftWidgets { get; set; }

        /// <summary>
        /// Gets or sets the right widgets.
        /// </summary>
        /// <value>The right widgets.</value>
        [XmlArrayItem("Widget")]
        [DataMember]
        public List<WidgetDefinition> RightWidgets { get; set; }








        /// <summary>
        /// Finds the widget.
        /// </summary>
        /// <param name="widgetID">The widget ID.</param>
        /// <returns></returns>
        public WidgetDefinition FindWidget(string widgetID, bool removeFromCollection)
        {
            WidgetDefinition d;
            if (LeftWidgets != null)
            {
                d = LeftWidgets.Find(w => w.ID == widgetID);
                if (d != null)
                {
                    if ( removeFromCollection )
                    LeftWidgets.Remove(d);
                    return d;
                }
            }

            if (RightWidgets != null)
            {
                d = RightWidgets.Find(w => w.ID == widgetID);
                if (d != null)
                {
                    if (removeFromCollection)
                    RightWidgets.Remove(d);
                    return d;
                }
            }

            return null;
        }
    }
}
