using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000100 RID: 256
	[Token(Token = "0x2000100")]
	public class DGraph3 : DGraph
	{
		// Token: 0x06000683 RID: 1667 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1FB1E10", Offset = "0x1FB0410", VA = "0x181FB1E10")]
		public DGraph3()
		{
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1FB1EF0", Offset = "0x1FB04F0", VA = "0x181FB1EF0")]
		public DGraph3(DGraph3 copy)
		{
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x000055F4 File Offset: 0x000037F4
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1FB2000", Offset = "0x1FB0600", VA = "0x181FB2000")]
		public Vector3d GetVertex(int vID)
		{
			return default(Vector3d);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1FB2170", Offset = "0x1FB0770", VA = "0x181FB2170")]
		public void SetVertex(int vID, Vector3d vNewPos)
		{
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0000560C File Offset: 0x0000380C
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x1FB2350", Offset = "0x1FB0950", VA = "0x181FB2350")]
		public Vector3f GetVertexColor(int vID)
		{
			return default(Vector3f);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1FB2460", Offset = "0x1FB0A60", VA = "0x181FB2460")]
		public void SetVertexColor(int vID, Vector3f vNewColor)
		{
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00005624 File Offset: 0x00003824
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1FB25E0", Offset = "0x1FB0BE0", VA = "0x181FB25E0")]
		public bool GetEdgeV(int eID, ref Vector3d a, ref Vector3d b)
		{
			return default(bool);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0000563C File Offset: 0x0000383C
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1FB2730", Offset = "0x1FB0D30", VA = "0x181FB2730")]
		public Segment3d GetEdgeSegment(int eID)
		{
			return default(Segment3d);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00005654 File Offset: 0x00003854
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1FB2980", Offset = "0x1FB0F80", VA = "0x181FB2980")]
		public Vector3d GetEdgeCenter(int eID)
		{
			return default(Vector3d);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1FB2BB0", Offset = "0x1FB11B0", VA = "0x181FB2BB0")]
		public IEnumerable<Segment3d> Segments()
		{
			return null;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0000566C File Offset: 0x0000386C
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x1FB2C50", Offset = "0x1FB1250", VA = "0x181FB2C50")]
		public int AppendVertex(Vector3d v)
		{
			return 0;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00005684 File Offset: 0x00003884
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1FB2CF0", Offset = "0x1FB12F0", VA = "0x181FB2CF0")]
		public int AppendVertex(Vector3d v, Vector3f c)
		{
			return 0;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x1FB2E30", Offset = "0x1FB1430", VA = "0x181FB2E30")]
		public void AppendGraph(DGraph3 graph, int gid = -1)
		{
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x0000569C File Offset: 0x0000389C
		[Token(Token = "0x170000FC")]
		public bool HasVertexColors
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x669440", Offset = "0x667A40", VA = "0x180669440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x1FB3390", Offset = "0x1FB1990", VA = "0x181FB3390")]
		public void EnableVertexColors(Vector3f initial_color)
		{
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000692")]
		[Address(RVA = "0xA98840", Offset = "0xA96E40", VA = "0x180A98840")]
		public void DiscardVertexColors()
		{
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x1FB3630", Offset = "0x1FB1C30", VA = "0x181FB3630")]
		public IEnumerable<Vector3d> Vertices()
		{
			return null;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x000056B4 File Offset: 0x000038B4
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x1FB36D0", Offset = "0x1FB1CD0", VA = "0x181FB36D0")]
		public AxisAlignedBox3d GetBounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x000056CC File Offset: 0x000038CC
		[Token(Token = "0x170000FD")]
		public AxisAlignedBox3d CachedBounds
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x1FB3C70", Offset = "0x1FB2270", VA = "0x181FB3C70")]
			get
			{
				return default(AxisAlignedBox3d);
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x000056E4 File Offset: 0x000038E4
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x1FB3CE0", Offset = "0x1FB22E0", VA = "0x181FB3CE0", Slot = "4")]
		protected override int append_new_split_vertex(int a, int b)
		{
			return 0;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x1FB3EE0", Offset = "0x1FB24E0", VA = "0x181FB3EE0", Slot = "6")]
		protected override void subclass_validity_checks(Action<bool> CheckOrFailF)
		{
		}

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector3d InvalidVertex;

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x40")]
		private DVector<double> vertices;

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x48")]
		private DVector<float> colors;

		// Token: 0x040003D0 RID: 976
		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0x50")]
		private AxisAlignedBox3d cached_bounds;

		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x80")]
		private int cached_bounds_timestamp;
	}
}
