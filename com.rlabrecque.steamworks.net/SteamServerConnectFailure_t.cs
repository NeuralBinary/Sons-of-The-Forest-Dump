using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000DA RID: 218
	[Token(Token = "0x20000DA")]
	[CallbackIdentity(102)]
	public struct SteamServerConnectFailure_t
	{
		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		public const int k_iCallback = 102;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x4")]
		public bool m_bStillRetrying;
	}
}
