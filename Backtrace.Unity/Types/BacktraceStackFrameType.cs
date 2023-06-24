using System;
using Il2CppDummyDll;

namespace Backtrace.Unity.Types
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	internal enum BacktraceStackFrameType
	{
		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		Unknown,
		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		Dotnet,
		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		Android,
		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		Native
	}
}
