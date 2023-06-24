using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	public class GraphSplitter2d
	{
		// Token: 0x0600018C RID: 396 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1E26240", Offset = "0x1E24840", VA = "0x181E26240")]
		public GraphSplitter2d(DGraph2 graph)
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1E26400", Offset = "0x1E24A00", VA = "0x181E26400")]
		public void InsertLine(Line2d line, int insert_edges_id = -1)
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1E26450", Offset = "0x1E24A50", VA = "0x181E26450", Slot = "4")]
		protected virtual void do_split(Line2d line, bool insert_edges, int insert_gid)
		{
		}

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x10")]
		public DGraph2 Graph;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x18")]
		public double OnVertexTol;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x20")]
		public int InsertedEdgesID;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x28")]
		public Func<Vector2d, bool> InsideTestF;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x30")]
		private DVector<int> EdgeSigns;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x38")]
		private List<GraphSplitter2d.edge_hit> hits;

		// Token: 0x02000057 RID: 87
		[Token(Token = "0x2000057")]
		private struct edge_hit
		{
			// Token: 0x040001C4 RID: 452
			[Token(Token = "0x40001C4")]
			[FieldOffset(Offset = "0x0")]
			public int hit_eid;

			// Token: 0x040001C5 RID: 453
			[Token(Token = "0x40001C5")]
			[FieldOffset(Offset = "0x4")]
			public Index2i vtx_signs;

			// Token: 0x040001C6 RID: 454
			[Token(Token = "0x40001C6")]
			[FieldOffset(Offset = "0xC")]
			public int hit_vid;

			// Token: 0x040001C7 RID: 455
			[Token(Token = "0x40001C7")]
			[FieldOffset(Offset = "0x10")]
			public Vector2d hit_pos;

			// Token: 0x040001C8 RID: 456
			[Token(Token = "0x40001C8")]
			[FieldOffset(Offset = "0x20")]
			public double line_t;
		}
	}
}
