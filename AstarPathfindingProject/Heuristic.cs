using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	public enum Heuristic
	{
		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		Manhattan,
		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		DiagonalManhattan,
		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		Euclidean,
		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		None
	}
}
