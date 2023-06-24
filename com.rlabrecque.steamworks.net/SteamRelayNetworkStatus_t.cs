using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000A7 RID: 167
	[Token(Token = "0x20000A7")]
	[CallbackIdentity(1281)]
	public struct SteamRelayNetworkStatus_t
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000B")]
		public string m_debugMsg
		{
			[Token(Token = "0x6000855")]
			[Address(RVA = "0x97DBB0", Offset = "0x97C1B0", VA = "0x18097DBB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000856")]
			[Address(RVA = "0x97DED0", Offset = "0x97C4D0", VA = "0x18097DED0")]
			set
			{
			}
		}

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		public const int k_iCallback = 1281;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x0")]
		public ESteamNetworkingAvailability m_eAvail;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x4")]
		public int m_bPingMeasurementInProgress;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x8")]
		public ESteamNetworkingAvailability m_eAvailNetworkConfig;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0xC")]
		public ESteamNetworkingAvailability m_eAvailAnyRelay;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x10")]
		private byte[] m_debugMsg_;
	}
}
