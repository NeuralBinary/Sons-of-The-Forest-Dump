using System;
using System.Collections.Generic;
using Backtrace.Unity.Json;
using Backtrace.Unity.Model.JsonData;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Metrics
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	internal sealed class SummedEventsSubmissionQueue : MetricsSubmissionQueue<SummedEvent>
	{
		// Token: 0x0600020F RID: 527 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x754FC0", Offset = "0x7535C0", VA = "0x180754FC0")]
		public SummedEventsSubmissionQueue(string submissionUrl, AttributeProvider attributeProvider)
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x755080", Offset = "0x753680", VA = "0x180755080", Slot = "4")]
		public override void StartWithEvent(string eventName)
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x7551B0", Offset = "0x7537B0", VA = "0x1807551B0", Slot = "6")]
		internal override IEnumerable<BacktraceJObject> GetEventsPayload(ICollection<SummedEvent> events)
		{
			return null;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x755480", Offset = "0x753A80", VA = "0x180755480", Slot = "5")]
		internal override void OnMaximumAttemptsReached(ICollection<SummedEvent> events)
		{
		}

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		private const string Name = "summed_events";

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x58")]
		private readonly AttributeProvider _attributeProvider;
	}
}
