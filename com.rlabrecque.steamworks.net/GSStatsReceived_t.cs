using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	[CallbackIdentity(1800)]
	public struct GSStatsReceived_t
	{
		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		public const int k_iCallback = 1800;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x4")]
		public CSteamID m_steamIDUser;
	}
}
