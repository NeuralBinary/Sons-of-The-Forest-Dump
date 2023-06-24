using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001F2 RID: 498
	[Token(Token = "0x20001F2")]
	public class ObiCatmullRomInterpolator3D : ObiInterpolator<Vector3>
	{
		// Token: 0x06000A17 RID: 2583 RVA: 0x00005384 File Offset: 0x00003584
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x28137E0", Offset = "0x2811DE0", VA = "0x1828137E0", Slot = "4")]
		public Vector3 Evaluate(Vector3 y0, Vector3 y1, Vector3 y2, Vector3 y3, float mu)
		{
			return default(Vector3);
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0000539C File Offset: 0x0000359C
		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x2813930", Offset = "0x2811F30", VA = "0x182813930", Slot = "5")]
		public Vector3 EvaluateFirstDerivative(Vector3 y0, Vector3 y1, Vector3 y2, Vector3 y3, float mu)
		{
			return default(Vector3);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x000053B4 File Offset: 0x000035B4
		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x2813930", Offset = "0x2811F30", VA = "0x182813930", Slot = "6")]
		public Vector3 EvaluateSecondDerivative(Vector3 y0, Vector3 y1, Vector3 y2, Vector3 y3, float mu)
		{
			return default(Vector3);
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x2813AE0", Offset = "0x28120E0", VA = "0x182813AE0")]
		public ObiCatmullRomInterpolator3D()
		{
		}

		// Token: 0x04000813 RID: 2067
		[Token(Token = "0x4000813")]
		[FieldOffset(Offset = "0x10")]
		private ObiCatmullRomInterpolator interpolator;
	}
}
