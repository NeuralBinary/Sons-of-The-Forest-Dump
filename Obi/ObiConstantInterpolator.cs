using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020001F4 RID: 500
	[Token(Token = "0x20001F4")]
	public class ObiConstantInterpolator : ObiInterpolator<int>
	{
		// Token: 0x06000A1F RID: 2591 RVA: 0x00005414 File Offset: 0x00003614
		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x2813FC0", Offset = "0x28125C0", VA = "0x182813FC0", Slot = "4")]
		public int Evaluate(int y0, int y1, int y2, int y3, float mu)
		{
			return 0;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0000542C File Offset: 0x0000362C
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "5")]
		public int EvaluateFirstDerivative(int y0, int y1, int y2, int y3, float mu)
		{
			return 0;
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00005444 File Offset: 0x00003644
		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "6")]
		public int EvaluateSecondDerivative(int y0, int y1, int y2, int y3, float mu)
		{
			return 0;
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ObiConstantInterpolator()
		{
		}
	}
}
