using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	[CallbackIdentity(209)]
	public struct GSReputation_t
	{
		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		public const int k_iCallback = 209;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x4")]
		public uint m_unReputationScore;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x8")]
		public bool m_bBanned;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0xC")]
		public uint m_unBannedIP;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x10")]
		public ushort m_usBannedPort;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x18")]
		public ulong m_ulBannedGameID;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x20")]
		public uint m_unBanExpires;
	}
}
