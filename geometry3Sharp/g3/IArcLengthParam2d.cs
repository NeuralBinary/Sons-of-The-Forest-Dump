using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000DE RID: 222
	[Token(Token = "0x20000DE")]
	public interface IArcLengthParam2d
	{
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600051D RID: 1309
		[Token(Token = "0x170000BF")]
		double ArcLength { [Token(Token = "0x600051D")] get; }

		// Token: 0x0600051E RID: 1310
		[Token(Token = "0x600051E")]
		CurveSample2d Sample(double fArcLen);
	}
}
