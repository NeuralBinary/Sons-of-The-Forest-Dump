using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	public struct SteamNetConnectionRealTimeStatus_t
	{
		// Token: 0x040009D3 RID: 2515
		[Token(Token = "0x40009D3")]
		[FieldOffset(Offset = "0x0")]
		public ESteamNetworkingConnectionState m_eState;

		// Token: 0x040009D4 RID: 2516
		[Token(Token = "0x40009D4")]
		[FieldOffset(Offset = "0x4")]
		public int m_nPing;

		// Token: 0x040009D5 RID: 2517
		[Token(Token = "0x40009D5")]
		[FieldOffset(Offset = "0x8")]
		public float m_flConnectionQualityLocal;

		// Token: 0x040009D6 RID: 2518
		[Token(Token = "0x40009D6")]
		[FieldOffset(Offset = "0xC")]
		public float m_flConnectionQualityRemote;

		// Token: 0x040009D7 RID: 2519
		[Token(Token = "0x40009D7")]
		[FieldOffset(Offset = "0x10")]
		public float m_flOutPacketsPerSec;

		// Token: 0x040009D8 RID: 2520
		[Token(Token = "0x40009D8")]
		[FieldOffset(Offset = "0x14")]
		public float m_flOutBytesPerSec;

		// Token: 0x040009D9 RID: 2521
		[Token(Token = "0x40009D9")]
		[FieldOffset(Offset = "0x18")]
		public float m_flInPacketsPerSec;

		// Token: 0x040009DA RID: 2522
		[Token(Token = "0x40009DA")]
		[FieldOffset(Offset = "0x1C")]
		public float m_flInBytesPerSec;

		// Token: 0x040009DB RID: 2523
		[Token(Token = "0x40009DB")]
		[FieldOffset(Offset = "0x20")]
		public int m_nSendRateBytesPerSecond;

		// Token: 0x040009DC RID: 2524
		[Token(Token = "0x40009DC")]
		[FieldOffset(Offset = "0x24")]
		public int m_cbPendingUnreliable;

		// Token: 0x040009DD RID: 2525
		[Token(Token = "0x40009DD")]
		[FieldOffset(Offset = "0x28")]
		public int m_cbPendingReliable;

		// Token: 0x040009DE RID: 2526
		[Token(Token = "0x40009DE")]
		[FieldOffset(Offset = "0x2C")]
		public int m_cbSentUnackedReliable;

		// Token: 0x040009DF RID: 2527
		[Token(Token = "0x40009DF")]
		[FieldOffset(Offset = "0x30")]
		public SteamNetworkingMicroseconds m_usecQueueTime;

		// Token: 0x040009E0 RID: 2528
		[Token(Token = "0x40009E0")]
		[FieldOffset(Offset = "0x38")]
		public uint[] reserved;
	}
}
