using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	[CallbackIdentity(1801)]
	public struct GSStatsStored_t
	{
		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		public const int k_iCallback = 1801;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x4")]
		public CSteamID m_steamIDUser;
	}
}
