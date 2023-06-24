using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	[CallbackIdentity(4002)]
	public struct VolumeHasChanged_t
	{
		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		public const int k_iCallback = 4002;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x0")]
		public float m_flNewVolume;
	}
}
