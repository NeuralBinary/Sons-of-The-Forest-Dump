using System;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000DA RID: 218
	[Token(Token = "0x20000DA")]
	[Flags]
	public enum LOAD_BANK_FLAGS : uint
	{
		// Token: 0x04000480 RID: 1152
		[Token(Token = "0x4000480")]
		NORMAL = 0U,
		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4000481")]
		NONBLOCKING = 1U,
		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		DECOMPRESS_SAMPLES = 2U,
		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4000483")]
		UNENCRYPTED = 4U
	}
}
