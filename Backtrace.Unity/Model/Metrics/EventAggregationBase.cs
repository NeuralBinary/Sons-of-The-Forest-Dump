using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Backtrace.Unity.Json;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Metrics
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	public abstract class EventAggregationBase
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00002954 File Offset: 0x00000B54
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005A")]
		public long Timestamp
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x754960", Offset = "0x752F60", VA = "0x180754960")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005B")]
		public string Name
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x754970", Offset = "0x752F70", VA = "0x180754970")]
		public EventAggregationBase(string name, long timestamp)
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x7549D0", Offset = "0x752FD0", VA = "0x1807549D0")]
		internal BacktraceJObject ToBaseObject(IDictionary<string, string> attributes)
		{
			return null;
		}

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		private const string TimestampName = "timestamp";

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		private const string AttributesName = "attributes";
	}
}
