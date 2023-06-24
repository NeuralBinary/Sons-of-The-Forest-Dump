using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	[CallbackIdentity(5702)]
	public struct SteamRemotePlaySessionDisconnected_t
	{
		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		public const int k_iCallback = 5702;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x0")]
		public RemotePlaySessionID_t m_unSessionID;
	}
}
