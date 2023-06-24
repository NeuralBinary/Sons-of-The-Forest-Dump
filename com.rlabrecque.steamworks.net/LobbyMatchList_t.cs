using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	[CallbackIdentity(510)]
	public struct LobbyMatchList_t
	{
		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		public const int k_iCallback = 510;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x0")]
		public uint m_nLobbiesMatching;
	}
}
