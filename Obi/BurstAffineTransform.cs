using System;
using Il2CppDummyDll;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x20000B7")]
	public struct BurstAffineTransform
	{
		// Token: 0x060003A2 RID: 930 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x27991D0", Offset = "0x27977D0", VA = "0x1827991D0")]
		public BurstAffineTransform(float4 translation, quaternion rotation, float4 scale)
		{
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00003584 File Offset: 0x00001784
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x2799200", Offset = "0x2797800", VA = "0x182799200")]
		public static BurstAffineTransform operator *(BurstAffineTransform a, BurstAffineTransform b)
		{
			return default(BurstAffineTransform);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000359C File Offset: 0x0000179C
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x27993C0", Offset = "0x27979C0", VA = "0x1827993C0")]
		public BurstAffineTransform Inverse()
		{
			return default(BurstAffineTransform);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x000035B4 File Offset: 0x000017B4
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x27995F0", Offset = "0x2797BF0", VA = "0x1827995F0")]
		public BurstAffineTransform Interpolate(BurstAffineTransform other, float translationalMu, float rotationalMu, float scaleMu)
		{
			return default(BurstAffineTransform);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000035CC File Offset: 0x000017CC
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x2799800", Offset = "0x2797E00", VA = "0x182799800")]
		public float4 TransformPoint(float4 point)
		{
			return default(float4);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000035E4 File Offset: 0x000017E4
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x27998C0", Offset = "0x2797EC0", VA = "0x1827998C0")]
		public float4 InverseTransformPoint(float4 point)
		{
			return default(float4);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000035FC File Offset: 0x000017FC
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x2799A00", Offset = "0x2798000", VA = "0x182799A00")]
		public float4 TransformPointUnscaled(float4 point)
		{
			return default(float4);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00003614 File Offset: 0x00001814
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x2799AA0", Offset = "0x27980A0", VA = "0x182799AA0")]
		public float4 InverseTransformPointUnscaled(float4 point)
		{
			return default(float4);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000362C File Offset: 0x0000182C
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x2799BC0", Offset = "0x27981C0", VA = "0x182799BC0")]
		public float4 TransformDirection(float4 direction)
		{
			return default(float4);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00003644 File Offset: 0x00001844
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x2799C50", Offset = "0x2798250", VA = "0x182799C50")]
		public float4 InverseTransformDirection(float4 direction)
		{
			return default(float4);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000365C File Offset: 0x0000185C
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x2799D30", Offset = "0x2798330", VA = "0x182799D30")]
		public float4 TransformVector(float4 vector)
		{
			return default(float4);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00003674 File Offset: 0x00001874
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x2799DE0", Offset = "0x27983E0", VA = "0x182799DE0")]
		public float4 InverseTransformVector(float4 vector)
		{
			return default(float4);
		}

		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000411")]
		[FieldOffset(Offset = "0x0")]
		public float4 translation;

		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x10")]
		public float4 scale;

		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x20")]
		public quaternion rotation;
	}
}
