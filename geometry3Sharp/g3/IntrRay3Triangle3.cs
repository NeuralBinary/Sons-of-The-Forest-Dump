using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000188 RID: 392
	[Token(Token = "0x2000188")]
	public class IntrRay3Triangle3
	{
		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x00007EBC File Offset: 0x000060BC
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001E1")]
		public Ray3d Ray
		{
			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x1B19AA0", Offset = "0x1B180A0", VA = "0x181B19AA0")]
			get
			{
				return default(Ray3d);
			}
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x1FFCBC0", Offset = "0x1FFB1C0", VA = "0x181FFCBC0")]
			set
			{
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x00007ED4 File Offset: 0x000060D4
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001E2")]
		public Triangle3d Triangle
		{
			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x1FE5B10", Offset = "0x1FE4110", VA = "0x181FE5B10")]
			get
			{
				return default(Triangle3d);
			}
			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x1FFCBF0", Offset = "0x1FFB1F0", VA = "0x181FFCBF0")]
			set
			{
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00007EEC File Offset: 0x000060EC
		[Token(Token = "0x170001E3")]
		public bool IsSimpleIntersection
		{
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x1FFCC30", Offset = "0x1FFB230", VA = "0x181FFCC30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x1FFCC50", Offset = "0x1FFB250", VA = "0x181FFCC50")]
		public IntrRay3Triangle3(Ray3d r, Triangle3d t)
		{
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x1FFCCA0", Offset = "0x1FFB2A0", VA = "0x181FFCCA0")]
		public IntrRay3Triangle3 Compute()
		{
			return null;
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00007F04 File Offset: 0x00006104
		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x1FFCCC0", Offset = "0x1FFB2C0", VA = "0x181FFCCC0")]
		public bool Find()
		{
			return default(bool);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00007F1C File Offset: 0x0000611C
		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x1FFD0B0", Offset = "0x1FFB6B0", VA = "0x181FFD0B0")]
		public static bool Intersects(ref Ray3d ray, ref Vector3d V0, ref Vector3d V1, ref Vector3d V2, out double rayT)
		{
			return default(bool);
		}

		// Token: 0x04000605 RID: 1541
		[Token(Token = "0x4000605")]
		[FieldOffset(Offset = "0x10")]
		private Ray3d ray;

		// Token: 0x04000606 RID: 1542
		[Token(Token = "0x4000606")]
		[FieldOffset(Offset = "0x40")]
		private Triangle3d triangle;

		// Token: 0x04000607 RID: 1543
		[Token(Token = "0x4000607")]
		[FieldOffset(Offset = "0x88")]
		public int Quantity;

		// Token: 0x04000608 RID: 1544
		[Token(Token = "0x4000608")]
		[FieldOffset(Offset = "0x8C")]
		public IntersectionResult Result;

		// Token: 0x04000609 RID: 1545
		[Token(Token = "0x4000609")]
		[FieldOffset(Offset = "0x90")]
		public IntersectionType Type;

		// Token: 0x0400060A RID: 1546
		[Token(Token = "0x400060A")]
		[FieldOffset(Offset = "0x98")]
		public double RayParameter;

		// Token: 0x0400060B RID: 1547
		[Token(Token = "0x400060B")]
		[FieldOffset(Offset = "0xA0")]
		public Vector3d TriangleBaryCoords;
	}
}
