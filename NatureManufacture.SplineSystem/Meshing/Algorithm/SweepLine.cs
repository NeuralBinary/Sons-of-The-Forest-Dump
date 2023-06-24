using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Geometry;
using TriangleNet.Topology;

namespace TriangleNet.Meshing.Algorithm
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	public class SweepLine : ITriangulator
	{
		// Token: 0x060002CC RID: 716 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x24D87B0", Offset = "0x24D6DB0", VA = "0x1824D87B0")]
		private static int randomnation(int choices)
		{
			return 0;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x24D8850", Offset = "0x24D6E50", VA = "0x1824D8850", Slot = "4")]
		public IMesh Triangulate(IList<Vertex> points, Configuration config)
		{
			return null;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x24DA1C0", Offset = "0x24D87C0", VA = "0x1824DA1C0")]
		private void HeapInsert(SweepLine.SweepEvent[] heap, int heapsize, SweepLine.SweepEvent newevent)
		{
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x24DA380", Offset = "0x24D8980", VA = "0x1824DA380")]
		private void Heapify(SweepLine.SweepEvent[] heap, int heapsize, int eventnum)
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x24DA590", Offset = "0x24D8B90", VA = "0x1824DA590")]
		private void HeapDelete(SweepLine.SweepEvent[] heap, int heapsize, int eventnum)
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x24DA780", Offset = "0x24D8D80", VA = "0x1824DA780")]
		private void CreateHeap(out SweepLine.SweepEvent[] eventheap, int size)
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x24DAAD0", Offset = "0x24D90D0", VA = "0x1824DAAD0")]
		private SweepLine.SplayNode Splay(SweepLine.SplayNode splaytree, Point searchpoint, ref Otri searchtri)
		{
			return null;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x24DAF00", Offset = "0x24D9500", VA = "0x1824DAF00")]
		private SweepLine.SplayNode SplayInsert(SweepLine.SplayNode splayroot, Otri newkey, Point searchpoint)
		{
			return null;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x24DB360", Offset = "0x24D9960", VA = "0x1824DB360")]
		private SweepLine.SplayNode FrontLocate(SweepLine.SplayNode splayroot, Otri bottommost, Vertex searchvertex, ref Otri searchtri, ref bool farright)
		{
			return null;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x24DB470", Offset = "0x24D9A70", VA = "0x1824DB470")]
		private SweepLine.SplayNode CircleTopInsert(SweepLine.SplayNode splayroot, Otri newkey, Vertex pa, Vertex pb, Vertex pc, double topy)
		{
			return null;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x24DB630", Offset = "0x24D9C30", VA = "0x1824DB630")]
		private bool RightOfHyperbola(ref Otri fronttri, Point newsite)
		{
			return default(bool);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x24DB820", Offset = "0x24D9E20", VA = "0x1824DB820")]
		private double CircleTop(Vertex pa, Vertex pb, Vertex pc, double ccwabc)
		{
			return 0.0;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x24DB9E0", Offset = "0x24D9FE0", VA = "0x1824DB9E0")]
		private void Check4DeadEvent(ref Otri checktri, SweepLine.SweepEvent[] eventheap, ref int heapsize)
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x24DBAB0", Offset = "0x24DA0B0", VA = "0x1824DBAB0")]
		private int RemoveGhosts(ref Otri startghost)
		{
			return 0;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SweepLine()
		{
		}

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x0")]
		private static int randomseed;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x4")]
		private static int SAMPLERATE;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x10")]
		private IPredicates predicates;

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x18")]
		private Mesh mesh;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x20")]
		private double xminextreme;

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x28")]
		private List<SweepLine.SplayNode> splaynodes;

		// Token: 0x0200005E RID: 94
		[Token(Token = "0x200005E")]
		private class SweepEvent
		{
			// Token: 0x060002DC RID: 732 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public SweepEvent()
			{
			}

			// Token: 0x040002E3 RID: 739
			[Token(Token = "0x40002E3")]
			[FieldOffset(Offset = "0x10")]
			public double xkey;

			// Token: 0x040002E4 RID: 740
			[Token(Token = "0x40002E4")]
			[FieldOffset(Offset = "0x18")]
			public double ykey;

			// Token: 0x040002E5 RID: 741
			[Token(Token = "0x40002E5")]
			[FieldOffset(Offset = "0x20")]
			public Vertex vertexEvent;

			// Token: 0x040002E6 RID: 742
			[Token(Token = "0x40002E6")]
			[FieldOffset(Offset = "0x28")]
			public Otri otriEvent;

			// Token: 0x040002E7 RID: 743
			[Token(Token = "0x40002E7")]
			[FieldOffset(Offset = "0x38")]
			public int heapposition;
		}

		// Token: 0x0200005F RID: 95
		[Token(Token = "0x200005F")]
		private class SweepEventVertex : Vertex
		{
			// Token: 0x060002DD RID: 733 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x24DC180", Offset = "0x24DA780", VA = "0x1824DC180")]
			public SweepEventVertex(SweepLine.SweepEvent e)
			{
			}

			// Token: 0x040002E8 RID: 744
			[Token(Token = "0x40002E8")]
			[FieldOffset(Offset = "0x48")]
			public SweepLine.SweepEvent evt;
		}

		// Token: 0x02000060 RID: 96
		[Token(Token = "0x2000060")]
		private class SplayNode
		{
			// Token: 0x060002DE RID: 734 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public SplayNode()
			{
			}

			// Token: 0x040002E9 RID: 745
			[Token(Token = "0x40002E9")]
			[FieldOffset(Offset = "0x10")]
			public Otri keyedge;

			// Token: 0x040002EA RID: 746
			[Token(Token = "0x40002EA")]
			[FieldOffset(Offset = "0x20")]
			public Vertex keydest;

			// Token: 0x040002EB RID: 747
			[Token(Token = "0x40002EB")]
			[FieldOffset(Offset = "0x28")]
			public SweepLine.SplayNode lchild;

			// Token: 0x040002EC RID: 748
			[Token(Token = "0x40002EC")]
			[FieldOffset(Offset = "0x30")]
			public SweepLine.SplayNode rchild;
		}
	}
}
