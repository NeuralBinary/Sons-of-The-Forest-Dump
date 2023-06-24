using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	[CallbackIdentity(4109)]
	public struct MusicPlayerWantsShuffled_t
	{
		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		public const int k_iCallback = 4109;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x0")]
		public bool m_bShuffled;
	}
}
