using System;
using System.Collections.Generic;
using g3;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public class AutoHoleFill
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1DFC6E0", Offset = "0x1DFACE0", VA = "0x181DFC6E0")]
		public AutoHoleFill(DMesh3 mesh, EdgeLoop fillLoop)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1DFC7A0", Offset = "0x1DFADA0", VA = "0x181DFC7A0")]
		public bool Apply()
		{
			return default(bool);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850")]
		private AutoHoleFill.UseFillType classify_hole()
		{
			return AutoHoleFill.UseFillType.PlanarFill;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1DFC840", Offset = "0x1DFAE40", VA = "0x181DFC840")]
		private bool fill_smooth()
		{
			return default(bool);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1DFC9F0", Offset = "0x1DFAFF0", VA = "0x181DFC9F0")]
		private bool fill_planar()
		{
			return default(bool);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1DFCF50", Offset = "0x1DFB550", VA = "0x181DFCF50")]
		private bool fill_minimal()
		{
			return default(bool);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1DFCFD0", Offset = "0x1DFB5D0", VA = "0x181DFCFD0")]
		private bool fill_planar_spans()
		{
			return default(bool);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1DFD650", Offset = "0x1DFBC50", VA = "0x181DFD650")]
		private List<List<EdgeSpan>> sort_planar_spans(List<EdgeSpan> allspans, Vector3d normal)
		{
			return null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1DFE1C0", Offset = "0x1DFC7C0", VA = "0x181DFE1C0")]
		private PolyLine2d to_polyline(EdgeSpan span, Frame3f polyFrame)
		{
			return null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1DFE3C0", Offset = "0x1DFC9C0", VA = "0x181DFE3C0")]
		private Polygon2d to_polygon(EdgeSpan span, Frame3f polyFrame)
		{
			return null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1DFE650", Offset = "0x1DFCC50", VA = "0x181DFE650")]
		private bool self_intersects(PolyLine2d poly)
		{
			return default(bool);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1DFE920", Offset = "0x1DFCF20", VA = "0x181DFE920")]
		private Dictionary<Vector3d, List<EdgeSpan>> find_coplanar_span_sets(DMesh3 mesh, EdgeLoop loop)
		{
			return null;
		}

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x18")]
		public double TargetEdgeLength;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x20")]
		public EdgeLoop FillLoop;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x28")]
		public int[] FillTriangles;

		// Token: 0x02000012 RID: 18
		[Token(Token = "0x2000012")]
		private enum UseFillType
		{
			// Token: 0x0400004D RID: 77
			[Token(Token = "0x400004D")]
			PlanarFill,
			// Token: 0x0400004E RID: 78
			[Token(Token = "0x400004E")]
			MinimalFill,
			// Token: 0x0400004F RID: 79
			[Token(Token = "0x400004F")]
			PlanarSpansFill,
			// Token: 0x04000050 RID: 80
			[Token(Token = "0x4000050")]
			SmoothFill
		}
	}
}
