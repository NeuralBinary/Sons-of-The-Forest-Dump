using System;
using System.Collections.Generic;
using Backtrace.Unity.Json;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.JsonData
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public class ThreadData
	{
		// Token: 0x06000240 RID: 576 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x75A190", Offset = "0x758790", VA = "0x18075A190")]
		internal ThreadData(IEnumerable<BacktraceStackFrame> exceptionStack, bool faultingThread)
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x75A400", Offset = "0x758A00", VA = "0x18075A400")]
		public BacktraceJObject ToJson()
		{
			return null;
		}

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ThreadInformation> ThreadInformations;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x18")]
		internal string MainThread;
	}
}
