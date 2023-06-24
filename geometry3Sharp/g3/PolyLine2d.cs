using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000130 RID: 304
	[Token(Token = "0x2000130")]
	public class PolyLine2d : IEnumerable<Vector2d>, IEnumerable
	{
		// Token: 0x06000859 RID: 2137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000859")]
		[Address(RVA = "0x1FD9DB0", Offset = "0x1FD83B0", VA = "0x181FD9DB0")]
		public PolyLine2d()
		{
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600085A")]
		[Address(RVA = "0x1FD9E70", Offset = "0x1FD8470", VA = "0x181FD9E70")]
		public PolyLine2d(PolyLine2d copy)
		{
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x1FD9F50", Offset = "0x1FD8550", VA = "0x181FD9F50")]
		public PolyLine2d(Polygon2d copy, bool bDuplicateFirstLast)
		{
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600085C")]
		[Address(RVA = "0x1FDA0E0", Offset = "0x1FD86E0", VA = "0x181FDA0E0")]
		public PolyLine2d(IList<Vector2d> copy)
		{
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x1FDA1B0", Offset = "0x1FD87B0", VA = "0x181FDA1B0")]
		public PolyLine2d(IEnumerable<Vector2d> copy)
		{
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x1FDA280", Offset = "0x1FD8880", VA = "0x181FDA280")]
		public PolyLine2d(Vector2d[] v)
		{
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x1FDA350", Offset = "0x1FD8950", VA = "0x181FDA350")]
		public PolyLine2d(VectorArray2d v)
		{
		}

		// Token: 0x17000168 RID: 360
		[Token(Token = "0x17000168")]
		public Vector2d this[int key]
		{
			[Token(Token = "0x6000860")]
			[Address(RVA = "0x1FDA430", Offset = "0x1FD8A30", VA = "0x181FDA430")]
			get
			{
				return default(Vector2d);
			}
			[Token(Token = "0x6000861")]
			[Address(RVA = "0x1FDA4C0", Offset = "0x1FD8AC0", VA = "0x181FDA4C0")]
			set
			{
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x000065B4 File Offset: 0x000047B4
		[Token(Token = "0x17000169")]
		public Vector2d Start
		{
			[Token(Token = "0x6000862")]
			[Address(RVA = "0x1FDA550", Offset = "0x1FD8B50", VA = "0x181FDA550")]
			get
			{
				return default(Vector2d);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x000065CC File Offset: 0x000047CC
		[Token(Token = "0x1700016A")]
		public Vector2d End
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0x1FDA5D0", Offset = "0x1FD8BD0", VA = "0x181FDA5D0")]
			get
			{
				return default(Vector2d);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700016B")]
		public ReadOnlyCollection<Vector2d> Vertices
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0x1FDA660", Offset = "0x1FD8C60", VA = "0x181FDA660")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x000065E4 File Offset: 0x000047E4
		[Token(Token = "0x1700016C")]
		public int VertexCount
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x1FDA6A0", Offset = "0x1FD8CA0", VA = "0x181FDA6A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x1FDA6E0", Offset = "0x1FD8CE0", VA = "0x181FDA6E0", Slot = "6")]
		public virtual void AppendVertex(Vector2d v)
		{
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x1FDA7A0", Offset = "0x1FD8DA0", VA = "0x181FDA7A0", Slot = "7")]
		public virtual void AppendVertices(IEnumerable<Vector2d> v)
		{
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000868")]
		[Address(RVA = "0x1FDA810", Offset = "0x1FD8E10", VA = "0x181FDA810", Slot = "8")]
		public virtual void Reverse()
		{
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x000065FC File Offset: 0x000047FC
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x1FDA860", Offset = "0x1FD8E60", VA = "0x181FDA860")]
		public Vector2d GetTangent(int i)
		{
			return default(Vector2d);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00006614 File Offset: 0x00004814
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x1FDAB40", Offset = "0x1FD9140", VA = "0x181FDAB40")]
		public Vector2d GetNormal(int i)
		{
			return default(Vector2d);
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0000662C File Offset: 0x0000482C
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x1FDAB80", Offset = "0x1FD9180", VA = "0x181FDAB80")]
		public AxisAlignedBox2d GetBounds()
		{
			return default(AxisAlignedBox2d);
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x00006644 File Offset: 0x00004844
		[Token(Token = "0x1700016D")]
		public AxisAlignedBox2d Bounds
		{
			[Token(Token = "0x600086C")]
			[Address(RVA = "0x1FDAD30", Offset = "0x1FD9330", VA = "0x181FDAD30")]
			get
			{
				return default(AxisAlignedBox2d);
			}
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0000665C File Offset: 0x0000485C
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x1FDAD60", Offset = "0x1FD9360", VA = "0x181FDAD60")]
		public double DistanceSquared(Vector2d point)
		{
			return 0.0;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00006674 File Offset: 0x00004874
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x1FDB060", Offset = "0x1FD9660", VA = "0x181FDB060")]
		public Segment2d Segment(int iSegment)
		{
			return default(Segment2d);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x1FDB160", Offset = "0x1FD9760", VA = "0x181FDB160")]
		public IEnumerable<Segment2d> SegmentItr()
		{
			return null;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x1FDB200", Offset = "0x1FD9800", VA = "0x181FDB200", Slot = "4")]
		public IEnumerator<Vector2d> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x1FDB2E0", Offset = "0x1FD98E0", VA = "0x181FDB2E0", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x0000668C File Offset: 0x0000488C
		[Token(Token = "0x1700016E")]
		[Obsolete("This method name is confusing. Will remove in future. Use ArcLength instead")]
		public double Length
		{
			[Token(Token = "0x6000872")]
			[Address(RVA = "0x1FDB3C0", Offset = "0x1FD99C0", VA = "0x181FDB3C0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x000066A4 File Offset: 0x000048A4
		[Token(Token = "0x1700016F")]
		public double ArcLength
		{
			[Token(Token = "0x6000873")]
			[Address(RVA = "0x1FDB3D0", Offset = "0x1FD99D0", VA = "0x181FDB3D0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x1FDB580", Offset = "0x1FD9B80", VA = "0x181FDB580")]
		public void VertexOffset(double dist)
		{
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x000066BC File Offset: 0x000048BC
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x1FDB800", Offset = "0x1FD9E00", VA = "0x181FDB800")]
		public bool TrimStart(double dist)
		{
			return default(bool);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x000066D4 File Offset: 0x000048D4
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x1FDBC10", Offset = "0x1FDA210", VA = "0x181FDBC10")]
		public bool TrimEnd(double dist)
		{
			return default(bool);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x000066EC File Offset: 0x000048EC
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x1FDC020", Offset = "0x1FDA620", VA = "0x181FDC020")]
		public bool Trim(double each_end_dist)
		{
			return default(bool);
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x1FD6990", Offset = "0x1FD4F90", VA = "0x181FD6990")]
		protected static void simplifyDP(double tol, Vector2d[] v, int j, int k, bool[] mk)
		{
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x1FDC080", Offset = "0x1FDA680", VA = "0x181FDC080", Slot = "9")]
		public virtual void Simplify(double clusterTol = 0.0001, double lineDeviationTol = 0.01, bool bSimplifyStraightLines = true)
		{
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x1FDC5B0", Offset = "0x1FDABB0", VA = "0x181FDC5B0")]
		public PolyLine2d Transform(ITransform2 xform)
		{
			return null;
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x1FDC780", Offset = "0x1FDAD80", VA = "0x181FDC780")]
		public static PolyLine2d MakeBoxSpiral(Vector2d center, double len, double spacing)
		{
			return null;
		}

		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x10")]
		protected List<Vector2d> vertices;

		// Token: 0x04000499 RID: 1177
		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x18")]
		public int Timestamp;
	}
}
