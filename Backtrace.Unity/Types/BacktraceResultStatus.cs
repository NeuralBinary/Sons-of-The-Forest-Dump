using System;
using Il2CppDummyDll;

namespace Backtrace.Unity.Types
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public enum BacktraceResultStatus
	{
		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		LimitReached,
		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		ServerError,
		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		Ok,
		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		Empty,
		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		NetworkError
	}
}
