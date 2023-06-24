using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001DB RID: 475
	[Token(Token = "0x20001DB")]
	public static class Integrate1d
	{
		// Token: 0x06000E92 RID: 3730 RVA: 0x0000AAFC File Offset: 0x00008CFC
		[Token(Token = "0x6000E92")]
		[Address(RVA = "0x1E2EBC0", Offset = "0x1E2D1C0", VA = "0x181E2EBC0")]
		public static double RombergIntegral(int order, double a, double b, Func<double, object, double> function, object userData)
		{
			return 0.0;
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0000AB14 File Offset: 0x00008D14
		[Token(Token = "0x6000E93")]
		[Address(RVA = "0x1E2EF10", Offset = "0x1E2D510", VA = "0x181E2EF10")]
		public static double GaussianQuadrature(double a, double b, Func<double, object, double> function, object userData)
		{
			return 0.0;
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0000AB2C File Offset: 0x00008D2C
		[Token(Token = "0x6000E94")]
		[Address(RVA = "0x1E2F050", Offset = "0x1E2D650", VA = "0x181E2F050")]
		public static double TrapezoidRule(int numSamples, double a, double b, Func<double, object, double> function, object userData)
		{
			return 0.0;
		}

		// Token: 0x040007AB RID: 1963
		[Token(Token = "0x40007AB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly double[] root;

		// Token: 0x040007AC RID: 1964
		[Token(Token = "0x40007AC")]
		[FieldOffset(Offset = "0x8")]
		private static readonly double[] coeff;
	}
}
