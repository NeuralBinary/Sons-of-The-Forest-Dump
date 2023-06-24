using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000D0 RID: 208
	[Token(Token = "0x20000D0")]
	[CallbackIdentity(3411)]
	public struct StopPlaytimeTrackingResult_t
	{
		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		public const int k_iCallback = 3411;

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
}
