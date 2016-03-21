namespace MemberSuite.SDK.DataLoader
{
    /// <summary>
    ///     Class used to instruct the data loader client on how to transport
    ///     files to the server
    /// </summary>
    public class FileTransmissionInstructions
    {
        /// <summary>
        ///     Gets or sets the session ID.
        /// </summary>
        /// <value>The session ID.</value>
        /// <remarks>This session ID should be passed back to the serverfs</remarks>
        public string SessionID { get; set; }

        public string SFTPServer { get; set; }
        public int SFTPServerPort { get; set; }
        public string LoginID { get; set; }
        public string Password { get; set; }
        public string Path { get; set; }
        public string HostKey { get; set; }
    }
}