using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200012A RID: 298
	[Token(Token = "0x200012A")]
	public class Polygon2d : IDuplicatable<Polygon2d>
	{
		// Token: 0x060007F6 RID: 2038 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x1FD13B0", Offset = "0x1FCF9B0", VA = "0x181FD13B0")]
		public Polygon2d()
		{
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x1FD1470", Offset = "0x1FCFA70", VA = "0x181FD1470")]
		public Polygon2d(Polygon2d copy)
		{
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x1FD1550", Offset = "0x1FCFB50", VA = "0x181FD1550")]
		public Polygon2d(IList<Vector2d> copy)
		{
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x1FD1620", Offset = "0x1FCFC20", VA = "0x181FD1620")]
		public Polygon2d(IEnumerable<Vector2d> copy)
		{
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x1FD16F0", Offset = "0x1FCFCF0", VA = "0x181FD16F0")]
		public Polygon2d(Vector2d[] v)
		{
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x1FD17C0", Offset = "0x1FCFDC0", VA = "0x181FD17C0")]
		public Polygon2d(VectorArray2d v)
		{
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x1FD18A0", Offset = "0x1FCFEA0", VA = "0x181FD18A0")]
		public Polygon2d(double[] values)
		{
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x1FD1A60", Offset = "0x1FD0060", VA = "0x181FD1A60")]
		public Polygon2d(Func<int, Vector2d> SourceF, int N)
		{
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x1FD1C00", Offset = "0x1FD0200", VA = "0x181FD1C00", Slot = "5")]
		public virtual Polygon2d Duplicate()
		{
			return null;
		}

		// Token: 0x17000154 RID: 340
		[Token(Token = "0x17000154")]
		public Vector2d this[int key]
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x1FD1C70", Offset = "0x1FD0270", VA = "0x181FD1C70")]
			get
			{
				return default(Vector2d);
			}
			[Token(Token = "0x6000800")]
			[Address(RVA = "0x1FD1D00", Offset = "0x1FD0300", VA = "0x181FD1D00")]
			set
			{
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x000061DC File Offset: 0x000043DC
		[Token(Token = "0x17000155")]
		public Vector2d Start
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0x1FD1D90", Offset = "0x1FD0390", VA = "0x181FD1D90")]
			get
			{
				return default(Vector2d);
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000156")]
		public ReadOnlyCollection<Vector2d> Vertices
		{
			[Token(Token = "0x6000802")]
			[Address(RVA = "0x1FD1E10", Offset = "0x1FD0410", VA = "0x181FD1E10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x000061F4 File Offset: 0x000043F4
		[Token(Token = "0x17000157")]
		public int VertexCount
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0x1FD1E50", Offset = "0x1FD0450", VA = "0x181FD1E50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x1FD1E90", Offset = "0x1FD0490", VA = "0x181FD1E90")]
		public void AppendVertex(Vector2d v)
		{
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x1FD1F50", Offset = "0x1FD0550", VA = "0x181FD1F50")]
		public void AppendVertices(IEnumerable<Vector2d> v)
		{
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x1FD1FC0", Offset = "0x1FD05C0", VA = "0x181FD1FC0")]
		public void RemoveVertex(int idx)
		{
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x1FD2050", Offset = "0x1FD0650", VA = "0x181FD2050")]
		public void SetVertices(List<Vector2d> newVertices, bool bTakeOwnership)
		{
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x1FD2210", Offset = "0x1FD0810", VA = "0x181FD2210")]
		public void Reverse()
		{
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x0000620C File Offset: 0x0000440C
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x1FD2260", Offset = "0x1FD0860", VA = "0x181FD2260")]
		public Vector2d GetTangent(int i)
		{
			return default(Vector2d);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00006224 File Offset: 0x00004424
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x1FD2480", Offset = "0x1FD0A80", VA = "0x181FD2480")]
		public Vector2d GetNormal(int i)
		{
			return default(Vector2d);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x0000623C File Offset: 0x0000443C
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x1FD24C0", Offset = "0x1FD0AC0", VA = "0x181FD24C0")]
		public Vector2d GetNormal_FaceAvg(int i)
		{
			return default(Vector2d);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00006254 File Offset: 0x00004454
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1FD29D0", Offset = "0x1FD0FD0", VA = "0x181FD29D0")]
		public AxisAlignedBox2d GetBounds()
		{
			return default(AxisAlignedBox2d);
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x0000626C File Offset: 0x0000446C
		[Token(Token = "0x17000158")]
		public AxisAlignedBox2d Bounds
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0x1FD2A60", Offset = "0x1FD1060", VA = "0x181FD2A60")]
			get
			{
				return default(AxisAlignedBox2d);
			}
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x1FD2B00", Offset = "0x1FD1100", VA = "0x181FD2B00")]
		public IEnumerable<Segment2d> SegmentItr()
		{
			return null;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x1FD2BA0", Offset = "0x1FD11A0", VA = "0x181FD2BA0")]
		public IEnumerable<Vector2d> VerticesItr(bool bRepeatFirstAtEnd)
		{
			return null;
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x00006284 File Offset: 0x00004484
		[Token(Token = "0x17000159")]
		public bool IsClockwise
		{
			[Token(Token = "0x6000810")]
			[Address(RVA = "0x1FD2C60", Offset = "0x1FD1260", VA = "0x181FD2C60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x0000629C File Offset: 0x0000449C
		[Token(Token = "0x1700015A")]
		public double SignedArea
		{
			[Token(Token = "0x6000811")]
			[Address(RVA = "0x1FD2C80", Offset = "0x1FD1280", VA = "0x181FD2C80")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x000062B4 File Offset: 0x000044B4
		[Token(Token = "0x1700015B")]
		public double Area
		{
			[Token(Token = "0x6000812")]
			[Address(RVA = "0x1FD2DE0", Offset = "0x1FD13E0", VA = "0x181FD2DE0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x000062CC File Offset: 0x000044CC
		[Token(Token = "0x1700015C")]
		public double Perimeter
		{
			[Token(Token = "0x6000813")]
			[Address(RVA = "0x1FD2E50", Offset = "0x1FD1450", VA = "0x181FD2E50")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x000062E4 File Offset: 0x000044E4
		[Token(Token = "0x1700015D")]
		public double ArcLength
		{
			[Token(Token = "0x6000814")]
			[Address(RVA = "0x1FD3010", Offset = "0x1FD1610", VA = "0x181FD3010")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1FD3020", Offset = "0x1FD1620", VA = "0x181FD3020")]
		public void NeighboursP(int iVertex, ref Vector2d p0, ref Vector2d p1)
		{
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x1FD3110", Offset = "0x1FD1710", VA = "0x181FD3110")]
		public void NeighboursV(int iVertex, ref Vector2d v0, ref Vector2d v1, bool bNormalize = false)
		{
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x000062FC File Offset: 0x000044FC
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x1FD3370", Offset = "0x1FD1970", VA = "0x181FD3370")]
		public double OpeningAngleDeg(int iVertex)
		{
			return 0.0;
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00006314 File Offset: 0x00004514
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x1FD34B0", Offset = "0x1FD1AB0", VA = "0x181FD34B0")]
		public double WindingIntegral(Vector2d P)
		{
			return 0.0;
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0000632C File Offset: 0x0000452C
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1FD36E0", Offset = "0x1FD1CE0", VA = "0x181FD36E0")]
		public bool Contains(Vector2d P)
		{
			return default(bool);
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00006344 File Offset: 0x00004544
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x1FD38E0", Offset = "0x1FD1EE0", VA = "0x181FD38E0")]
		public bool Contains(Polygon2d o)
		{
			return default(bool);
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0000635C File Offset: 0x0000455C
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x1FD39E0", Offset = "0x1FD1FE0", VA = "0x181FD39E0")]
		public bool Contains(Segment2d o)
		{
			return default(bool);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00006374 File Offset: 0x00004574
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x1FD3C30", Offset = "0x1FD2230", VA = "0x181FD3C30")]
		public bool Intersects(Polygon2d o)
		{
			return default(bool);
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x0000638C File Offset: 0x0000458C
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x1FD4060", Offset = "0x1FD2660", VA = "0x181FD4060")]
		public bool Intersects(Segment2d o)
		{
			return default(bool);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x1FD42B0", Offset = "0x1FD28B0", VA = "0x181FD42B0")]
		public List<Vector2d> FindIntersections(Polygon2d o)
		{
			return null;
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x000063A4 File Offset: 0x000045A4
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x1FD4830", Offset = "0x1FD2E30", VA = "0x181FD4830")]
		public Segment2d Segment(int iSegment)
		{
			return default(Segment2d);
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x000063BC File Offset: 0x000045BC
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x1FD4940", Offset = "0x1FD2F40", VA = "0x181FD4940")]
		public Vector2d PointAt(int iSegment, double fSegT)
		{
			return default(Vector2d);
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x000063D4 File Offset: 0x000045D4
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x1FD4BB0", Offset = "0x1FD31B0", VA = "0x181FD4BB0")]
		public Vector2d GetNormal(int iSeg, double segT)
		{
			return default(Vector2d);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x000063EC File Offset: 0x000045EC
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x1FD4F40", Offset = "0x1FD3540", VA = "0x181FD4F40")]
		public double DistanceSquared(Vector2d p, out int iNearSeg, out double fNearSegT)
		{
			return 0.0;
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00006404 File Offset: 0x00004604
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x1FD5440", Offset = "0x1FD3A40", VA = "0x181FD5440")]
		public double DistanceSquared(Vector2d p)
		{
			return 0.0;
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x0000641C File Offset: 0x0000461C
		[Token(Token = "0x1700015E")]
		public double AverageEdgeLength
		{
			[Token(Token = "0x6000824")]
			[Address(RVA = "0x1FD5480", Offset = "0x1FD3A80", VA = "0x181FD5480")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x1FD5710", Offset = "0x1FD3D10", VA = "0x181FD5710")]
		public Polygon2d Translate(Vector2d translate)
		{
			return null;
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x1FD5890", Offset = "0x1FD3E90", VA = "0x181FD5890")]
		public Polygon2d Rotate(Matrix2d rotation, Vector2d origin)
		{
			return null;
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x1FD5A70", Offset = "0x1FD4070", VA = "0x181FD5A70")]
		public Polygon2d Scale(Vector2d scale, Vector2d origin)
		{
			return null;
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x1FD5C30", Offset = "0x1FD4230", VA = "0x181FD5C30")]
		public Polygon2d Transform(Func<Vector2d, Vector2d> transformF)
		{
			return null;
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x1FD5D80", Offset = "0x1FD4380", VA = "0x181FD5D80")]
		public Polygon2d Transform(ITransform2 xform)
		{
			return null;
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x1FD5F60", Offset = "0x1FD4560", VA = "0x181FD5F60")]
		public void VtxNormalOffset(double dist, bool bUseFaceAvg = false)
		{
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x1FD62D0", Offset = "0x1FD48D0", VA = "0x181FD62D0")]
		public void PolyOffset(double dist)
		{
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x1FD6990", Offset = "0x1FD4F90", VA = "0x181FD6990")]
		private static void simplifyDP(double tol, Vector2d[] v, int j, int k, bool[] mk)
		{
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x1FD6C90", Offset = "0x1FD5290", VA = "0x181FD6C90")]
		public void Simplify(double clusterTol = 0.0001, double lineDeviationTol = 0.01, bool bSimplifyStraightLines = true)
		{
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x1FD7360", Offset = "0x1FD5960", VA = "0x181FD7360")]
		public void Chamfer(double chamfer_dist, double minConvexAngleDeg = 30.0, double minConcaveAngleDeg = 30.0)
		{
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00006434 File Offset: 0x00004634
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x1FD7E20", Offset = "0x1FD6420", VA = "0x181FD7E20")]
		public Box2d MinimalBoundingBox(double epsilon)
		{
			return default(Box2d);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x1FD7ED0", Offset = "0x1FD64D0", VA = "0x181FD7ED0")]
		public static Polygon2d MakeRectangle(Vector2d center, double width, double height)
		{
			return null;
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x1FD8080", Offset = "0x1FD6680", VA = "0x181FD8080")]
		public static Polygon2d MakeCircle(double fRadius, int nSteps, double angleShiftRad = 0.0)
		{
			return null;
		}

		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x10")]
		protected List<Vector2d> vertices;

		// Token: 0x04000484 RID: 1156
		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0x18")]
		public int Timestamp;
	}
}
