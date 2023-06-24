using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	[CallbackIdentity(5213)]
	public struct RequestPlayersForGameFinalResultCallback_t
	{
		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		public const int k_iCallback = 5213;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ullSearchID;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x10")]
		public ulong m_ullUniqueGameID;
	}
}
