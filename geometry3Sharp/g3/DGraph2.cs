using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000FA RID: 250
	[Token(Token = "0x20000FA")]
	public class DGraph2 : DGraph
	{
		// Token: 0x0600064A RID: 1610 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1FA8C60", Offset = "0x1FA7260", VA = "0x181FA8C60")]
		public DGraph2()
		{
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1FA8D40", Offset = "0x1FA7340", VA = "0x181FA8D40")]
		public DGraph2(DGraph2 copy)
		{
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00005414 File Offset: 0x00003614
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1FA8E40", Offset = "0x1FA7440", VA = "0x181FA8E40")]
		public Vector2d GetVertex(int vID)
		{
			return default(Vector2d);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x1FA8F20", Offset = "0x1FA7520", VA = "0x181FA8F20")]
		public void SetVertex(int vID, Vector2d vNewPos)
		{
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0000542C File Offset: 0x0000362C
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x1FA9060", Offset = "0x1FA7660", VA = "0x181FA9060")]
		public Vector3f GetVertexColor(int vID)
		{
			return default(Vector3f);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x1FA9170", Offset = "0x1FA7770", VA = "0x181FA9170")]
		public void SetVertexColor(int vID, Vector3f vNewColor)
		{
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00005444 File Offset: 0x00003644
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x1FA92F0", Offset = "0x1FA78F0", VA = "0x181FA92F0")]
		public bool GetEdgeV(int eID, ref Vector2d a, ref Vector2d b)
		{
			return default(bool);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0000545C File Offset: 0x0000365C
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x1FA9410", Offset = "0x1FA7A10", VA = "0x181FA9410")]
		public Segment2d GetEdgeSegment(int eID)
		{
			return default(Segment2d);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00005474 File Offset: 0x00003674
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x1FA95E0", Offset = "0x1FA7BE0", VA = "0x181FA95E0")]
		public Vector2d GetEdgeCenter(int eID)
		{
			return default(Vector2d);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0000548C File Offset: 0x0000368C
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x1FA97A0", Offset = "0x1FA7DA0", VA = "0x181FA97A0")]
		public int AppendVertex(Vector2d v)
		{
			return 0;
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x000054A4 File Offset: 0x000036A4
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x1FA9830", Offset = "0x1FA7E30", VA = "0x181FA9830")]
		public int AppendVertex(Vector2d v, Vector3f c)
		{
			return 0;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x1FA9950", Offset = "0x1FA7F50", VA = "0x181FA9950")]
		public void AppendPolygon(Polygon2d poly, int gid = -1)
		{
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1FA9B10", Offset = "0x1FA8110", VA = "0x181FA9B10")]
		public void AppendPolygon(GeneralPolygon2d poly, int gid = -1)
		{
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x1FA9D20", Offset = "0x1FA8320", VA = "0x181FA9D20")]
		public void AppendPolyline(PolyLine2d poly, int gid = -1)
		{
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x1FA9EC0", Offset = "0x1FA84C0", VA = "0x181FA9EC0")]
		public void AppendGraph(DGraph2 graph, int gid = -1)
		{
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x000054BC File Offset: 0x000036BC
		[Token(Token = "0x170000F8")]
		public bool HasVertexColors
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0x669440", Offset = "0x667A40", VA = "0x180669440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x1FAA400", Offset = "0x1FA8A00", VA = "0x181FAA400")]
		public void EnableVertexColors(Vector3f initial_color)
		{
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600065B")]
		[Address(RVA = "0xA98840", Offset = "0xA96E40", VA = "0x180A98840")]
		public void DiscardVertexColors()
		{
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1FAA6A0", Offset = "0x1FA8CA0", VA = "0x181FAA6A0")]
		public IEnumerable<Vector2d> Vertices()
		{
			return null;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1FAA740", Offset = "0x1FA8D40", VA = "0x181FAA740")]
		public int[] SortedVtxEdges(int vID)
		{
			return null;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x000054D4 File Offset: 0x000036D4
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1FAAB80", Offset = "0x1FA9180", VA = "0x181FAAB80")]
		public AxisAlignedBox2d GetBounds()
		{
			return default(AxisAlignedBox2d);
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x000054EC File Offset: 0x000036EC
		[Token(Token = "0x170000F9")]
		public AxisAlignedBox2d CachedBounds
		{
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x1FAB050", Offset = "0x1FA9650", VA = "0x181FAB050")]
			get
			{
				return default(AxisAlignedBox2d);
			}
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00005504 File Offset: 0x00003704
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x1FAB0B0", Offset = "0x1FA96B0", VA = "0x181FAB0B0")]
		public double OpeningAngle(int vID, double invalidValue = 1.7976931348623157E+308)
		{
			return 0.0;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0000551C File Offset: 0x0000371C
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x1FAB540", Offset = "0x1FA9B40", VA = "0x181FAB540", Slot = "4")]
		protected override int append_new_split_vertex(int a, int b)
		{
			return 0;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x1FAB710", Offset = "0x1FA9D10", VA = "0x181FAB710", Slot = "6")]
		protected override void subclass_validity_checks(Action<bool> CheckOrFailF)
		{
		}

		// Token: 0x040003BD RID: 957
		[Token(Token = "0x40003BD")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector2d InvalidVertex;

		// Token: 0x040003BE RID: 958
		[Token(Token = "0x40003BE")]
		[FieldOffset(Offset = "0x40")]
		private DVector<double> vertices;

		// Token: 0x040003BF RID: 959
		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0x48")]
		private DVector<float> colors;

		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x50")]
		private AxisAlignedBox2d cached_bounds;

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x70")]
		private int cached_bounds_timestamp;
	}
}
