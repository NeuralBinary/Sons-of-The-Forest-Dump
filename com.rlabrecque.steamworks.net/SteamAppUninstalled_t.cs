using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	[CallbackIdentity(3902)]
	public struct SteamAppUninstalled_t
	{
		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		public const int k_iCallback = 3902;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x4")]
		public int m_iInstallFolderIndex;
	}
}
