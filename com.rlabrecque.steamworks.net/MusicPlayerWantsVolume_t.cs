using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200009C RID: 156
	[Token(Token = "0x200009C")]
	[CallbackIdentity(4011)]
	public struct MusicPlayerWantsVolume_t
	{
		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		public const int k_iCallback = 4011;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x0")]
		public float m_flNewVolume;
	}
}
