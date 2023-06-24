using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[CallbackIdentity(342)]
	public struct JoinClanChatRoomCompletionResult_t
	{
		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		public const int k_iCallback = 342;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x8")]
		public EChatRoomEnterResponse m_eChatRoomEnterResponse;
	}
}
