using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200009B RID: 155
	[Token(Token = "0x200009B")]
	[CallbackIdentity(4110)]
	public struct MusicPlayerWantsLooped_t
	{
		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		public const int k_iCallback = 4110;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x0")]
		public bool m_bLooped;
	}
}
