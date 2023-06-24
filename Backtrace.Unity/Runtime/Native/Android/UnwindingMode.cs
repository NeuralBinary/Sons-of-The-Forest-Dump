using System;
using Il2CppDummyDll;

namespace Backtrace.Unity.Runtime.Native.Android
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	internal enum UnwindingMode
	{
		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		LOCAL,
		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		REMOTE,
		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		REMOTE_DUMPWITHOUTCRASH,
		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		LOCAL_DUMPWITHOUTCRASH,
		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		LOCAL_CONTEXT
	}
}
