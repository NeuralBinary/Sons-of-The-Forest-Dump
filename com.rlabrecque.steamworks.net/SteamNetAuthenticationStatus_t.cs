using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	[CallbackIdentity(1222)]
	public struct SteamNetAuthenticationStatus_t
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000A")]
		public string m_debugMsg
		{
			[Token(Token = "0x6000853")]
			[Address(RVA = "0x97DCF0", Offset = "0x97C2F0", VA = "0x18097DCF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000854")]
			[Address(RVA = "0x97DD90", Offset = "0x97C390", VA = "0x18097DD90")]
			set
			{
			}
		}

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		public const int k_iCallback = 1222;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x0")]
		public ESteamNetworkingAvailability m_eAvail;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x8")]
		private byte[] m_debugMsg_;
	}
}
