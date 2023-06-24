using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002FE RID: 766
	[Token(Token = "0x20002FE")]
	public class RegionOperator
	{
		// Token: 0x060019D8 RID: 6616 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019D8")]
		[Address(RVA = "0x1F15250", Offset = "0x1F13850", VA = "0x181F15250")]
		public RegionOperator(DMesh3 mesh, int[] regionTris, [Optional] Action<DSubmesh3> submeshConfigF)
		{
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019D9")]
		[Address(RVA = "0x1F154E0", Offset = "0x1F13AE0", VA = "0x181F154E0")]
		public RegionOperator(DMesh3 mesh, IEnumerable<int> regionTris, [Optional] Action<DSubmesh3> submeshConfigF)
		{
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170003E3")]
		public int[] CurrentBaseTriangles
		{
			[Token(Token = "0x60019DA")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60019DB")]
		[Address(RVA = "0x1F15790", Offset = "0x1F13D90", VA = "0x181F15790")]
		public HashSet<int> CurrentBaseInteriorVertices()
		{
			return null;
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019DC")]
		[Address(RVA = "0x1F15980", Offset = "0x1F13F80", VA = "0x181F15980")]
		public void RepairPossibleNonManifoldEdges()
		{
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019DD")]
		[Address(RVA = "0x1F15D60", Offset = "0x1F14360", VA = "0x181F15D60")]
		public void SetSubmeshGroupID(int gid)
		{
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x00012CD4 File Offset: 0x00010ED4
		[Token(Token = "0x60019DE")]
		[Address(RVA = "0x1F15D90", Offset = "0x1F14390", VA = "0x181F15D90")]
		public bool BackPropropagate(bool bAllowSubmeshRepairs = true)
		{
			return default(bool);
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x00012CEC File Offset: 0x00010EEC
		[Token(Token = "0x60019DF")]
		[Address(RVA = "0x1F161A0", Offset = "0x1F147A0", VA = "0x181F161A0")]
		public bool BackPropropagateVertices(bool bRecomputeBoundaryNormals = false)
		{
			return default(bool);
		}

		// Token: 0x04000DA4 RID: 3492
		[Token(Token = "0x4000DA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DMesh3 BaseMesh;

		// Token: 0x04000DA5 RID: 3493
		[Token(Token = "0x4000DA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DSubmesh3 Region;

		// Token: 0x04000DA6 RID: 3494
		[Token(Token = "0x4000DA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IndexMap ReinsertSubToBaseMapV;

		// Token: 0x04000DA7 RID: 3495
		[Token(Token = "0x4000DA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IndexMap ReinsertSubToBaseMapT;

		// Token: 0x04000DA8 RID: 3496
		[Token(Token = "0x4000DA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MeshEditor.DuplicateTriBehavior ReinsertDuplicateTriBehavior;

		// Token: 0x04000DA9 RID: 3497
		[Token(Token = "0x4000DA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int[] cur_base_tris;
	}
}
