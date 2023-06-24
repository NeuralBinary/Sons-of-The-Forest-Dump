using System;
using System.Collections.Generic;
using Backtrace.Unity.Json;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.JsonData
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	public class BacktraceAttributes
	{
		// Token: 0x06000233 RID: 563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x759A20", Offset = "0x758020", VA = "0x180759A20")]
		public BacktraceAttributes(BacktraceReport report, Dictionary<string, string> clientAttributes)
		{
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x759D30", Offset = "0x758330", VA = "0x180759D30")]
		public BacktraceJObject ToJson()
		{
			return null;
		}

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x10")]
		public readonly Dictionary<string, string> Attributes;
	}
}
