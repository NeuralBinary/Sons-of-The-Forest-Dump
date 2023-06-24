using System;
using System.Collections.Generic;
using Backtrace.Unity.Json;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Metrics
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	public sealed class UniqueEvent : EventAggregationBase
	{
		// Token: 0x06000213 RID: 531 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x7556B0", Offset = "0x753CB0", VA = "0x1807556B0")]
		internal UniqueEvent(string name, long timestamp, IDictionary<string, string> attributes)
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x755770", Offset = "0x753D70", VA = "0x180755770")]
		internal void UpdateTimestamp(long timestamp, IDictionary<string, string> attributes)
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x755870", Offset = "0x753E70", VA = "0x180755870")]
		internal BacktraceJObject ToJson()
		{
			return null;
		}

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		internal const string UniqueEventName = "unique";

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x20")]
		internal IDictionary<string, string> Attributes;
	}
}
