using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public enum GraphUpdateThreading
	{
		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		UnityThread,
		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		SeparateThread,
		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		UnityInit,
		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		UnityPost = 4,
		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		SeparateAndUnityInit = 3
	}
}
