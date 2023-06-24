using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	[CallbackIdentity(163)]
	public struct GetAuthSessionTicketResponse_t
	{
		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		public const int k_iCallback = 163;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x0")]
		public HAuthTicket m_hAuthTicket;

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x4")]
		public EResult m_eResult;
	}
}
