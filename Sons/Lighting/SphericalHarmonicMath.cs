using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sons.Lighting
{
	// Token: 0x02000586 RID: 1414
	[Token(Token = "0x2000586")]
	public class SphericalHarmonicMath
	{
		// Token: 0x0600253E RID: 9534 RVA: 0x0000AD70 File Offset: 0x00008F70
		[Token(Token = "0x600253E")]
		[Address(RVA = "0x339A620", Offset = "0x3398C20", VA = "0x18339A620")]
		public static SphericalHarmonicsL2 UndoCosineRescaling(SphericalHarmonicsL2 sh)
		{
			return default(SphericalHarmonicsL2);
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x0000AD88 File Offset: 0x00008F88
		[Token(Token = "0x600253F")]
		[Address(RVA = "0x339A770", Offset = "0x3398D70", VA = "0x18339A770")]
		public static SphericalHarmonicsL2 PremultiplyCoefficients(SphericalHarmonicsL2 sh)
		{
			return default(SphericalHarmonicsL2);
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		[Token(Token = "0x6002540")]
		[Address(RVA = "0x339A8C0", Offset = "0x3398EC0", VA = "0x18339A8C0")]
		public static SphericalHarmonicsL2 RescaleCoefficients(SphericalHarmonicsL2 sh, float scalar)
		{
			return default(SphericalHarmonicsL2);
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002541")]
		[Address(RVA = "0x339A9A0", Offset = "0x3398FA0", VA = "0x18339A9A0")]
		public static void PackCoefficients(Vector4[] packedCoeffs, SphericalHarmonicsL2 sh)
		{
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002542")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SphericalHarmonicMath()
		{
		}

		// Token: 0x04002176 RID: 8566
		[Token(Token = "0x4002176")]
		private const float c0 = 0.2820948f;

		// Token: 0x04002177 RID: 8567
		[Token(Token = "0x4002177")]
		private const float c1 = 0.325735f;

		// Token: 0x04002178 RID: 8568
		[Token(Token = "0x4002178")]
		private const float c2 = 0.27313712f;

		// Token: 0x04002179 RID: 8569
		[Token(Token = "0x4002179")]
		private const float c3 = 0.07884789f;

		// Token: 0x0400217A RID: 8570
		[Token(Token = "0x400217A")]
		private const float c4 = 0.13656856f;

		// Token: 0x0400217B RID: 8571
		[Token(Token = "0x400217B")]
		[FieldOffset(Offset = "0x0")]
		private static float[] invNormConsts;

		// Token: 0x0400217C RID: 8572
		[Token(Token = "0x400217C")]
		private const float k0 = 0.2820948f;

		// Token: 0x0400217D RID: 8573
		[Token(Token = "0x400217D")]
		private const float k1 = 0.48860252f;

		// Token: 0x0400217E RID: 8574
		[Token(Token = "0x400217E")]
		private const float k2 = 1.0925485f;

		// Token: 0x0400217F RID: 8575
		[Token(Token = "0x400217F")]
		private const float k3 = 0.31539157f;

		// Token: 0x04002180 RID: 8576
		[Token(Token = "0x4002180")]
		private const float k4 = 0.54627424f;

		// Token: 0x04002181 RID: 8577
		[Token(Token = "0x4002181")]
		[FieldOffset(Offset = "0x8")]
		private static float[] ks;
	}
}
