using System;
using Il2CppDummyDll;

namespace Sons.Environment.Digging
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	[Flags]
	[Serializable]
	public enum DiggingTileTypeFlags
	{
		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		Undefined = 0,
		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		Top = 1,
		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		Bottom = 2,
		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		Right = 4,
		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		Left = 8,
		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		Front = 16,
		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		Back = 32
	}
}
