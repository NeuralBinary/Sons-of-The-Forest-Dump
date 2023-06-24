using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000271 RID: 625
	[Token(Token = "0x2000271")]
	public class MeshBoundaryEdgeMidpoints : IPointSet
	{
		// Token: 0x06001601 RID: 5633 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001601")]
		[Address(RVA = "0x1EA2DF0", Offset = "0x1EA13F0", VA = "0x181EA2DF0")]
		public MeshBoundaryEdgeMidpoints(DMesh3 mesh)
		{
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001602 RID: 5634 RVA: 0x00010BBC File Offset: 0x0000EDBC
		[Token(Token = "0x17000379")]
		public int VertexCount
		{
			[Token(Token = "0x6001602")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001603 RID: 5635 RVA: 0x00010BD4 File Offset: 0x0000EDD4
		[Token(Token = "0x1700037A")]
		public int MaxVertexID
		{
			[Token(Token = "0x6001603")]
			[Address(RVA = "0x1EA3000", Offset = "0x1EA1600", VA = "0x181EA3000", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001604 RID: 5636 RVA: 0x00010BEC File Offset: 0x0000EDEC
		[Token(Token = "0x1700037B")]
		public bool HasVertexNormals
		{
			[Token(Token = "0x6001604")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001605 RID: 5637 RVA: 0x00010C04 File Offset: 0x0000EE04
		[Token(Token = "0x1700037C")]
		public bool HasVertexColors
		{
			[Token(Token = "0x6001605")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00010C1C File Offset: 0x0000EE1C
		[Token(Token = "0x6001606")]
		[Address(RVA = "0x1EA3060", Offset = "0x1EA1660", VA = "0x181EA3060", Slot = "8")]
		public Vector3d GetVertex(int i)
		{
			return default(Vector3d);
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00010C34 File Offset: 0x0000EE34
		[Token(Token = "0x6001607")]
		[Address(RVA = "0x1EA30B0", Offset = "0x1EA16B0", VA = "0x181EA30B0", Slot = "9")]
		public Vector3f GetVertexNormal(int i)
		{
			return default(Vector3f);
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00010C4C File Offset: 0x0000EE4C
		[Token(Token = "0x6001608")]
		[Address(RVA = "0x1EA3120", Offset = "0x1EA1720", VA = "0x181EA3120", Slot = "10")]
		public Vector3f GetVertexColor(int i)
		{
			return default(Vector3f);
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00010C64 File Offset: 0x0000EE64
		[Token(Token = "0x6001609")]
		[Address(RVA = "0x1EA3190", Offset = "0x1EA1790", VA = "0x181EA3190", Slot = "11")]
		public bool IsVertex(int vID)
		{
			return default(bool);
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600160A")]
		[Address(RVA = "0x1EA31F0", Offset = "0x1EA17F0", VA = "0x181EA31F0", Slot = "12")]
		public IEnumerable<int> VertexIndices()
		{
			return null;
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x00010C7C File Offset: 0x0000EE7C
		[Token(Token = "0x1700037D")]
		public int Timestamp
		{
			[Token(Token = "0x600160B")]
			[Address(RVA = "0x1EA3210", Offset = "0x1EA1810", VA = "0x181EA3210", Slot = "13")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000A60 RID: 2656
		[Token(Token = "0x4000A60")]
		[FieldOffset(Offset = "0x10")]
		private int num_boundary_edges;

		// Token: 0x04000A61 RID: 2657
		[Token(Token = "0x4000A61")]
		[FieldOffset(Offset = "0x18")]
		public DMesh3 Mesh;
	}
}
