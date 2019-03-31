using System;
using System.Collections.Generic;
using System.Text;

namespace test.Models
{
    class TdLiveQuoteItem
    {
        public string Name { get; set; }
   //     Name
			//,CustomerName
			//,Description
			//,TotalQuoted
			//,TotalCost
			//,Cast(case when TotalCost <> 0 and TotalQuoted <> 0

   //             Then 1-TotalCost/TotalQuoted
   //             Else 0

   //             End as decimal(18,2)) as MarginPercent
			//,LastStatus
			//,ExpectedAwardDate
			//--,LastStatusDate
			//,Cast(CalculatedTotalHours as Decimal(18,0)) as TotalQuotedHours
			//--,Case when RequestFrom is null then '' else RequestFrom end as RequestFrom
			//--,Case when requestdate is null then GETDATE() else RequestDate end as RequestDate
			//--,Cast(case when Requestdate is null then 0 else DATEDIFF(DAY, RequestDate, GETDATE()) end as Int) as ElapsedDays
			//,Salesman
			//--,ModifiedBy
			//--,ModifiedOn
			//--,SentToClient
			//--,DateSent
			//--,FollowUpdate
			//--,DateExpired
			//,case when InternalComments is null then '' else InternalComments end as InternalComments

    }
}
