using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200018D RID: 397
	[Token(Token = "0x200018D")]
	public class IntrTriangle3Triangle3
	{
		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00008174 File Offset: 0x00006374
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F3")]
		public Triangle3d Triangle0
		{
			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x1B332A0", Offset = "0x1B318A0", VA = "0x181B332A0")]
			get
			{
				return default(Triangle3d);
			}
			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0x2000170", Offset = "0x1FFE770", VA = "0x182000170")]
			set
			{
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0000818C File Offset: 0x0000638C
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F4")]
		public Triangle3d Triangle1
		{
			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0x1FEABF0", Offset = "0x1FE91F0", VA = "0x181FEABF0")]
			get
			{
				return default(Triangle3d);
			}
			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0x20001B0", Offset = "0x1FFE7B0", VA = "0x1820001B0")]
			set
			{
			}
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x20001F0", Offset = "0x1FFE7F0", VA = "0x1820001F0")]
		public IntrTriangle3Triangle3(Triangle3d t0, Triangle3d t1)
		{
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x2000250", Offset = "0x1FFE850", VA = "0x182000250")]
		public IntrTriangle3Triangle3 Compute()
		{
			return null;
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x000081A4 File Offset: 0x000063A4
		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x2000270", Offset = "0x1FFE870", VA = "0x182000270")]
		public bool Find()
		{
			return default(bool);
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x000081BC File Offset: 0x000063BC
		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x2000CB0", Offset = "0x1FFF2B0", VA = "0x182000CB0")]
		public bool Test()
		{
			return default(bool);
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x000081D4 File Offset: 0x000063D4
		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x2001910", Offset = "0x1FFFF10", VA = "0x182001910")]
		public static bool Intersects(ref Triangle3d triangle0, ref Triangle3d triangle1)
		{
			return default(bool);
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x2002700", Offset = "0x2000D00", VA = "0x182002700")]
		public static void ProjectOntoAxis(ref Triangle3d triangle, ref Vector3d axis, out double fmin, out double fmax)
		{
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x2002800", Offset = "0x2000E00", VA = "0x182002800")]
		public static void TrianglePlaneRelations(ref Triangle3d triangle, ref Plane3d plane, out Vector3d distance, out Index3i sign, out int positive, out int negative, out int zero)
		{
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x000081EC File Offset: 0x000063EC
		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x2002A50", Offset = "0x2001050", VA = "0x182002A50")]
		private bool ContainsPoint(ref Triangle3d triangle, ref Plane3d plane, Vector3d point)
		{
			return default(bool);
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00008204 File Offset: 0x00006404
		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x2002E30", Offset = "0x2001430", VA = "0x182002E30")]
		private bool IntersectsSegment(ref Plane3d plane, ref Triangle3d triangle, Vector3d end0, Vector3d end1)
		{
			return default(bool);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0000821C File Offset: 0x0000641C
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x2003530", Offset = "0x2001B30", VA = "0x182003530")]
		private bool GetCoplanarIntersection(ref Plane3d plane, ref Triangle3d tri0, ref Triangle3d tri1)
		{
			return default(bool);
		}

		// Token: 0x04000630 RID: 1584
		[Token(Token = "0x4000630")]
		[FieldOffset(Offset = "0x10")]
		private Triangle3d triangle0;

		// Token: 0x04000631 RID: 1585
		[Token(Token = "0x4000631")]
		[FieldOffset(Offset = "0x58")]
		private Triangle3d triangle1;

		// Token: 0x04000632 RID: 1586
		[Token(Token = "0x4000632")]
		[FieldOffset(Offset = "0xA0")]
		public bool ReportCoplanarIntersection;

		// Token: 0x04000633 RID: 1587
		[Token(Token = "0x4000633")]
		[FieldOffset(Offset = "0xA4")]
		public int Quantity;

		// Token: 0x04000634 RID: 1588
		[Token(Token = "0x4000634")]
		[FieldOffset(Offset = "0xA8")]
		public IntersectionResult Result;

		// Token: 0x04000635 RID: 1589
		[Token(Token = "0x4000635")]
		[FieldOffset(Offset = "0xAC")]
		public IntersectionType Type;

		// Token: 0x04000636 RID: 1590
		[Token(Token = "0x4000636")]
		[FieldOffset(Offset = "0xB0")]
		public Vector3dTuple3 Points;

		// Token: 0x04000637 RID: 1591
		[Token(Token = "0x4000637")]
		[FieldOffset(Offset = "0xF8")]
		public Vector3d[] PolygonPoints;
	}
}
