using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	[CallbackIdentity(5211)]
	public struct RequestPlayersForGameProgressCallback_t
	{
		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		public const int k_iCallback = 5211;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ullSearchID;
	}
}
