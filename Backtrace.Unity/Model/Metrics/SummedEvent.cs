using System;
using System.Collections.Generic;
using Backtrace.Unity.Json;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Metrics
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	internal sealed class SummedEvent : EventAggregationBase
	{
		// Token: 0x0600020C RID: 524 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x754B20", Offset = "0x753120", VA = "0x180754B20")]
		internal SummedEvent(string name)
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x754BD0", Offset = "0x7531D0", VA = "0x180754BD0")]
		internal SummedEvent(string name, long timestamp, IDictionary<string, string> attributes)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x754CF0", Offset = "0x7532F0", VA = "0x180754CF0")]
		internal BacktraceJObject ToJson(IDictionary<string, string> scopedAttributes)
		{
			return null;
		}

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		internal const string MetricGroupName = "metric_group";

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x20")]
		internal readonly IDictionary<string, string> Attributes;
	}
}
