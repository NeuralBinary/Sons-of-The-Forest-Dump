using System;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000CD RID: 205
	[Token(Token = "0x20000CD")]
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		PREUPDATE = 1U,
		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		POSTUPDATE = 2U,
		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		BANK_UNLOAD = 4U,
		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		ALL = 4294967295U
	}
}
