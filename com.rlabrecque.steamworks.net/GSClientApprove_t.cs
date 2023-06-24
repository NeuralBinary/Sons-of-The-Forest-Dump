using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	[CallbackIdentity(201)]
	public struct GSClientApprove_t
	{
		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		public const int k_iCallback = 201;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x8")]
		public CSteamID m_OwnerSteamID;
	}
}
