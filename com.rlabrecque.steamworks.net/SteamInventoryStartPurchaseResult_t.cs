using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	[CallbackIdentity(4704)]
	public struct SteamInventoryStartPurchaseResult_t
	{
		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		public const int k_iCallback = 4704;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_result;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulOrderID;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x10")]
		public ulong m_ulTransID;
	}
}
