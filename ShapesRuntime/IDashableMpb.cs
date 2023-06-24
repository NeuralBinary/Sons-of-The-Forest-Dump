using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Shapes
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	internal interface IDashableMpb
	{
		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000AB6 RID: 2742
		[Token(Token = "0x17000167")]
		List<float> dashSize { [Token(Token = "0x6000AB6")] get; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000AB7 RID: 2743
		[Token(Token = "0x17000168")]
		List<float> dashType { [Token(Token = "0x6000AB7")] get; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000AB8 RID: 2744
		[Token(Token = "0x17000169")]
		List<float> dashShapeModifier { [Token(Token = "0x6000AB8")] get; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000AB9 RID: 2745
		[Token(Token = "0x1700016A")]
		List<float> dashSpace { [Token(Token = "0x6000AB9")] get; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000ABA RID: 2746
		[Token(Token = "0x1700016B")]
		List<float> dashSnap { [Token(Token = "0x6000ABA")] get; }

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000ABB RID: 2747
		[Token(Token = "0x1700016C")]
		List<float> dashOffset { [Token(Token = "0x6000ABB")] get; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000ABC RID: 2748
		[Token(Token = "0x1700016D")]
		List<float> dashSpacing { [Token(Token = "0x6000ABC")] get; }
	}
}
