using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	[CallbackIdentity(1005)]
	public struct DlcInstalled_t
	{
		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		public const int k_iCallback = 1005;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;
	}
}
