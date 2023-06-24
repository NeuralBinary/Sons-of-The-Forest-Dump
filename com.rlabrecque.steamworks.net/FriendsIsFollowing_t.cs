using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	[CallbackIdentity(345)]
	public struct FriendsIsFollowing_t
	{
		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		public const int k_iCallback = 345;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x4")]
		public CSteamID m_steamID;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0xC")]
		public bool m_bIsFollowing;
	}
}
