using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	[CallbackIdentity(207)]
	public struct GSGameplayStats_t
	{
		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		public const int k_iCallback = 207;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x4")]
		public int m_nRank;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x8")]
		public uint m_unTotalConnects;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0xC")]
		public uint m_unTotalMinutesPlayed;
	}
}
