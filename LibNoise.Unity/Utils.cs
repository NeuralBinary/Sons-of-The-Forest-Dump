using System;
using Il2CppDummyDll;

namespace LibNoise
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	internal static class Utils
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x207DC60", Offset = "0x207C260", VA = "0x18207DC60")]
		internal static double GradientCoherentNoise3D(double x, double y, double z, long seed, QualityMode quality)
		{
			return 0.0;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x207E1B0", Offset = "0x207C7B0", VA = "0x18207E1B0")]
		internal static double GradientNoise3D(double fx, double fy, double fz, int ix, int iy, int iz, long seed)
		{
			return 0.0;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x207E320", Offset = "0x207C920", VA = "0x18207E320")]
		internal static double InterpolateCubic(double a, double b, double c, double d, double position)
		{
			return 0.0;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1E33430", Offset = "0x1E31A30", VA = "0x181E33430")]
		internal static double InterpolateLinear(double a, double b, double position)
		{
			return 0.0;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x207E370", Offset = "0x207C970", VA = "0x18207E370")]
		internal static double MakeInt32Range(double value)
		{
			return 0.0;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x207E440", Offset = "0x207CA40", VA = "0x18207E440")]
		internal static double MapCubicSCurve(double value)
		{
			return 0.0;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x207E460", Offset = "0x207CA60", VA = "0x18207E460")]
		internal static double MapQuinticSCurve(double value)
		{
			return 0.0;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x207E4A0", Offset = "0x207CAA0", VA = "0x18207E4A0")]
		internal static double ValueNoise3D(int x, int y, int z, int seed)
		{
			return 0.0;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x207E570", Offset = "0x207CB70", VA = "0x18207E570")]
		internal static long ValueNoise3DInt(int x, int y, int z, int seed)
		{
			return 0L;
		}

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		internal const double Sqrt3 = 1.7320508075688772;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		internal const int OctavesMaximum = 30;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		private const int GeneratorNoiseX = 1619;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		private const int GeneratorNoiseY = 31337;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		private const int GeneratorNoiseZ = 6971;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		private const int GeneratorSeed = 1013;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		private const int GeneratorShift = 8;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly double[] Randoms;
	}
}
