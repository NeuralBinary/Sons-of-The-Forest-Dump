using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000255 RID: 597
	[Token(Token = "0x2000255")]
	public class MeshDecomposition
	{
		// Token: 0x17000359 RID: 857
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x000104B4 File Offset: 0x0000E6B4
		// (set) Token: 0x0600152D RID: 5421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000359")]
		public int MaxComponentSize
		{
			[Token(Token = "0x600152E")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600152D")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x0600152F RID: 5423 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700035A")]
		public IMeshComponentManager Manager
		{
			[Token(Token = "0x6001530")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600152F")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001531")]
		[Address(RVA = "0x1E8FE00", Offset = "0x1E8E400", VA = "0x181E8FE00")]
		public MeshDecomposition(DMesh3 mesh, IMeshComponentManager manager)
		{
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001532")]
		[Address(RVA = "0x1E8FEC0", Offset = "0x1E8E4C0", VA = "0x181E8FEC0")]
		public void BuildLinear()
		{
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001533")]
		[Address(RVA = "0x1E90660", Offset = "0x1E8EC60", VA = "0x181E90660")]
		private int[] get_tri_order_by_axis_sort()
		{
			return null;
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x000104CC File Offset: 0x0000E6CC
		[Token(Token = "0x6001534")]
		[Address(RVA = "0x1E90B40", Offset = "0x1E8F140", VA = "0x181E90B40")]
		private MeshDecomposition.Component extract_submesh(int submesh_index, int[] subt, int Nt, int[] mapToCur, int[] subv, out Index2i mapRange, out int max_subv)
		{
			return default(MeshDecomposition.Component);
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001535")]
		[Address(RVA = "0x1E90FB0", Offset = "0x1E8F5B0", VA = "0x181E90FB0")]
		private void add_submesh_mapv(int orig_vid, int submesh_i, int submesh_vid)
		{
		}

		// Token: 0x040009DB RID: 2523
		[Token(Token = "0x40009DB")]
		[FieldOffset(Offset = "0x10")]
		private DMesh3 mesh;

		// Token: 0x040009DD RID: 2525
		[Token(Token = "0x40009DD")]
		[FieldOffset(Offset = "0x1C")]
		public bool TrackVertexMapping;

		// Token: 0x040009DE RID: 2526
		[Token(Token = "0x40009DE")]
		[FieldOffset(Offset = "0x20")]
		private Index2i[] mapTo;

		// Token: 0x040009DF RID: 2527
		[Token(Token = "0x40009DF")]
		[FieldOffset(Offset = "0x28")]
		private DVector<int> mapToMulti;

		// Token: 0x02000256 RID: 598
		[Token(Token = "0x2000256")]
		public struct Component
		{
			// Token: 0x040009E1 RID: 2529
			[Token(Token = "0x40009E1")]
			[FieldOffset(Offset = "0x0")]
			public int id;

			// Token: 0x040009E2 RID: 2530
			[Token(Token = "0x40009E2")]
			[FieldOffset(Offset = "0x8")]
			public int[] triangles;

			// Token: 0x040009E3 RID: 2531
			[Token(Token = "0x40009E3")]
			[FieldOffset(Offset = "0x10")]
			public int tri_count;

			// Token: 0x040009E4 RID: 2532
			[Token(Token = "0x40009E4")]
			[FieldOffset(Offset = "0x18")]
			public int[] source_vertices;
		}
	}
}
