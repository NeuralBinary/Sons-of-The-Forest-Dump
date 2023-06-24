using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	[CallbackIdentity(5701)]
	public struct SteamRemotePlaySessionConnected_t
	{
		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		public const int k_iCallback = 5701;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x0")]
		public RemotePlaySessionID_t m_unSessionID;
	}
}
