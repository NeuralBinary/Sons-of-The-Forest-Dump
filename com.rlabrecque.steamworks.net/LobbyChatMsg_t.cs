using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	[CallbackIdentity(507)]
	public struct LobbyChatMsg_t
	{
		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		public const int k_iCallback = 507;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDUser;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x10")]
		public byte m_eChatEntryType;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x14")]
		public uint m_iChatID;
	}
}
