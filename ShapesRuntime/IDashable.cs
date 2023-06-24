using System;
using Il2CppDummyDll;

namespace Shapes
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	public interface IDashable
	{
		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000B93 RID: 2963
		// (set) Token: 0x06000B94 RID: 2964
		[Token(Token = "0x170001AA")]
		bool MatchDashSpacingToSize { [Token(Token = "0x6000B93")] get; [Token(Token = "0x6000B94")] set; }

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000B95 RID: 2965
		// (set) Token: 0x06000B96 RID: 2966
		[Token(Token = "0x170001AB")]
		bool Dashed { [Token(Token = "0x6000B95")] get; [Token(Token = "0x6000B96")] set; }

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000B97 RID: 2967
		// (set) Token: 0x06000B98 RID: 2968
		[Token(Token = "0x170001AC")]
		float DashSize { [Token(Token = "0x6000B97")] get; [Token(Token = "0x6000B98")] set; }

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000B99 RID: 2969
		// (set) Token: 0x06000B9A RID: 2970
		[Token(Token = "0x170001AD")]
		float DashSpacing { [Token(Token = "0x6000B99")] get; [Token(Token = "0x6000B9A")] set; }

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000B9B RID: 2971
		// (set) Token: 0x06000B9C RID: 2972
		[Token(Token = "0x170001AE")]
		float DashOffset { [Token(Token = "0x6000B9B")] get; [Token(Token = "0x6000B9C")] set; }

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000B9D RID: 2973
		// (set) Token: 0x06000B9E RID: 2974
		[Token(Token = "0x170001AF")]
		DashSpace DashSpace { [Token(Token = "0x6000B9D")] get; [Token(Token = "0x6000B9E")] set; }

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000B9F RID: 2975
		// (set) Token: 0x06000BA0 RID: 2976
		[Token(Token = "0x170001B0")]
		DashSnapping DashSnap { [Token(Token = "0x6000B9F")] get; [Token(Token = "0x6000BA0")] set; }

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000BA1 RID: 2977
		// (set) Token: 0x06000BA2 RID: 2978
		[Token(Token = "0x170001B1")]
		DashType DashType { [Token(Token = "0x6000BA1")] get; [Token(Token = "0x6000BA2")] set; }

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000BA3 RID: 2979
		// (set) Token: 0x06000BA4 RID: 2980
		[Token(Token = "0x170001B2")]
		float DashShapeModifier { [Token(Token = "0x6000BA3")] get; [Token(Token = "0x6000BA4")] set; }
	}
}
