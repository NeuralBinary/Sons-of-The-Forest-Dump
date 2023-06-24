using System;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000DC RID: 220
	[Token(Token = "0x20000DC")]
	[Flags]
	public enum COMMANDREPLAY_FLAGS : uint
	{
		// Token: 0x04000489 RID: 1161
		[Token(Token = "0x4000489")]
		NORMAL = 0U,
		// Token: 0x0400048A RID: 1162
		[Token(Token = "0x400048A")]
		SKIP_CLEANUP = 1U,
		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		FAST_FORWARD = 2U,
		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		SKIP_BANK_LOAD = 4U
	}
}
