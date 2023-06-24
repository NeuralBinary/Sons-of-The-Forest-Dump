using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000E6 RID: 230
	[Token(Token = "0x20000E6")]
	[CallbackIdentity(167)]
	public struct DurationControl_t
	{
		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		public const int k_iCallback = 167;

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x4")]
		public AppId_t m_appid;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x8")]
		public bool m_bApplicable;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0xC")]
		public int m_csecsLast5h;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x10")]
		public EDurationControlProgress m_progress;

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x14")]
		public EDurationControlNotification m_notification;

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x18")]
		public int m_csecsToday;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x1C")]
		public int m_csecsRemaining;
	}
}
