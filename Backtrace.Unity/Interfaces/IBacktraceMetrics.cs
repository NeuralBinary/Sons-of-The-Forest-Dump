using System;
using System.Collections.Generic;
using Backtrace.Unity.Model.Attributes;
using Il2CppDummyDll;

namespace Backtrace.Unity.Interfaces
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public interface IBacktraceMetrics : IScopeAttributeProvider
	{
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000364 RID: 868
		// (set) Token: 0x06000365 RID: 869
		[Token(Token = "0x170000A0")]
		uint MaximumSummedEvents { [Token(Token = "0x6000364")] get; [Token(Token = "0x6000365")] set; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000366 RID: 870
		// (set) Token: 0x06000367 RID: 871
		[Token(Token = "0x170000A1")]
		uint MaximumUniqueEvents { [Token(Token = "0x6000366")] get; [Token(Token = "0x6000367")] set; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000368 RID: 872
		// (set) Token: 0x06000369 RID: 873
		[Token(Token = "0x170000A2")]
		string UniqueEventsSubmissionUrl { [Token(Token = "0x6000368")] get; [Token(Token = "0x6000369")] set; }

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600036A RID: 874
		// (set) Token: 0x0600036B RID: 875
		[Token(Token = "0x170000A3")]
		string SummedEventsSubmissionUrl { [Token(Token = "0x600036A")] get; [Token(Token = "0x600036B")] set; }

		// Token: 0x0600036C RID: 876
		[Token(Token = "0x600036C")]
		void Send();

		// Token: 0x0600036D RID: 877
		[Token(Token = "0x600036D")]
		bool AddSummedEvent(string metricsGroupName);

		// Token: 0x0600036E RID: 878
		[Token(Token = "0x600036E")]
		bool AddSummedEvent(string metricsGroupName, IDictionary<string, string> attributes);
	}
}
