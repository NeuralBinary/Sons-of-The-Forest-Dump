using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace Shapes
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	public enum ShapesBlendMode
	{
		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[Description("Opaque")]
		Opaque,
		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[Description("Transparent_")]
		Transparent,
		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[Description("Linear Dodge (Additive)")]
		Additive,
		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[Description("Color Dodge")]
		ColorDodge = 9,
		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[Description("Screen")]
		Screen = 4,
		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[Description("Lighten_")]
		Lighten = 7,
		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[Description("Linear Burn")]
		LinearBurn = 6,
		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[Description("Color Burn")]
		ColorBurn = 10,
		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[Description("Multiply")]
		Multiplicative = 3,
		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[Description("Darken_")]
		Darken = 8,
		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		[Description("Subtract")]
		Subtractive = 5
	}
}
