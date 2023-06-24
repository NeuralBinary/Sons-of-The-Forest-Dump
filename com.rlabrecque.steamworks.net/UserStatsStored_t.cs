using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000E8 RID: 232
	[Token(Token = "0x20000E8")]
	[CallbackIdentity(1102)]
	public struct UserStatsStored_t
	{
		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		public const int k_iCallback = 1102;

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;
	}
}
