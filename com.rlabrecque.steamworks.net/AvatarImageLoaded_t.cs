using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	[CallbackIdentity(334)]
	public struct AvatarImageLoaded_t
	{
		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		public const int k_iCallback = 334;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamID;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x8")]
		public int m_iImage;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0xC")]
		public int m_iWide;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x10")]
		public int m_iTall;
	}
}
