using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.TerrainDetail
{
	// Token: 0x02000507 RID: 1287
	[Token(Token = "0x2000507")]
	public class SphereCalculator
	{
		// Token: 0x0600218A RID: 8586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600218A")]
		[Address(RVA = "0x332A160", Offset = "0x3328760", VA = "0x18332A160")]
		public static SphereCalculator.Sphere CalculateMinimumSphere(List<Vector3> points)
		{
			return null;
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600218B")]
		[Address(RVA = "0x332A460", Offset = "0x3328A60", VA = "0x18332A460")]
		private static SphereCalculator.Sphere Welzl(List<SphereCalculator.Point> points, List<SphereCalculator.Point> boundary, SphereCalculator.Sphere sphere)
		{
			return null;
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600218C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SphereCalculator()
		{
		}

		// Token: 0x02000508 RID: 1288
		[Token(Token = "0x2000508")]
		public struct Point
		{
			// Token: 0x0600218D RID: 8589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600218D")]
			[Address(RVA = "0x5B2550", Offset = "0x5B0B50", VA = "0x1805B2550")]
			public Point(float x, float y, float z)
			{
			}

			// Token: 0x04001F11 RID: 7953
			[Token(Token = "0x4001F11")]
			[FieldOffset(Offset = "0x0")]
			public float x;

			// Token: 0x04001F12 RID: 7954
			[Token(Token = "0x4001F12")]
			[FieldOffset(Offset = "0x4")]
			public float y;

			// Token: 0x04001F13 RID: 7955
			[Token(Token = "0x4001F13")]
			[FieldOffset(Offset = "0x8")]
			public float z;
		}

		// Token: 0x02000509 RID: 1289
		[Token(Token = "0x2000509")]
		[Serializable]
		public class Sphere
		{
			// Token: 0x0600218E RID: 8590 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600218E")]
			[Address(RVA = "0x332A7E0", Offset = "0x3328DE0", VA = "0x18332A7E0")]
			public Sphere(List<SphereCalculator.Point> points)
			{
			}

			// Token: 0x0600218F RID: 8591 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600218F")]
			[Address(RVA = "0x332ACE0", Offset = "0x33292E0", VA = "0x18332ACE0")]
			public Sphere(Vector3 center, float radius)
			{
			}

			// Token: 0x06002190 RID: 8592 RVA: 0x00009D38 File Offset: 0x00007F38
			[Token(Token = "0x6002190")]
			[Address(RVA = "0x332AD00", Offset = "0x3329300", VA = "0x18332AD00")]
			public bool Contains(SphereCalculator.Point point)
			{
				return default(bool);
			}

			// Token: 0x04001F14 RID: 7956
			[Token(Token = "0x4001F14")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 center;

			// Token: 0x04001F15 RID: 7957
			[Token(Token = "0x4001F15")]
			[FieldOffset(Offset = "0x1C")]
			public float radius;
		}
	}
}
