using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	public enum InputModes
	{
		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		AlwaysTwoSteps,
		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		HoldForOneStep = 2,
		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		TapForOneStep,
		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		TapSecondaryForOneStep,
		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		TapSecondaryForTwoStep,
		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		TapMainOrAltTwoSteps,
		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		TapMainOrAltOneStep
	}
}
