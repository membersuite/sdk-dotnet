using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MemberSuite.SDK.Searching;
using MemberSuite.SDK.Searching.Operations;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Utilities
{
    public static class EventUtilities
    {
        public static Search GetSearchToTellMeAllLinkedEventRelatedProducts(string ownerID, string srcEventID)
        {
            Search sPurchases = new Search("Purchase");

            SearchOperationGroup sgProductType = new SearchOperationGroup();
            sgProductType.GroupType = SearchOperationGroupType.Or;
            sgProductType.Criteria.Add(Expr.Equals("Product.Event", srcEventID)); // find event products
            sgProductType.Criteria.Add(Expr.Equals("Product.Event.ParentEvent", srcEventID));
            // find parent event oriducts
            sPurchases.AddCriteria(sgProductType);

            sPurchases.AddCriteria(Expr.Equals("Order.BillTo", ownerID));
            sPurchases.AddCriteria(Expr.DoesNotEqual("Status", OrderStatus.Cancelled.ToString()));


            sPurchases.AddOutputColumn("Order");
            sPurchases.AddOutputColumn("OrderLineItemID");
            sPurchases.AddSortColumn("Order.CreatedDate");
            return sPurchases;
        }
    }
}
