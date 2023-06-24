using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	[CallbackIdentity(1108)]
	public struct GSStatsUnloaded_t
	{
		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		public const int k_iCallback = 1108;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;
	}
}
