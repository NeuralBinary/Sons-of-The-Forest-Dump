using System;
using Il2CppDummyDll;

namespace Sons.Areas
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[Flags]
	public enum AreaMask
	{
		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		None = 0,
		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		CaveA = 2,
		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		CaveB = 4,
		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		CaveC = 8,
		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		CaveD = 16,
		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		BunkerA = 131072,
		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		BunkerB = 262144,
		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		BunkerC = 524288,
		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		BunkerD = 1048576,
		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		BunkerE = 2097152,
		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		BunkerF = 4194304,
		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		BunkerG = 32,
		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		Raft = 8388608,
		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		AllCaves = 30,
		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		AllBunkers = 8257568,
		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		All = 8257598
	}
}
