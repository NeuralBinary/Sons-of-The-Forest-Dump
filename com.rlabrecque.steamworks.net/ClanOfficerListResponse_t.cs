using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	[CallbackIdentity(335)]
	public struct ClanOfficerListResponse_t
	{
		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		public const int k_iCallback = 335;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClan;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x8")]
		public int m_cOfficers;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0xC")]
		public byte m_bSuccess;
	}
}
