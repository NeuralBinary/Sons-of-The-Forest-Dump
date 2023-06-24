using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	public struct DSP_STATE_DFT_FUNCTIONS
	{
		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x0")]
		public DSP_DFT_FFTREAL_FUNC fftreal;

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x8")]
		public DSP_DFT_IFFTREAL_FUNC inversefftreal;
	}
}
