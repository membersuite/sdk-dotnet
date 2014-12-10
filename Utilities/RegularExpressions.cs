using System;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MemberSuite.SDK.Utilities
{
    public static class RegularExpressions
    {
        public const int REGEX_CACHE_SIZE_MAX = 200;
        public const string ASSOCIATION_TYPE_HINT = "0004";
        public const string FILE_TYPE_HINT = "001C";
        public const string PREFIX_FOR_SERIALIZATION = "@@SERIALIZEDOBJECT@@";
        private const string EVENT_MERCHANDISE_TYPE_HINT = "008C";
        private const string ORGANIZATIONAL_LAYER_TYPE_HINT = "006B";
        private const string MERCHANDISE_HINT = "0076";

        ///<summary>Regexes for parsing request path.  Uses [A-Fa-f0-9] for GUID characters instead of \w because we want to be very particular with the path and don't want to match _</summary>
        public static string DynamicImageDetectorRegex = String.Format(@"/(?<AssociationHint>[A-Fa-f0-9]{{8}})-{0}-(?<AssociationIdNoHints>[A-Fa-f0-9]{{4}}-[A-Fa-f0-9]{{4}}-[A-Fa-f0-9]{{12}})/(?<PartitionKey>\d+)/\k<AssociationHint>-{1}-(?<FileIdNoHints>[A-Fa-f0-9]{{4}}-[A-Fa-f0-9]{{4}}-[A-Fa-f0-9]{{12}}$)", ASSOCIATION_TYPE_HINT, FILE_TYPE_HINT);
        public static string PathRegex = string.Format(@"^/(?<AssociationHint>[A-Fa-f0-9]{{8}})-{0}-(?<AssociationIdNoHints>[A-Fa-f0-9]{{4}}-[A-Fa-f0-9]{{4}}-[A-Fa-f0-9]{{12}})/(?<PartitionKey>\d+)/\k<AssociationHint>-{1}-(?<FileIdNoHints>[A-Fa-f0-9]{{4}}-[A-Fa-f0-9]{{4}}-[A-Fa-f0-9]{{12}}$)", ASSOCIATION_TYPE_HINT, FILE_TYPE_HINT);
        public static readonly string TypeCreatedRegex = @"\w+\.(\w+)\.\w+";
        public static readonly string FrontDoorRegex = @"Console.(\w+).FrontDoor";
        public static readonly string EliminateMultipleBreaksRegex = @"(<br\s*\/?>\s*)+";
        public static readonly string ShortcutParserRegex = @"(console|portal)(.(\w+))+";
        public static readonly string ExpressionDetectorRegex = @"\#\#([^\#]+?)\#\#";
        public static readonly string DataRowFinderRegex = @"\['(.*?)'\].((\w|\.)*)";
        public static readonly string IndexerReplacerRegex = @"\[(.*?)\]";
        public static readonly string UrlParserRegex = @"http.*?/app/(console|portal)(/(\w+))+";
        public static readonly string FileParserRegex = @"/file/([A-Fa-f0-9]{8}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{12})";
        public static readonly string DefaultPageDetectorRegex = @"/default";
        public static readonly string TelerikDetector1Regex = @"Telerik.Web.UI";
        public static readonly string TelerikDetector2Regex = @"\.axd";
        public static readonly string FileNameIdRegex = string.Format(@"_(?<FileId>[A-F0-9]{{8}}-{0}-[A-F0-9]{{4}}-[A-F0-9]{{4}}-[A-F0-9]{{12}}).", FILE_TYPE_HINT);
        public static readonly string MessageOpenDetectorRegex = @"/emarketing/omd.gif";
        public static readonly string MessageOpenDetectorUrlRegex = @"/emod.gif";
        public static readonly string ClickThruDetectorRegex = @"/ct?";
        public static readonly string ClickThruDetectorUrlRegex = @"/clickthru";
        public static readonly string MultipleEmailRegex = @"^(([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+( )*(;|,)?( )*)+$";
        public static readonly string NodeBolderRegex = @"\<\w+ name=""(\w+?)"".*?/\>";
        public static readonly string ProcessorRegex = @"(\%(\w|\:|\.)+\%)";
        public static readonly string AccountCodeRegex = @"(.*)-(\d*)";
        public static readonly string ZipCodeRegex = @"(^\d{5}(-\d{4})?$)|(^[ABCEGHJKLMNPRSTVXY]{1}\d{1}[A-Z]{1} *\d{1}[A-Z]{1}\d{1}$)";
        public static readonly string AddressRegex = @"(.+)_Address_(.+)";
        public static readonly string PhoneRegex = @"(.+)_PhoneNumber";
        public static readonly string OrganizationalLayerTypeFieldNameRegex = String.Format(@"^_OrgLayer_(?<Segment1>[A-Fa-f0-9]{{8}})(?<Segment2>{0})(?<Segment3>[A-Fa-f0-9]{{4}})(?<Segment4>[A-Fa-f0-9]{{4}})(?<Segment5>[A-Fa-f0-9]{{12}})$", ORGANIZATIONAL_LAYER_TYPE_HINT);
        public static readonly string AddOnFieldNameRegex = String.Format(@"^_AddOn_(?<Segment1>[A-Fa-f0-9]{{8}})(?<Segment2>{0})(?<Segment3>[A-Fa-f0-9]{{4}})(?<Segment4>[A-Fa-f0-9]{{4}})(?<Segment5>[A-Fa-f0-9]{{12}})", MERCHANDISE_HINT);
        public static readonly string PortalSelfHostRegex = "^http(s?)://";
        public static readonly string SerializedObjectDetectorRegex = PREFIX_FOR_SERIALIZATION + @"\|\|\|(.*?)\|\|\|(.*)";
        public static readonly string FirstLetterBreakerRegex = @"(\w)\w+";
        public static readonly string SearchResultTokenRegex = @"\[SearchResult\](\w+)";
        public static readonly string SectionTextFieldTokenRegex = @"\{(.*?)\}";
        public static readonly string MemberParserRegex = @"M:MemberSuite.SDK.Concierge.IConciergeAPIService.(\w+)(\((.*?)\))?";
        public static readonly string PhoneNumberRegex = @"\d";
        public static readonly string MerchandiseFieldNameRegex = String.Format(@"^_(?<Segment1>[A-Fa-f0-9]{{8}})(?<Segment2>{0})(?<Segment3>[A-Fa-f0-9]{{4}})(?<Segment4>[A-Fa-f0-9]{{4}})(?<Segment5>[A-Fa-f0-9]{{12}})_Purchase(?<AggregateType>Total|Count)$", EVENT_MERCHANDISE_TYPE_HINT);
        public static readonly string BankRoutingNumberRegex = @"^((0[0-9])|(1[0-2])|(2[1-9])|(3[0-2])|(6[1-9])|(7[0-2])|80)([0-9]{7})$";
        public static readonly string MultiObjectRegex = @"objects\((.*?)\)";
        public static readonly string SinglequotesRegex = @"^'(.*?)'$";
        public static readonly string InvalidFileCharactersRegex = @"[?:\\/*""<>|\.,]";
        public static readonly string ModuleGuesserRegex = @".(\w+)";
        public static readonly string BaseUrlReplacerRegex = @"http://localhost";
        public static readonly string ImagesReplacerRegex = @"\$imageserver\$";
        public static readonly string MemberSuiteVersion1GuidRegex = "[A-F0-9]{8}-0[0-1][A-F0-9]{2}-4[A-F0-9]{3}-[A-F0-9]{4}-[A-F0-9]{12}";
        public static readonly string MemberSuiteVersion1AssociationGuidRegex = "[A-F0-9]{8}-0{3}4-4[A-F0-9]{3}-[A-F0-9]{4}-[A-F0-9]{12}";
        public static readonly string MemberSuiteVersion1SystemGuidRegex = "0{8}-0[0-1][A-F0-9]{2}-4[A-F0-9]{3}-[A-F0-9]{4}-[A-F0-9]{12}";
        public static readonly string UniqueIndexViolationDetectedRegex = @"((UC|UX|IX|PK)_\w+)";
        public static readonly string ForeignKeyViolationDetectedRegex = @"(FK_\w+)";
        public static readonly string IntegrationLinkRegex = @"console.(\w+).view";
        public static readonly string CustomFieldDetectorRegex = @"^CustomField:(\{{0,1}([0-9a-fA-F]){8}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){12}\}{0,1})$";
        public static readonly string CustomFieldRegex = @"CustomField:(.*)";
        public static readonly string SkinContentPlaceholderRegex = @"\$\$\s*CONTENT\s*\$\$";
        public static readonly string SkinValidationRegex = @"(\<form)|(\<\/form\>)|(\<body)|(\<\/body\>)|(\<head)|(\<\/head\>)|(\<html)|(\<\/html\>)";
        public static readonly string CssValidationRegex = @"(\<style)|(\<\/style\>)";
        public static readonly string WhitespaceRegex = "\\s*";
        public static readonly string AddressTypeRegex = @"(.*)_Address";
        public static readonly string FieldDetectorRegex = @"\#\#([^\#].*?)(\{(?<Option>\w+):(?<Value>.*?)\})*?\#\#";
        public static readonly string SubSearchDetectorRegex = @"\<!--SubSearch_(?<SubSearchId>\w+)\>(?<SubSearchTemplate>[\w\W]*)\<\/SubSearch_\k<SubSearchId>--\>";
        public static readonly string UpdateWhereClauseRegex = @"ID *= *'([A-Fa-f0-9]{8}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{12})'";
        public static readonly string SingleObjectRegex = @"object\((.*?)\)";
        public static readonly string SinglequotesDateRegex = @"^'\[d\](.*?)'$";
        public static readonly string PercentagesRegex = @"^%(.*?)%$";
        public static readonly string BracketsRegex = @"^\[(.*?)\]$";
        public static readonly string DoublequotesRegex = "^\"(.*?)\"$";
        public static readonly string MinRegex = @"min\((.*?)\)";
        public static readonly string MaxRegex = @"max\((.*?)\)";
        public static readonly string AvgRegex = @"avg\((.*?)\)";
        public static readonly string SumRegex = @"sum\((.*?)\)";
        public static readonly string CountRegex = @"count\((.*?)\)";
        public static readonly string TopNRegex = @"^select +top +(\d+) ";
        public static readonly string TableNameAndContextRegex = @"^(.*?)\(\'?(.*?)\'?\)$";
        public static readonly string CalculatedFieldsRegex = @"{(.*?)}";
        public static readonly string JoinedColumnRegex = @"(\w+?)\.(.*)";
        public static readonly string SqlInjectionDetectorRegex = @";|\(|\)|'|%|\+|\-| ";
        public static readonly string StartingJoinParserRegex = @"(.*)\.(\w+)";
        public static readonly string DetectSimpleDiscriminatorRegex = @"select \* from (\w+) where PartitionKey=\d* and ClassType='\w+'";
        public static readonly string PrefixRegex = @"(.*)\.";
        public static readonly string MessageCategoryRegex = @"EmailForMessageCategory_(.*)";
        public static readonly string SessionFieldNameRegex = @"Session_(.*)";
        public static readonly string OrderByParserRegex = @"(.+?)( DESC)?(?x:,|$)";
        public static readonly string TransitionRegex = @"Transition:(\w+)";
        public static readonly string ParserRegex = @"([^\^\|\[\{]*)(?:\|([^\^\|\[\{]*))?(?:(?:\[(.*)\])|(?:\{(.*)\}))?(?:\^([+-]?\d+))?";
        public static readonly string CharactersThatNecessitateSpringRegex = @"\.|\[|\]";
        public static readonly string CardTestRegex = "^(?:(?<Visa>4\\d{3})|(?<MasterCard>5[1-5]\\d{2})|(?<Discover>6011)|(?<DinersClub>(?:3[68]\\d{2})|(?:30[0-5]\\d))|(?<Amex>3[47]\\d{2}))([ -]?)(?(DinersClub)(?:\\d{6}\\1\\d{4})|(?(Amex)(?:\\d{6}\\1\\d{5})|(?:\\d{4}\\1\\d{4}\\1\\d{4})))$";
        public static readonly string GuidRegex = @"^[a-fA-F\d]{8}-([a-fA-F\d]{4}-){3}[a-fA-F\d]{12}$";
        public static readonly string PostalCodeRegex = @"(^\d{5}$)|(^\d{5}-\d{4}$)";
        public static readonly string PathSplitterRegex = @"(.*)\\(.*)";
        public static readonly string OldConnectionStringParserRegex = @"server=(.*?);database=(.*?);(UID=(.*?);Password=(.*))?"; //, RegexOptions.Compiled | RegexOptions.IgnoreCase );
        public static readonly string NewConnectionStringParserRegex = @"Data Source=(.*?);Initial Catalog=(.*?);"; //, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static readonly string RemoveSpecialCharactersRegex = "[^a-zA-Z0-9_.]+"; 
        //uncached, accomodate within the default 15
        public static Func<string, string> GetDefaultPortalUrlRegex = protocol => String.Format(@"{0}://customer(?<PartitionKey>\d+)(?<Last4>[A-Fa-f0-9]{{4,}})", protocol);
        //caller caches appdomain-wide
        public static Func<string, Regex> GetCompiledRegex = x => new Regex(x, RegexOptions.Compiled);

        static RegularExpressions()
        {
            Func<FieldInfo, bool> regexes = x => x.FieldType == typeof(string) && x.Name.EndsWith("Regex");
            Regex.CacheSize += typeof(RegularExpressions).GetFields().Count(regexes);
        }
    }
}
