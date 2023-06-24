using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000DF RID: 223
	[Token(Token = "0x20000DF")]
	[CallbackIdentity(143)]
	public struct ValidateAuthTicketResponse_t
	{
		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		public const int k_iCallback = 143;

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x8")]
		public EAuthSessionResponse m_eAuthSessionResponse;

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0xC")]
		public CSteamID m_OwnerSteamID;
	}
}
