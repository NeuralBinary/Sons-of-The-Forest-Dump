using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	public enum PathState
	{
		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		Created,
		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		PathQueue,
		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		Processing,
		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		ReturnQueue,
		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		Returned
	}
}
