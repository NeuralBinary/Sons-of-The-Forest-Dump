using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000176 RID: 374
	[Token(Token = "0x2000176")]
	public struct SteamNetConnectionRealTimeLaneStatus_t
	{
		// Token: 0x040009E1 RID: 2529
		[Token(Token = "0x40009E1")]
		[FieldOffset(Offset = "0x0")]
		public int m_cbPendingUnreliable;

		// Token: 0x040009E2 RID: 2530
		[Token(Token = "0x40009E2")]
		[FieldOffset(Offset = "0x4")]
		public int m_cbPendingReliable;

		// Token: 0x040009E3 RID: 2531
		[Token(Token = "0x40009E3")]
		[FieldOffset(Offset = "0x8")]
		public int m_cbSentUnackedReliable;

		// Token: 0x040009E4 RID: 2532
		[Token(Token = "0x40009E4")]
		[FieldOffset(Offset = "0xC")]
		public int _reservePad1;

		// Token: 0x040009E5 RID: 2533
		[Token(Token = "0x40009E5")]
		[FieldOffset(Offset = "0x10")]
		public SteamNetworkingMicroseconds m_usecQueueTime;

		// Token: 0x040009E6 RID: 2534
		[Token(Token = "0x40009E6")]
		[FieldOffset(Offset = "0x18")]
		public uint[] reserved;
	}
}
