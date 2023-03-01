using System;
using Il2CppDummyDll;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x020006E3 RID: 1763
	[Token(Token = "0x20006E3")]
	[Flags]
	[Serializable]
	public enum TreeCutCellRemovedFlags
	{
		// Token: 0x0400286C RID: 10348
		[Token(Token = "0x400286C")]
		Undefined = 0,
		// Token: 0x0400286D RID: 10349
		[Token(Token = "0x400286D")]
		Self = 16,
		// Token: 0x0400286E RID: 10350
		[Token(Token = "0x400286E")]
		Dir0 = 32,
		// Token: 0x0400286F RID: 10351
		[Token(Token = "0x400286F")]
		Dir1 = 64,
		// Token: 0x04002870 RID: 10352
		[Token(Token = "0x4002870")]
		Dir2 = 128,
		// Token: 0x04002871 RID: 10353
		[Token(Token = "0x4002871")]
		Dir3 = 256,
		// Token: 0x04002872 RID: 10354
		[Token(Token = "0x4002872")]
		Dir4 = 512,
		// Token: 0x04002873 RID: 10355
		[Token(Token = "0x4002873")]
		Dir5 = 1024,
		// Token: 0x04002874 RID: 10356
		[Token(Token = "0x4002874")]
		Dir6 = 2048,
		// Token: 0x04002875 RID: 10357
		[Token(Token = "0x4002875")]
		Dir7 = 4096
	}
}
