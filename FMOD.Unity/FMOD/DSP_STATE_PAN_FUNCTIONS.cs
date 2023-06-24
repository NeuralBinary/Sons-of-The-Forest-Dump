using System;
using Il2CppDummyDll;

namespace FMOD
{
	// Token: 0x02000093 RID: 147
	[Token(Token = "0x2000093")]
	public struct DSP_STATE_PAN_FUNCTIONS
	{
		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x0")]
		public DSP_PAN_SUMMONOMATRIX_FUNC summonomatrix;

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x8")]
		public DSP_PAN_SUMSTEREOMATRIX_FUNC sumstereomatrix;

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x10")]
		public DSP_PAN_SUMSURROUNDMATRIX_FUNC sumsurroundmatrix;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x18")]
		public DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC summonotosurroundmatrix;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x20")]
		public DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC sumstereotosurroundmatrix;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x28")]
		public DSP_PAN_GETROLLOFFGAIN_FUNC getrolloffgain;
	}
}
