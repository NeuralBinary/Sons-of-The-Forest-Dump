using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	[CallbackIdentity(5215)]
	public struct EndGameResultCallback_t
	{
		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		public const int k_iCallback = 5215;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x8")]
		public ulong ullUniqueGameID;
	}
}
