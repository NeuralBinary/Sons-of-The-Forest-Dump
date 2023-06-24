using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000EE RID: 238
	[Token(Token = "0x20000EE")]
	[CallbackIdentity(1108)]
	public struct UserStatsUnloaded_t
	{
		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		public const int k_iCallback = 1108;

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;
	}
}
