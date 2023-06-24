using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	public enum GraphUpdateStage
	{
		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		Created,
		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		Pending,
		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		Applied,
		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		Aborted
	}
}
