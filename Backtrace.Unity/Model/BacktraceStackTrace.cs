using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	internal class BacktraceStackTrace
	{
		// Token: 0x060001B9 RID: 441 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x750BA0", Offset = "0x74F1A0", VA = "0x180750BA0")]
		public BacktraceStackTrace(Exception exception)
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x750CD0", Offset = "0x74F2D0", VA = "0x180750CD0")]
		private void Initialize()
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x750E90", Offset = "0x74F490", VA = "0x180750E90")]
		private void SetStacktraceInformation(StackFrame[] frames, bool generatedByException = false)
		{
		}

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x10")]
		public readonly List<BacktraceStackFrame> StackFrames;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x18")]
		private readonly Exception _exception;
	}
}
