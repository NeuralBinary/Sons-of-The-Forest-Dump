using System;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	internal sealed class BacktraceDefaultClassifierTypes
	{
		// Token: 0x0600016E RID: 366 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BacktraceDefaultClassifierTypes()
		{
		}

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		internal const string MessageType = "Message";

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		internal const string ExceptionType = "Exception";

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		internal const string UnhandledExceptionType = "Unhandled exception";

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		internal const string OOMExceptionType = "OOMException";

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		internal const string AnrExceptionType = "Hang";
	}
}
