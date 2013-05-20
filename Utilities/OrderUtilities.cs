using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using MemberSuite.SDK.Concierge;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Utilities
{
    public static class OrderUtilities
    {
        public static msAuditLog WaitForOrderToComplete(IConciergeAPIService api, string tracingID)
        {
            if (api == null) throw new ArgumentNullException("api");
            if (tracingID == null) throw new ArgumentNullException("tracingID");

            // code for synchronous orders
            //var msoLog = api.CheckLongRunningTaskStatus(tracingID).ResultValue;
            //if (msoLog != null) // we've got it
            //    return msoLog.ConvertTo<msAuditLog>();


            //return null;

             
            DateTime dtStart = DateTime.Now;

            string strWait = ConfigurationManager.AppSettings["OrderProcessingTimeOut"];

            int numberOfSecondsToWait;
            if (!int.TryParse(strWait, out numberOfSecondsToWait))
                numberOfSecondsToWait = 45;

            int waitTime = 5500; // we're going to back off of this
            
            
            do
            {
                Thread.Sleep(waitTime); // wait a second, in case it's ready right away
                var msoLog = api.CheckLongRunningTaskStatus(tracingID).ResultValue;
                if (msoLog != null) // we've got it
                {
                    var log = msoLog.ConvertTo<msAuditLog>();
                    if (log.Description != null && log.Description.StartsWith("INTERNAL"))
                        log.Description = "An internal error occurred. Please try your order again.";
                    return log;
                }
                
                waitTime += 1000;   // so it will be 1.5, 2.5, 3.5, 4.5, a linear back-off
            } while ((DateTime.Now - dtStart).TotalSeconds < numberOfSecondsToWait);

            return null;        // nothing*/
        }
    }
}
