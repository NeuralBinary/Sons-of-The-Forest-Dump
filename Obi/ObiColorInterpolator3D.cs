using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001F3 RID: 499
	[Token(Token = "0x20001F3")]
	public class ObiColorInterpolator3D : ObiInterpolator<Color>
	{
		// Token: 0x06000A1B RID: 2587 RVA: 0x000053CC File Offset: 0x000035CC
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x2813B70", Offset = "0x2812170", VA = "0x182813B70", Slot = "4")]
		public Color Evaluate(Color y0, Color y1, Color y2, Color y3, float mu)
		{
			return default(Color);
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x000053E4 File Offset: 0x000035E4
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x2813D10", Offset = "0x2812310", VA = "0x182813D10", Slot = "5")]
		public Color EvaluateFirstDerivative(Color y0, Color y1, Color y2, Color y3, float mu)
		{
			return default(Color);
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x000053FC File Offset: 0x000035FC
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x2813D10", Offset = "0x2812310", VA = "0x182813D10", Slot = "6")]
		public Color EvaluateSecondDerivative(Color y0, Color y1, Color y2, Color y3, float mu)
		{
			return default(Color);
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x2813F30", Offset = "0x2812530", VA = "0x182813F30")]
		public ObiColorInterpolator3D()
		{
		}

		// Token: 0x04000814 RID: 2068
		[Token(Token = "0x4000814")]
		[FieldOffset(Offset = "0x10")]
		private ObiCatmullRomInterpolator interpolator;
	}
}
