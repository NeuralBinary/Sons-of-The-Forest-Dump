using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000E5 RID: 229
	[Token(Token = "0x20000E5")]
	[CallbackIdentity(166)]
	public struct MarketEligibilityResponse_t
	{
		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		public const int k_iCallback = 166;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x0")]
		public bool m_bAllowed;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x4")]
		public EMarketNotAllowedReasonFlags m_eNotAllowedReason;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x8")]
		public RTime32 m_rtAllowedAtTime;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0xC")]
		public int m_cdaySteamGuardRequiredDays;

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x10")]
		public int m_cdayNewDeviceCooldown;
	}
}
