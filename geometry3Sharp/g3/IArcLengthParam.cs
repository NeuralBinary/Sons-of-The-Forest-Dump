using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000DB RID: 219
	[Token(Token = "0x20000DB")]
	public interface IArcLengthParam
	{
		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000516 RID: 1302
		[Token(Token = "0x170000BD")]
		double ArcLength { [Token(Token = "0x6000516")] get; }

		// Token: 0x06000517 RID: 1303
		[Token(Token = "0x6000517")]
		CurveSample Sample(double fArcLen);
	}
}
