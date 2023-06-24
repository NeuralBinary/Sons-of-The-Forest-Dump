using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000109 RID: 265
	[Token(Token = "0x2000109")]
	public class DiagnosticsTraceWriter : ITraceWriter
	{
		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x000046C8 File Offset: 0x000028C8
		// (set) Token: 0x060007AF RID: 1967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EF")]
		public TraceLevel LevelFilter
		{
			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return TraceLevel.Off;
			}
			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x000046E0 File Offset: 0x000028E0
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x257E1E0", Offset = "0x257C7E0", VA = "0x18257E1E0")]
		private TraceEventType GetTraceEventType(TraceLevel level)
		{
			return (TraceEventType)0;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x257E270", Offset = "0x257C870", VA = "0x18257E270", Slot = "5")]
		[NullableContext(1)]
		public void Trace(TraceLevel level, string message, [Nullable(2)] Exception ex)
		{
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DiagnosticsTraceWriter()
		{
		}
	}
}
