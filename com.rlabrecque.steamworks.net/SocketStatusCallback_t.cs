using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000A2 RID: 162
	[Token(Token = "0x20000A2")]
	[CallbackIdentity(1201)]
	public struct SocketStatusCallback_t
	{
		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		public const int k_iCallback = 1201;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x0")]
		public SNetSocket_t m_hSocket;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x4")]
		public SNetListenSocket_t m_hListenSocket;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDRemote;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x10")]
		public int m_eSNetSocketState;
	}
}
