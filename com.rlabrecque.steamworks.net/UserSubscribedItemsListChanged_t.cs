using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	[CallbackIdentity(3418)]
	public struct UserSubscribedItemsListChanged_t
	{
		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		public const int k_iCallback = 3418;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x0")]
		public AppId_t m_nAppID;
	}
}
