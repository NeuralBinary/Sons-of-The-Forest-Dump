using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000310 RID: 784
	[Token(Token = "0x2000310")]
	public class MeshRegionBoundaryLoops : IEnumerable<EdgeLoop>, IEnumerable
	{
		// Token: 0x06001A67 RID: 6759 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A67")]
		[Address(RVA = "0x1F26480", Offset = "0x1F24A80", VA = "0x181F26480")]
		public MeshRegionBoundaryLoops(DMesh3 mesh, int[] RegionTris, bool bAutoCompute = true)
		{
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x000130F4 File Offset: 0x000112F4
		[Token(Token = "0x170003F1")]
		public int Count
		{
			[Token(Token = "0x6001A68")]
			[Address(RVA = "0x1F26910", Offset = "0x1F24F10", VA = "0x181F26910")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003F2 RID: 1010
		[Token(Token = "0x170003F2")]
		public EdgeLoop this[int index]
		{
			[Token(Token = "0x6001A69")]
			[Address(RVA = "0x1F26950", Offset = "0x1F24F50", VA = "0x181F26950")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A6A")]
		[Address(RVA = "0x1F269C0", Offset = "0x1F24FC0", VA = "0x181F269C0", Slot = "4")]
		public IEnumerator<EdgeLoop> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A6B")]
		[Address(RVA = "0x1F26AA0", Offset = "0x1F250A0", VA = "0x181F26AA0", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x0001310C File Offset: 0x0001130C
		[Token(Token = "0x170003F3")]
		public int MaxVerticesLoopIndex
		{
			[Token(Token = "0x6001A6C")]
			[Address(RVA = "0x1F26B80", Offset = "0x1F25180", VA = "0x181F26B80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x00013124 File Offset: 0x00011324
		[Token(Token = "0x6001A6D")]
		[Address(RVA = "0x1F26C50", Offset = "0x1F25250", VA = "0x181F26C50")]
		private bool edge_is_boundary(int eid)
		{
			return default(bool);
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x0001313C File Offset: 0x0001133C
		[Token(Token = "0x6001A6E")]
		[Address(RVA = "0x1F26C70", Offset = "0x1F25270", VA = "0x181F26C70")]
		private bool edge_is_boundary(int eid, ref int tid_in, ref int tid_out)
		{
			return default(bool);
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x00013154 File Offset: 0x00011354
		[Token(Token = "0x6001A6F")]
		[Address(RVA = "0x1F26D50", Offset = "0x1F25350", VA = "0x181F26D50")]
		private Index2i get_oriented_edgev(int eID, int tid_in, int tid_out)
		{
			return default(Index2i);
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x0001316C File Offset: 0x0001136C
		[Token(Token = "0x6001A70")]
		[Address(RVA = "0x1F26E20", Offset = "0x1F25420", VA = "0x181F26E20")]
		public int vertex_boundary_edges(int vID, ref int e0, ref int e1)
		{
			return 0;
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x00013184 File Offset: 0x00011384
		[Token(Token = "0x6001A71")]
		[Address(RVA = "0x1F270A0", Offset = "0x1F256A0", VA = "0x181F270A0")]
		public int all_vertex_boundary_edges(int vID, int[] e)
		{
			return 0;
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x0001319C File Offset: 0x0001139C
		[Token(Token = "0x6001A72")]
		[Address(RVA = "0x1F27310", Offset = "0x1F25910", VA = "0x181F27310")]
		public bool Compute()
		{
			return default(bool);
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x000131B4 File Offset: 0x000113B4
		[Token(Token = "0x6001A73")]
		[Address(RVA = "0x1F27B20", Offset = "0x1F26120", VA = "0x181F27B20")]
		private Vector3d get_vtx_normal(int vid)
		{
			return default(Vector3d);
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x000131CC File Offset: 0x000113CC
		[Token(Token = "0x6001A74")]
		[Address(RVA = "0x1F27E30", Offset = "0x1F26430", VA = "0x181F27E30")]
		private int find_left_turn_edge(int incoming_e, int bowtie_v, int[] bdry_edges, int bdry_edges_count, IndexFlagSet used_edges)
		{
			return 0;
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A75")]
		[Address(RVA = "0x1F282D0", Offset = "0x1F268D0", VA = "0x181F282D0")]
		private List<EdgeLoop> extract_subloops(List<int> loopV, List<int> loopE, List<int> bowties)
		{
			return null;
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x000131E4 File Offset: 0x000113E4
		[Token(Token = "0x6001A76")]
		[Address(RVA = "0x1F28EA0", Offset = "0x1F274A0", VA = "0x181F28EA0")]
		private bool is_simple_bowtie_loop(List<int> loopV, List<int> bowties, int bowtieV, out int start_i, out int end_i)
		{
			return default(bool);
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x000131FC File Offset: 0x000113FC
		[Token(Token = "0x6001A77")]
		[Address(RVA = "0x1F290D0", Offset = "0x1F276D0", VA = "0x181F290D0")]
		private bool is_simple_path(List<int> loopV, List<int> bowties, int bowtieV, int i1, int i2)
		{
			return default(bool);
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001A78")]
		[Address(RVA = "0x1F291C0", Offset = "0x1F277C0", VA = "0x181F291C0")]
		private int[] extract_span(List<int> loop, int i0, int i1, bool bMarkInvalid)
		{
			return null;
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x00013214 File Offset: 0x00011414
		[Token(Token = "0x6001A79")]
		[Address(RVA = "0x1F29330", Offset = "0x1F27930", VA = "0x181F29330")]
		private int count_span(List<int> l, int i0, int i1)
		{
			return 0;
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x0001322C File Offset: 0x0001142C
		[Token(Token = "0x6001A7A")]
		[Address(RVA = "0x1F293E0", Offset = "0x1F279E0", VA = "0x181F293E0")]
		private int find_index(List<int> loop, int start, int item)
		{
			return 0;
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x00013244 File Offset: 0x00011444
		[Token(Token = "0x6001A7B")]
		[Address(RVA = "0x1F29490", Offset = "0x1F27A90", VA = "0x181F29490")]
		private int count_in_list(List<int> loop, int item)
		{
			return 0;
		}

		// Token: 0x04000DE3 RID: 3555
		[Token(Token = "0x4000DE3")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000DE4 RID: 3556
		[Token(Token = "0x4000DE4")]
		[FieldOffset(Offset = "0x18")]
		public List<EdgeLoop> Loops;

		// Token: 0x04000DE5 RID: 3557
		[Token(Token = "0x4000DE5")]
		[FieldOffset(Offset = "0x20")]
		private IndexFlagSet triangles;

		// Token: 0x04000DE6 RID: 3558
		[Token(Token = "0x4000DE6")]
		[FieldOffset(Offset = "0x28")]
		private IndexFlagSet edges;
	}
}
