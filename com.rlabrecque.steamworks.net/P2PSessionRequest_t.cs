using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000A0 RID: 160
	[Token(Token = "0x20000A0")]
	[CallbackIdentity(1202)]
	public struct P2PSessionRequest_t
	{
		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		public const int k_iCallback = 1202;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDRemote;
	}
}
