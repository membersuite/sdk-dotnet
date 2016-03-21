using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Utilities
{
    public static class ClientSideSearch
    {
        public static string GetNameOfQuickSearchClientSideIndex(long? partitionKey, string quickSearchName)
        {
            switch (quickSearchName)
            {
                // for global classes, the we don't use a partitionkey
                case msReseller.CLASS_NAME:
                case msAssociation.CLASS_NAME:
                case msCustomer.CLASS_NAME:
                    partitionKey = null;
                    break;
            }
            var pk = partitionKey.HasValue ? partitionKey.ToString() : "global";
            return string.Format("qs_{0}_{1}", pk, quickSearchName);
        }
    }
}