using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000301 RID: 769
	[Token(Token = "0x2000301")]
	public class MeshBoundaryLoops : IEnumerable<EdgeLoop>, IEnumerable
	{
		// Token: 0x060019E4 RID: 6628 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019E4")]
		[Address(RVA = "0x1F16E90", Offset = "0x1F15490", VA = "0x181F16E90")]
		public MeshBoundaryLoops(DMesh3 mesh, bool bAutoCompute = true)
		{
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x00012D34 File Offset: 0x00010F34
		[Token(Token = "0x170003E4")]
		public int Count
		{
			[Token(Token = "0x60019E5")]
			[Address(RVA = "0x1F16F10", Offset = "0x1F15510", VA = "0x181F16F10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x00012D4C File Offset: 0x00010F4C
		[Token(Token = "0x170003E5")]
		public int SpanCount
		{
			[Token(Token = "0x60019E6")]
			[Address(RVA = "0x1F16F50", Offset = "0x1F15550", VA = "0x181F16F50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003E6 RID: 998
		[Token(Token = "0x170003E6")]
		public EdgeLoop this[int index]
		{
			[Token(Token = "0x60019E7")]
			[Address(RVA = "0x1F16F90", Offset = "0x1F15590", VA = "0x181F16F90")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60019E8")]
		[Address(RVA = "0x1F17000", Offset = "0x1F15600", VA = "0x181F17000", Slot = "4")]
		public IEnumerator<EdgeLoop> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60019E9")]
		[Address(RVA = "0x1F170E0", Offset = "0x1F156E0", VA = "0x181F170E0", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x00012D64 File Offset: 0x00010F64
		[Token(Token = "0x170003E7")]
		public int MaxVerticesLoopIndex
		{
			[Token(Token = "0x60019EA")]
			[Address(RVA = "0x1F171C0", Offset = "0x1F157C0", VA = "0x181F171C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x00012D7C File Offset: 0x00010F7C
		[Token(Token = "0x60019EB")]
		[Address(RVA = "0x1F17290", Offset = "0x1F15890", VA = "0x181F17290")]
		public Index2i FindVertexIndex(int vID)
		{
			return default(Index2i);
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x00012D94 File Offset: 0x00010F94
		[Token(Token = "0x60019EC")]
		[Address(RVA = "0x1F173B0", Offset = "0x1F159B0", VA = "0x181F173B0")]
		public int FindLoopContainingVertex(int vid)
		{
			return 0;
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x00012DAC File Offset: 0x00010FAC
		[Token(Token = "0x60019ED")]
		[Address(RVA = "0x1F17480", Offset = "0x1F15A80", VA = "0x181F17480")]
		public int FindLoopContainingEdge(int eid)
		{
			return 0;
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x00012DC4 File Offset: 0x00010FC4
		[Token(Token = "0x60019EE")]
		[Address(RVA = "0x1F17550", Offset = "0x1F15B50", VA = "0x181F17550")]
		public bool Compute()
		{
			return default(bool);
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x00012DDC File Offset: 0x00010FDC
		[Token(Token = "0x60019EF")]
		[Address(RVA = "0x1F18530", Offset = "0x1F16B30", VA = "0x181F18530")]
		private Vector3d get_vtx_normal(int vid)
		{
			return default(Vector3d);
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00012DF4 File Offset: 0x00010FF4
		[Token(Token = "0x60019F0")]
		[Address(RVA = "0x1F18840", Offset = "0x1F16E40", VA = "0x181F18840")]
		private int find_left_turn_edge(int incoming_e, int bowtie_v, int[] bdry_edges, int bdry_edges_count, BitArray used_edges)
		{
			return 0;
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x00012E0C File Offset: 0x0001100C
		[Token(Token = "0x60019F1")]
		[Address(RVA = "0x1F18C60", Offset = "0x1F17260", VA = "0x181F18C60")]
		private MeshBoundaryLoops.Subloops extract_subloops(List<int> loopV, List<int> loopE, List<int> bowties)
		{
			return default(MeshBoundaryLoops.Subloops);
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00012E24 File Offset: 0x00011024
		[Token(Token = "0x60019F2")]
		[Address(RVA = "0x1F19A60", Offset = "0x1F18060", VA = "0x181F19A60")]
		private bool is_simple_bowtie_loop(List<int> loopV, List<int> bowties, int bowtieV, out int start_i, out int end_i)
		{
			return default(bool);
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x00012E3C File Offset: 0x0001103C
		[Token(Token = "0x60019F3")]
		[Address(RVA = "0x1F19C90", Offset = "0x1F18290", VA = "0x181F19C90")]
		private bool is_simple_path(List<int> loopV, List<int> bowties, int bowtieV, int i1, int i2)
		{
			return default(bool);
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60019F4")]
		[Address(RVA = "0x1F19D80", Offset = "0x1F18380", VA = "0x181F19D80")]
		private int[] extract_span(List<int> loop, int i0, int i1, bool bMarkInvalid)
		{
			return null;
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x00012E54 File Offset: 0x00011054
		[Token(Token = "0x60019F5")]
		[Address(RVA = "0x1F19EF0", Offset = "0x1F184F0", VA = "0x181F19EF0")]
		private int count_span(List<int> l, int i0, int i1)
		{
			return 0;
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x00012E6C File Offset: 0x0001106C
		[Token(Token = "0x60019F6")]
		[Address(RVA = "0x1F19FA0", Offset = "0x1F185A0", VA = "0x181F19FA0")]
		private int find_index(List<int> loop, int start, int item)
		{
			return 0;
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x00012E84 File Offset: 0x00011084
		[Token(Token = "0x60019F7")]
		[Address(RVA = "0x1F1A050", Offset = "0x1F18650", VA = "0x181F1A050")]
		private int count_in_list(List<int> loop, int item)
		{
			return 0;
		}

		// Token: 0x04000DB1 RID: 3505
		[Token(Token = "0x4000DB1")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000DB2 RID: 3506
		[Token(Token = "0x4000DB2")]
		[FieldOffset(Offset = "0x18")]
		public List<EdgeLoop> Loops;

		// Token: 0x04000DB3 RID: 3507
		[Token(Token = "0x4000DB3")]
		[FieldOffset(Offset = "0x20")]
		public List<EdgeSpan> Spans;

		// Token: 0x04000DB4 RID: 3508
		[Token(Token = "0x4000DB4")]
		[FieldOffset(Offset = "0x28")]
		public bool SawOpenSpans;

		// Token: 0x04000DB5 RID: 3509
		[Token(Token = "0x4000DB5")]
		[FieldOffset(Offset = "0x29")]
		public bool FellBackToSpansOnFailure;

		// Token: 0x04000DB6 RID: 3510
		[Token(Token = "0x4000DB6")]
		[FieldOffset(Offset = "0x2C")]
		public MeshBoundaryLoops.SpanBehaviors SpanBehavior;

		// Token: 0x04000DB7 RID: 3511
		[Token(Token = "0x4000DB7")]
		[FieldOffset(Offset = "0x30")]
		public MeshBoundaryLoops.FailureBehaviors FailureBehavior;

		// Token: 0x04000DB8 RID: 3512
		[Token(Token = "0x4000DB8")]
		[FieldOffset(Offset = "0x38")]
		public Func<int, bool> EdgeFilterF;

		// Token: 0x04000DB9 RID: 3513
		[Token(Token = "0x4000DB9")]
		[FieldOffset(Offset = "0x40")]
		public List<int> FailureBowties;

		// Token: 0x02000302 RID: 770
		[Token(Token = "0x2000302")]
		public enum SpanBehaviors
		{
			// Token: 0x04000DBB RID: 3515
			[Token(Token = "0x4000DBB")]
			Ignore,
			// Token: 0x04000DBC RID: 3516
			[Token(Token = "0x4000DBC")]
			ThrowException,
			// Token: 0x04000DBD RID: 3517
			[Token(Token = "0x4000DBD")]
			Compute
		}

		// Token: 0x02000303 RID: 771
		[Token(Token = "0x2000303")]
		public enum FailureBehaviors
		{
			// Token: 0x04000DBF RID: 3519
			[Token(Token = "0x4000DBF")]
			ThrowException,
			// Token: 0x04000DC0 RID: 3520
			[Token(Token = "0x4000DC0")]
			ConvertToOpenSpan
		}

		// Token: 0x02000304 RID: 772
		[Token(Token = "0x2000304")]
		private struct Subloops
		{
			// Token: 0x04000DC1 RID: 3521
			[Token(Token = "0x4000DC1")]
			[FieldOffset(Offset = "0x0")]
			public List<EdgeLoop> Loops;

			// Token: 0x04000DC2 RID: 3522
			[Token(Token = "0x4000DC2")]
			[FieldOffset(Offset = "0x8")]
			public List<EdgeSpan> Spans;
		}
	}
}
