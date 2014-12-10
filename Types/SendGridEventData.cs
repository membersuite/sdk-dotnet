using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemberSuite.SDK.Types
{

    // Field names of this class have to match names sendgrid will use to send us the event data
    // Membersuite specific names are defined in MassMessageProcessor.generateEmailMessage
    // {"unique_args": {"associationID":"","messagingJobID":"","associationKey":"","messageGuid":""}}
    // Other fields are sendgrid specific.
      
    public class SendGridEventData
    {
        public string @event = null;
        public string email = null;
        public string associationID = null;
        public string messagingJobID = null;
        public int associationKey = 0;
        public string timestamp = null;
        public DateTime? eventTime;
        public string url = null;
        public string destinationQueue = null;

       
    }
}
