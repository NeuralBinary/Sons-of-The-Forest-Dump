using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000088 RID: 136
	[Token(Token = "0x2000088")]
	[CallbackIdentity(5214)]
	public struct SubmitPlayerResultResultCallback_t
	{
		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		public const int k_iCallback = 5214;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x8")]
		public ulong ullUniqueGameID;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x10")]
		public CSteamID steamIDPlayer;
	}
}
