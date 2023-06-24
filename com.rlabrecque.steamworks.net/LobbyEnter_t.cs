using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	[CallbackIdentity(504)]
	public struct LobbyEnter_t
	{
		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		public const int k_iCallback = 504;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x8")]
		public uint m_rgfChatPermissions;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0xC")]
		public bool m_bLocked;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x10")]
		public uint m_EChatRoomEnterResponse;
	}
}
