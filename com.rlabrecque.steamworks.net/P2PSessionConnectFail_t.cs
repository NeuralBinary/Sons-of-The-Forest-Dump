using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000A1 RID: 161
	[Token(Token = "0x20000A1")]
	[CallbackIdentity(1203)]
	public struct P2PSessionConnectFail_t
	{
		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		public const int k_iCallback = 1203;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDRemote;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x8")]
		public byte m_eP2PSessionError;
	}
}
