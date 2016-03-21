using System;

namespace MemberSuite.SDK.Types
{
    // Field names of this class have to match names sendgrid will use to send us the event data
    // Membersuite specific names are defined in MassMessageProcessor.generateEmailMessage
    // {"unique_args": {"associationID":"","messagingJobID":"","associationKey":"","messageGuid":""}}
    // Other fields are sendgrid specific.

    public class SendGridEventData
    {
        public string associationID = null;
        public int associationKey = 0;
        public string destinationQueue = null;
        public string email = null;
        public string @event = null;
        public DateTime? eventTime;
        public string messagingJobID = null;
        public string timestamp = null;
        public string url = null;
    }
}