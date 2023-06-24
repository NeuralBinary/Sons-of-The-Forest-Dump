using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000133 RID: 307
	[Token(Token = "0x2000133")]
	[NullableContext(1)]
	[Nullable(0)]
	public class MemoryTraceWriter : ITraceWriter
	{
		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x00005190 File Offset: 0x00003390
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016F")]
		public TraceLevel LevelFilter
		{
			[Token(Token = "0x6000975")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return TraceLevel.Off;
			}
			[Token(Token = "0x6000976")]
			[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000977")]
		[Address(RVA = "0x25A2860", Offset = "0x25A0E60", VA = "0x1825A2860")]
		public MemoryTraceWriter()
		{
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000978")]
		[Address(RVA = "0x25A29A0", Offset = "0x25A0FA0", VA = "0x1825A29A0", Slot = "5")]
		public void Trace(TraceLevel level, string message, [Nullable(2)] Exception ex)
		{
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000979")]
		[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
		public IEnumerable<string> GetTraceMessages()
		{
			return null;
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600097A")]
		[Address(RVA = "0x25A2D80", Offset = "0x25A1380", VA = "0x1825A2D80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040005B6 RID: 1462
		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x10")]
		private readonly Queue<string> _traceMessages;

		// Token: 0x040005B7 RID: 1463
		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0x18")]
		private readonly object _lock;
	}
}
