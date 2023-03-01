using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Sons.Lighting
{
	// Token: 0x02000576 RID: 1398
	[Token(Token = "0x2000576")]
	public class SphericalHarmonicMath
	{
		// Token: 0x0600243F RID: 9279 RVA: 0x0000A6B0 File Offset: 0x000088B0
		[Token(Token = "0x600243F")]
		[Address(RVA = "0x2D90A60", Offset = "0x2D8FA60", VA = "0x182D90A60")]
		public static SphericalHarmonicsL2 UndoCosineRescaling(SphericalHarmonicsL2 sh)
		{
			return default(SphericalHarmonicsL2);
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x0000A6C8 File Offset: 0x000088C8
		[Token(Token = "0x6002440")]
		[Address(RVA = "0x2D90830", Offset = "0x2D8F830", VA = "0x182D90830")]
		public static SphericalHarmonicsL2 PremultiplyCoefficients(SphericalHarmonicsL2 sh)
		{
			return default(SphericalHarmonicsL2);
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x0000A6E0 File Offset: 0x000088E0
		[Token(Token = "0x6002441")]
		[Address(RVA = "0x2D90980", Offset = "0x2D8F980", VA = "0x182D90980")]
		public static SphericalHarmonicsL2 RescaleCoefficients(SphericalHarmonicsL2 sh, float scalar)
		{
			return default(SphericalHarmonicsL2);
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002442")]
		[Address(RVA = "0x2D90620", Offset = "0x2D8F620", VA = "0x182D90620")]
		public static void PackCoefficients(Vector4[] packedCoeffs, SphericalHarmonicsL2 sh)
		{
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002443")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public SphericalHarmonicMath()
		{
		}

		// Token: 0x040020A2 RID: 8354
		[Token(Token = "0x40020A2")]
		private const float c0 = 0.2820948f;

		// Token: 0x040020A3 RID: 8355
		[Token(Token = "0x40020A3")]
		private const float c1 = 0.325735f;

		// Token: 0x040020A4 RID: 8356
		[Token(Token = "0x40020A4")]
		private const float c2 = 0.27313712f;

		// Token: 0x040020A5 RID: 8357
		[Token(Token = "0x40020A5")]
		private const float c3 = 0.07884789f;

		// Token: 0x040020A6 RID: 8358
		[Token(Token = "0x40020A6")]
		private const float c4 = 0.13656856f;

		// Token: 0x040020A7 RID: 8359
		[Token(Token = "0x40020A7")]
		[FieldOffset(Offset = "0x0")]
		private static float[] invNormConsts;

		// Token: 0x040020A8 RID: 8360
		[Token(Token = "0x40020A8")]
		private const float k0 = 0.2820948f;

		// Token: 0x040020A9 RID: 8361
		[Token(Token = "0x40020A9")]
		private const float k1 = 0.48860252f;

		// Token: 0x040020AA RID: 8362
		[Token(Token = "0x40020AA")]
		private const float k2 = 1.0925485f;

		// Token: 0x040020AB RID: 8363
		[Token(Token = "0x40020AB")]
		private const float k3 = 0.31539157f;

		// Token: 0x040020AC RID: 8364
		[Token(Token = "0x40020AC")]
		private const float k4 = 0.54627424f;

		// Token: 0x040020AD RID: 8365
		[Token(Token = "0x40020AD")]
		[FieldOffset(Offset = "0x8")]
		private static float[] ks;
	}
}
