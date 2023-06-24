using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200009F RID: 159
	[Token(Token = "0x200009F")]
	[CallbackIdentity(4114)]
	public struct MusicPlayerWantsPlayingRepeatStatus_t
	{
		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		public const int k_iCallback = 4114;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x0")]
		public int m_nPlayingRepeatStatus;
	}
}
