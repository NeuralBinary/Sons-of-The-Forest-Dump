using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	[CallbackIdentity(336)]
	public struct FriendRichPresenceUpdate_t
	{
		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		public const int k_iCallback = 336;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDFriend;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
}
