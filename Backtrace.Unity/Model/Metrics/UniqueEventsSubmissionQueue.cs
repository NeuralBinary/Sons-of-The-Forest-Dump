using System;
using System.Collections.Generic;
using Backtrace.Unity.Json;
using Backtrace.Unity.Model.JsonData;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Metrics
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	internal sealed class UniqueEventsSubmissionQueue : MetricsSubmissionQueue<UniqueEvent>
	{
		// Token: 0x06000216 RID: 534 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x755920", Offset = "0x753F20", VA = "0x180755920")]
		public UniqueEventsSubmissionQueue(string submissionUrl, AttributeProvider attributeProvider)
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x7559E0", Offset = "0x753FE0", VA = "0x1807559E0", Slot = "4")]
		public override void StartWithEvent(string eventName)
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x755BA0", Offset = "0x7541A0", VA = "0x180755BA0", Slot = "6")]
		internal override IEnumerable<BacktraceJObject> GetEventsPayload(ICollection<UniqueEvent> events)
		{
			return null;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x7560E0", Offset = "0x7546E0", VA = "0x1807560E0")]
		private IDictionary<string, string> GetUniqueEventAttributes()
		{
			return null;
		}

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		private const string Name = "unique_events";

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x58")]
		private readonly AttributeProvider _attributeProvider;
	}
}
