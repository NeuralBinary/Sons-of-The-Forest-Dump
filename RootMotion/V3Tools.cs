using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	public static class V3Tools
	{
		// Token: 0x060000FE RID: 254 RVA: 0x00002B04 File Offset: 0x00000D04
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x28F5190", Offset = "0x28F3790", VA = "0x1828F5190")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002B1C File Offset: 0x00000D1C
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x28F5260", Offset = "0x28F3860", VA = "0x1828F5260")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002B34 File Offset: 0x00000D34
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x28F5350", Offset = "0x28F3950", VA = "0x1828F5350")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002B4C File Offset: 0x00000D4C
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x28F5530", Offset = "0x28F3B30", VA = "0x1828F5530")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002B64 File Offset: 0x00000D64
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x28F5680", Offset = "0x28F3C80", VA = "0x1828F5680")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002B7C File Offset: 0x00000D7C
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x28F58B0", Offset = "0x28F3EB0", VA = "0x1828F58B0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002B94 File Offset: 0x00000D94
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x28F5AF0", Offset = "0x28F40F0", VA = "0x1828F5AF0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002BAC File Offset: 0x00000DAC
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x28F5D70", Offset = "0x28F4370", VA = "0x1828F5D70")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002BC4 File Offset: 0x00000DC4
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x28F5F10", Offset = "0x28F4510", VA = "0x1828F5F10")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002BDC File Offset: 0x00000DDC
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x28F6170", Offset = "0x28F4770", VA = "0x1828F6170")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002BF4 File Offset: 0x00000DF4
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x28F62D0", Offset = "0x28F48D0", VA = "0x1828F62D0")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}
	}
}
