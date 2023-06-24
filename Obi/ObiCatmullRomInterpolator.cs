using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020001F1 RID: 497
	[Token(Token = "0x20001F1")]
	public class ObiCatmullRomInterpolator : ObiInterpolator<float>
	{
		// Token: 0x06000A13 RID: 2579 RVA: 0x0000533C File Offset: 0x0000353C
		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x28136C0", Offset = "0x2811CC0", VA = "0x1828136C0", Slot = "4")]
		public float Evaluate(float y0, float y1, float y2, float y3, float mu)
		{
			return 0f;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00005354 File Offset: 0x00003554
		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x2813750", Offset = "0x2811D50", VA = "0x182813750", Slot = "5")]
		public float EvaluateFirstDerivative(float y0, float y1, float y2, float y3, float mu)
		{
			return 0f;
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0000536C File Offset: 0x0000356C
		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x2813750", Offset = "0x2811D50", VA = "0x182813750", Slot = "6")]
		public float EvaluateSecondDerivative(float y0, float y1, float y2, float y3, float mu)
		{
			return 0f;
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ObiCatmullRomInterpolator()
		{
		}
	}
}
