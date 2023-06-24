using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000CF RID: 207
	[Token(Token = "0x20000CF")]
	[CallbackIdentity(3410)]
	public struct StartPlaytimeTrackingResult_t
	{
		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		public const int k_iCallback = 3410;

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
}
