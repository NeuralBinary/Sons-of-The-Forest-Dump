using System;
using Backtrace.Unity.Types;
using Il2CppDummyDll;

namespace Backtrace.Unity.Common
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	internal struct MiniDumpExceptionInformation
	{
		// Token: 0x0600038A RID: 906 RVA: 0x00003134 File Offset: 0x00001334
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x769C50", Offset = "0x768250", VA = "0x180769C50")]
		internal static MiniDumpExceptionInformation GetInstance(MinidumpException exceptionInfo)
		{
			return default(MiniDumpExceptionInformation);
		}

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x0")]
		internal uint ThreadId;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x4")]
		internal IntPtr ExceptionPointers;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0xC")]
		internal bool ClientPointers;
	}
}
