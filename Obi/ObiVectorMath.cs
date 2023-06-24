using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001D1 RID: 465
	[Token(Token = "0x20001D1")]
	public static class ObiVectorMath
	{
		// Token: 0x06000933 RID: 2355 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000933")]
		[Address(RVA = "0x2805A50", Offset = "0x2804050", VA = "0x182805A50")]
		public static void Cross(Vector3 a, Vector3 b, ref float x, ref float y, ref float z)
		{
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000934")]
		[Address(RVA = "0x2805AB0", Offset = "0x28040B0", VA = "0x182805AB0")]
		public static void Cross(Vector3 a, Vector3 b, ref Vector3 res)
		{
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000935")]
		[Address(RVA = "0x2805B10", Offset = "0x2804110", VA = "0x182805B10")]
		public static void Cross(float ax, float ay, float az, float bx, float by, float bz, ref float x, ref float y, ref float z)
		{
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000936")]
		[Address(RVA = "0x2805B80", Offset = "0x2804180", VA = "0x182805B80")]
		public static void Subtract(Vector3 a, Vector3 b, ref Vector3 res)
		{
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000937")]
		[Address(RVA = "0x2805BB0", Offset = "0x28041B0", VA = "0x182805BB0")]
		public static void BarycentricInterpolation(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 n1, Vector3 n2, Vector3 n3, Vector3 coords, float height, ref Vector3 res)
		{
		}
	}
}
