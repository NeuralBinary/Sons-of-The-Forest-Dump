using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	[CallbackIdentity(506)]
	public struct LobbyChatUpdate_t
	{
		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		public const int k_iCallback = 506;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDUserChanged;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x10")]
		public ulong m_ulSteamIDMakingChange;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x18")]
		public uint m_rgfChatMemberStateChange;
	}
}
