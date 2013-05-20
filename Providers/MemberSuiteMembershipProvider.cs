using System;
using System.Collections.Specialized;
using System.Configuration.Provider;
using MemberSuite.SDK.Results;

namespace MemberSuite.SDK.Providers
{
    /// <summary>
    /// Provider alls ASP.NET applications to use ASP.NET single sign on
    /// </summary>
    public class MemberSuiteMembershipProvider : MembershipProvider
    {
        public MemberSuiteMembershipProvider()
        {
        }

        public MemberSuiteMembershipProvider(string associationID)
        {
            AssociationID = associationID;
        }

        
        #region Properties

        
        public string CurrentUserName { get; protected set; }

        /// <summary>
        /// Gets or sets the association ID 
        /// </summary>
        /// <value>The association ID.</value>
        /// <remarks>This value must be set before attempting to login or perform any operations</remarks>
        public string AssociationID { get; set; }

        public override void Initialize(string name, NameValueCollection config)
        {
            if (config == null) throw new ArgumentNullException("config");
            if (name == null || name.Length == 0)
                name = "MemberSuiteMembershipProvider";

            base.Initialize(name, config);

            
            AssociationID = config["associationID"];
            

            pApplicationName = GetConfigValue(config["applicationName"],
                                 System.Web.Hosting.HostingEnvironment.ApplicationVirtualPath);
            pMaxInvalidPasswordAttempts = Convert.ToInt32(GetConfigValue(config["maxInvalidPasswordAttempts"], "5"));
            pPasswordAttemptWindow = Convert.ToInt32(GetConfigValue(config["passwordAttemptWindow"], "10"));
            pMinRequiredNonAlphanumericCharacters = Convert.ToInt32(GetConfigValue(config["minRequiredNonAlphanumericCharacters"], "1"));
            pMinRequiredPasswordLength = Convert.ToInt32(GetConfigValue(config["minRequiredPasswordLength"], "7"));
            pPasswordStrengthRegularExpression = Convert.ToString(GetConfigValue(config["passwordStrengthRegularExpression"], ""));
            pEnablePasswordReset = Convert.ToBoolean(GetConfigValue(config["enablePasswordReset"], "true"));
 
            pRequiresUniqueEmail = Convert.ToBoolean(GetConfigValue(config["requiresUniqueEmail"], "true"));
         
            string temp_format = config["passwordFormat"];
            if (temp_format == null)
            {
                temp_format = "Hashed";
            }

            switch (temp_format)
            {
                case "Hashed":
                    pPasswordFormat = MembershipPasswordFormat.Hashed;
                    break;
                case "Encrypted":
                    pPasswordFormat = MembershipPasswordFormat.Encrypted;
                    break;
                case "Clear":
                    pPasswordFormat = MembershipPasswordFormat.Clear;
                    break;
                default:
                    throw new ProviderException("Password format not supported.");
            }

            // by checking the query string, we can enable multitenance for the portal
            //if (AssociationID == null && HttpContext.Current != null) // check a querystring
            //    AssociationID = HttpContext.Current.Request.QueryString["associationID"];

        }

        #endregion

        
        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            if ( CurrentUserName == null )
                throw new ProviderException("Cannot change password - not logged in");

            if (username != CurrentUserName)
                throw new ProviderException("Cannot change user name for a different logged in user");

            ValidatePasswordEventArgs args =
              new ValidatePasswordEventArgs(username, newPassword, true);

            OnValidatingPassword(args);

            if (args.Cancel)
                if (args.FailureInformation != null)
                    throw args.FailureInformation;
                else
                    throw new MembershipPasswordException("Change password canceled due to new password validation failure.");


            using (var api = ConciergeAPIProxyGenerator.GenerateProxy( false ))
            {
                ConciergeResult changePasswordResult = api.ChangePassword(oldPassword, newPassword);
                return changePasswordResult.Success;
            }
        }

        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
        {
            throw new NotSupportedException();
        }

        public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status)
        {
            throw new NotSupportedException();
        }

        public override bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            throw new NotSupportedException();
        }

      
        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotSupportedException();
        }

        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotSupportedException();
        }

        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotSupportedException();
        }

        public override int GetNumberOfUsersOnline()
        {
            throw new NotSupportedException();
        }

        public override string GetPassword(string username, string answer)
        {
            throw new NotSupportedException();
        }

        public override MembershipUser GetUser(string username, bool userIsOnline)
        {
          
            throw new ApplicationException(string.Format("Unable to get user '{0}'", username));
        }

        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            throw new NotSupportedException();
        }

        public override string GetUserNameByEmail(string email)
        {
            throw new NotSupportedException();
        }

       


        public override string ResetPassword(string username, string answer)
        {
            throw new NotSupportedException();
        }

        public override bool UnlockUser(string userName)
        {
            throw new NotSupportedException();
        }

        public override void UpdateUser(MembershipUser user)
        {
            throw new NotSupportedException();
        }

        public override bool ValidateUser(string username, string password)
        {
            if (username == null) throw new ArgumentNullException("username");
            if (AssociationID == null)
                throw new ProviderException("Unable to perform login - no association ID has been set.");

            using (var api = ConciergeAPIProxyGenerator.GenerateProxy(false))
            {
                LoginResult result = api.LoginToPortal(AssociationID, username, password);

                if (result.Success)
                {
                    ConciergeAPIProxyGenerator.SessionID = result.SessionID;
                    CurrentUserName = (string) result.User["Name"]; // set the user
                }

                return result.Success;
            }
        }

        #region Membership Provider Properties

        //
        // A helper function to retrieve config values from the configuration file.
        //

        private string GetConfigValue(string configValue, string defaultValue)
        {
            if (String.IsNullOrEmpty(configValue))
                return defaultValue;

            return configValue;
        }


        //
        // System.Web.Security.MembershipProvider properties.
        //


        private string pApplicationName;
        private bool pEnablePasswordReset;
       
       
        private bool pRequiresUniqueEmail;
        private int pMaxInvalidPasswordAttempts;
        private int pPasswordAttemptWindow;
        private MembershipPasswordFormat pPasswordFormat;

        public override string ApplicationName
        {
            get { return pApplicationName; }
            set { pApplicationName = value; }
        }

        public override bool EnablePasswordReset
        {
            get { return pEnablePasswordReset; }
        }


        public override bool EnablePasswordRetrieval
        {
            get { return false; }
        }


        public override bool RequiresQuestionAndAnswer
        {
            get { return false; }
        }


        public override bool RequiresUniqueEmail
        {
            get { return pRequiresUniqueEmail; }
        }


        public override int MaxInvalidPasswordAttempts
        {
            get { return pMaxInvalidPasswordAttempts; }
        }


        public override int PasswordAttemptWindow
        {
            get { return pPasswordAttemptWindow; }
        }


        public override MembershipPasswordFormat PasswordFormat
        {
            get { return pPasswordFormat; }
        }

        private int pMinRequiredNonAlphanumericCharacters;

        public override int MinRequiredNonAlphanumericCharacters
        {
            get { return pMinRequiredNonAlphanumericCharacters; }
        }

        private int pMinRequiredPasswordLength;

        public override int MinRequiredPasswordLength
        {
            get { return pMinRequiredPasswordLength; }
        }

        private string pPasswordStrengthRegularExpression;

        public override string PasswordStrengthRegularExpression
        {
            get { return pPasswordStrengthRegularExpression; }
        }



        #endregion
    }
}
