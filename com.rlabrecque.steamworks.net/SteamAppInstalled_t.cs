using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	[CallbackIdentity(3901)]
	public struct SteamAppInstalled_t
	{
		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		public const int k_iCallback = 3901;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x4")]
		public int m_iInstallFolderIndex;
	}
}
