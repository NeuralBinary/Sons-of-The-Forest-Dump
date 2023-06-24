using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000C7 RID: 199
	[Token(Token = "0x20000C7")]
	[CallbackIdentity(3402)]
	public struct SteamUGCRequestUGCDetailsResult_t
	{
		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		public const int k_iCallback = 3402;

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x0")]
		public SteamUGCDetails_t m_details;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x88")]
		public bool m_bCachedData;
	}
}
