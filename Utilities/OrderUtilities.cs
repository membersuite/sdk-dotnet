using System;
using System.Configuration;
using System.Threading;
using MemberSuite.SDK.Concierge;
using MemberSuite.SDK.Types;

namespace MemberSuite.SDK.Utilities
{
    public static class OrderUtilities
    {
        public static LongRunningTaskStatusInfo WaitForOrderToComplete(IConciergeAPIService api, LongRunningTaskInfo info)
        {
            if (api == null) throw new ArgumentNullException("api");
            if (info == null) throw new ArgumentNullException("info");
            

            // code for synchronous orders
            var statusUpdate = api.CheckLongRunningTaskStatus(info).ResultValue;

            if (statusUpdate.Status != LongRunningTaskStatus.Running)
                return statusUpdate;
            
            
            var dtStart = DateTime.Now;

            var strWait = ConfigurationManager.AppSettings["OrderProcessingTimeOut"];

            int numberOfSecondsToWait;
            if (!int.TryParse(strWait, out numberOfSecondsToWait))
                numberOfSecondsToWait = 45;

            var waitTime = 5500; // we're going to back off of this


            do
            {
                Thread.Sleep(waitTime); // wait a second, in case it's ready right away

                statusUpdate = api.CheckLongRunningTaskStatus(info).ResultValue;

                if (statusUpdate.Status != LongRunningTaskStatus.Running)
                    return statusUpdate;
             

                waitTime += 1000; // so it will be 1.5, 2.5, 3.5, 4.5, a linear back-off
            } while ((DateTime.Now - dtStart).TotalSeconds < numberOfSecondsToWait);

            
            return statusUpdate; // nothing*/
        }
    }
}