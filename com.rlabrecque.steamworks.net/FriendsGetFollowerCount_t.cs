using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	[CallbackIdentity(344)]
	public struct FriendsGetFollowerCount_t
	{
		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		public const int k_iCallback = 344;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x4")]
		public CSteamID m_steamID;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0xC")]
		public int m_nCount;
	}
}
