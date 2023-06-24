using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000DB RID: 219
	[Token(Token = "0x20000DB")]
	[CallbackIdentity(103)]
	public struct SteamServersDisconnected_t
	{
		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		public const int k_iCallback = 103;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
}
