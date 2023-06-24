using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000107 RID: 263
	[Token(Token = "0x2000107")]
	public class GeneralPolygon2d : IDuplicatable<GeneralPolygon2d>
	{
		// Token: 0x060006D9 RID: 1753 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x1FB98A0", Offset = "0x1FB7EA0", VA = "0x181FB98A0")]
		public GeneralPolygon2d()
		{
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1FB9950", Offset = "0x1FB7F50", VA = "0x181FB9950")]
		public GeneralPolygon2d(Polygon2d outer)
		{
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x1FB9A10", Offset = "0x1FB8010", VA = "0x181FB9A10")]
		public GeneralPolygon2d(GeneralPolygon2d copy)
		{
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x1FB9D90", Offset = "0x1FB8390", VA = "0x181FB9D90", Slot = "5")]
		public virtual GeneralPolygon2d Duplicate()
		{
			return null;
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700010E")]
		public Polygon2d Outer
		{
			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x1FB9DF0", Offset = "0x1FB83F0", VA = "0x181FB9DF0")]
			set
			{
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x1FB9E70", Offset = "0x1FB8470", VA = "0x181FB9E70")]
		public void AddHole(Polygon2d hole, bool bCheckContainment = true, bool bCheckOrientation = true)
		{
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1FBA1E0", Offset = "0x1FB87E0", VA = "0x181FBA1E0")]
		public void ClearHoles()
		{
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x000059CC File Offset: 0x00003BCC
		[Token(Token = "0x1700010F")]
		private bool HasHoles
		{
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x1FBA240", Offset = "0x1FB8840", VA = "0x181FBA240")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000110")]
		public ReadOnlyCollection<Polygon2d> Holes
		{
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x1FBA290", Offset = "0x1FB8890", VA = "0x181FBA290")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x000059E4 File Offset: 0x00003BE4
		[Token(Token = "0x17000111")]
		public double Area
		{
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x1FBA350", Offset = "0x1FB8950", VA = "0x181FBA350")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x000059FC File Offset: 0x00003BFC
		[Token(Token = "0x17000112")]
		public double HoleArea
		{
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x1FBA500", Offset = "0x1FB8B00", VA = "0x181FBA500")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00005A14 File Offset: 0x00003C14
		[Token(Token = "0x17000113")]
		public double Perimeter
		{
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x1FBA770", Offset = "0x1FB8D70", VA = "0x181FBA770")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00005A2C File Offset: 0x00003C2C
		[Token(Token = "0x17000114")]
		public AxisAlignedBox2d Bounds
		{
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x1FBA8F0", Offset = "0x1FB8EF0", VA = "0x181FBA8F0")]
			get
			{
				return default(AxisAlignedBox2d);
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00005A44 File Offset: 0x00003C44
		[Token(Token = "0x17000115")]
		public int VertexCount
		{
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x1FBABA0", Offset = "0x1FB91A0", VA = "0x181FBABA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1FBAD60", Offset = "0x1FB9360", VA = "0x181FBAD60")]
		public void Translate(Vector2d translate)
		{
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1FBAEF0", Offset = "0x1FB94F0", VA = "0x181FBAEF0")]
		public void Rotate(Matrix2d rotation, Vector2d origin)
		{
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1FBB080", Offset = "0x1FB9680", VA = "0x181FBB080")]
		public void Scale(Vector2d scale, Vector2d origin)
		{
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1FBB230", Offset = "0x1FB9830", VA = "0x181FBB230")]
		public void Transform(Func<Vector2d, Vector2d> transformF)
		{
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1FBB3A0", Offset = "0x1FB99A0", VA = "0x181FBB3A0")]
		public void Reverse()
		{
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00005A5C File Offset: 0x00003C5C
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x1FBB610", Offset = "0x1FB9C10", VA = "0x181FBB610")]
		public bool Contains(Vector2d vTest)
		{
			return default(bool);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00005A74 File Offset: 0x00003C74
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1FBB7B0", Offset = "0x1FB9DB0", VA = "0x181FBB7B0")]
		public bool Contains(Polygon2d poly)
		{
			return default(bool);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00005A8C File Offset: 0x00003C8C
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1FBB930", Offset = "0x1FB9F30", VA = "0x181FBB930")]
		public bool Contains(Segment2d seg)
		{
			return default(bool);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00005AA4 File Offset: 0x00003CA4
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1FBBB00", Offset = "0x1FBA100", VA = "0x181FBBB00")]
		public bool Intersects(Polygon2d poly)
		{
			return default(bool);
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00005ABC File Offset: 0x00003CBC
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x1FBBC80", Offset = "0x1FBA280", VA = "0x181FBBC80")]
		public Vector2d PointAt(int iSegment, double fSegT, int iHoleIndex = -1)
		{
			return default(Vector2d);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00005AD4 File Offset: 0x00003CD4
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1FBBD40", Offset = "0x1FBA340", VA = "0x181FBBD40")]
		public Segment2d Segment(int iSegment, int iHoleIndex = -1)
		{
			return default(Segment2d);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00005AEC File Offset: 0x00003CEC
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1FBBE10", Offset = "0x1FBA410", VA = "0x181FBBE10")]
		public Vector2d GetNormal(int iSegment, double segT, int iHoleIndex = -1)
		{
			return default(Vector2d);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00005B04 File Offset: 0x00003D04
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1FBBED0", Offset = "0x1FBA4D0", VA = "0x181FBBED0")]
		public double DistanceSquared(Vector2d p, out int iHoleIndex, out int iNearSeg, out double fNearSegT)
		{
			return 0.0;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1FBC0F0", Offset = "0x1FBA6F0", VA = "0x181FBC0F0")]
		public IEnumerable<Segment2d> AllSegmentsItr()
		{
			return null;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1FBC190", Offset = "0x1FBA790", VA = "0x181FBC190")]
		public IEnumerable<Vector2d> AllVerticesItr()
		{
			return null;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x1FBC230", Offset = "0x1FBA830", VA = "0x181FBC230")]
		public void Simplify(double clusterTol = 0.0001, double lineDeviationTol = 0.01, bool bSimplifyStraightLines = true)
		{
		}

		// Token: 0x040003EE RID: 1006
		[Token(Token = "0x40003EE")]
		[FieldOffset(Offset = "0x10")]
		private Polygon2d outer;

		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		[FieldOffset(Offset = "0x18")]
		private bool bOuterIsCW;

		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0x20")]
		private List<Polygon2d> holes;
	}
}
