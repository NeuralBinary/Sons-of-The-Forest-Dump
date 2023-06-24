using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000FC RID: 252
	[Token(Token = "0x20000FC")]
	[CallbackIdentity(4624)]
	public struct GetOPFSettingsResult_t
	{
		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000306")]
		public const int k_iCallback = 4624;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x4")]
		public AppId_t m_unVideoAppID;
	}
}
