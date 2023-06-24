using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000F7 RID: 247
	[Token(Token = "0x20000F7")]
	[CallbackIdentity(705)]
	public struct CheckFileSignature_t
	{
		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		public const int k_iCallback = 705;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x0")]
		public ECheckFileSignature m_eCheckFileSignature;
	}
}
