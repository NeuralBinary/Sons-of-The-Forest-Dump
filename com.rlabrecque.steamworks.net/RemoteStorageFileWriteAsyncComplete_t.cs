using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	[CallbackIdentity(1331)]
	public struct RemoteStorageFileWriteAsyncComplete_t
	{
		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		public const int k_iCallback = 1331;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
}
