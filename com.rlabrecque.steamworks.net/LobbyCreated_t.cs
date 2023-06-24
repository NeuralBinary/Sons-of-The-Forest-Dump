using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	[CallbackIdentity(513)]
	public struct LobbyCreated_t
	{
		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		public const int k_iCallback = 513;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDLobby;
	}
}
