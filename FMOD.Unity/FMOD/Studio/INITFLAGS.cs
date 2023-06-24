using System;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000D9 RID: 217
	[Token(Token = "0x20000D9")]
	[Flags]
	public enum INITFLAGS : uint
	{
		// Token: 0x04000479 RID: 1145
		[Token(Token = "0x4000479")]
		NORMAL = 0U,
		// Token: 0x0400047A RID: 1146
		[Token(Token = "0x400047A")]
		LIVEUPDATE = 1U,
		// Token: 0x0400047B RID: 1147
		[Token(Token = "0x400047B")]
		ALLOW_MISSING_PLUGINS = 2U,
		// Token: 0x0400047C RID: 1148
		[Token(Token = "0x400047C")]
		SYNCHRONOUS_UPDATE = 4U,
		// Token: 0x0400047D RID: 1149
		[Token(Token = "0x400047D")]
		DEFERRED_CALLBACKS = 8U,
		// Token: 0x0400047E RID: 1150
		[Token(Token = "0x400047E")]
		LOAD_FROM_UPDATE = 16U
	}
}
