using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200028D RID: 653
	[Token(Token = "0x200028D")]
	public class RegionRemesher : Remesher
	{
		// Token: 0x06001760 RID: 5984 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001760")]
		[Address(RVA = "0x1EC1FD0", Offset = "0x1EC05D0", VA = "0x181EC1FD0")]
		public RegionRemesher(DMesh3 mesh, int[] regionTris)
		{
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001761")]
		[Address(RVA = "0x1EC23A0", Offset = "0x1EC09A0", VA = "0x181EC23A0")]
		public RegionRemesher(DMesh3 mesh, IEnumerable<int> regionTris)
		{
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170003A6")]
		public int[] CurrentBaseTriangles
		{
			[Token(Token = "0x6001762")]
			[Address(RVA = "0x8DF560", Offset = "0x8DDB60", VA = "0x1808DF560")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001763")]
		[Address(RVA = "0x1EC2750", Offset = "0x1EC0D50", VA = "0x181EC2750")]
		public void RepairPossibleNonManifoldEdges()
		{
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001764")]
		[Address(RVA = "0x1EC2B50", Offset = "0x1EC1150", VA = "0x181EC2B50")]
		public void SetSubmeshGroupID(int gid)
		{
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x00011B04 File Offset: 0x0000FD04
		[Token(Token = "0x6001765")]
		[Address(RVA = "0x1EC2B80", Offset = "0x1EC1180", VA = "0x181EC2B80")]
		public bool BackPropropagate(bool bAllowSubmeshRepairs = true)
		{
			return default(bool);
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001766")]
		[Address(RVA = "0x1EC2DA0", Offset = "0x1EC13A0", VA = "0x181EC2DA0")]
		public static RegionRemesher QuickRemesh(DMesh3 mesh, int[] tris, double minEdgeLen, double maxEdgeLen, double smoothSpeed, int rounds, IProjectionTarget target, RegionRemesher.QuickRemeshFlags flags = RegionRemesher.QuickRemeshFlags.PreventNormalFlips)
		{
			return null;
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001767")]
		[Address(RVA = "0x1EC2EE0", Offset = "0x1EC14E0", VA = "0x181EC2EE0")]
		public static RegionRemesher QuickRemesh(DMesh3 mesh, int[] tris, double targetEdgeLen, double smoothSpeed, int rounds, IProjectionTarget target, RegionRemesher.QuickRemeshFlags flags = RegionRemesher.QuickRemeshFlags.PreventNormalFlips)
		{
			return null;
		}

		// Token: 0x04000AFC RID: 2812
		[Token(Token = "0x4000AFC")]
		[FieldOffset(Offset = "0xE8")]
		public DMesh3 BaseMesh;

		// Token: 0x04000AFD RID: 2813
		[Token(Token = "0x4000AFD")]
		[FieldOffset(Offset = "0xF0")]
		public DSubmesh3 Region;

		// Token: 0x04000AFE RID: 2814
		[Token(Token = "0x4000AFE")]
		[FieldOffset(Offset = "0xF8")]
		public IndexMap ReinsertSubToBaseMapV;

		// Token: 0x04000AFF RID: 2815
		[Token(Token = "0x4000AFF")]
		[FieldOffset(Offset = "0x100")]
		public MeshEditor.DuplicateTriBehavior ReinsertDuplicateTriBehavior;

		// Token: 0x04000B00 RID: 2816
		[Token(Token = "0x4000B00")]
		[FieldOffset(Offset = "0x108")]
		private MeshConstraints bdry_constraints;

		// Token: 0x04000B01 RID: 2817
		[Token(Token = "0x4000B01")]
		[FieldOffset(Offset = "0x110")]
		private int[] cur_base_tris;

		// Token: 0x0200028E RID: 654
		[Token(Token = "0x200028E")]
		[Flags]
		public enum QuickRemeshFlags
		{
			// Token: 0x04000B03 RID: 2819
			[Token(Token = "0x4000B03")]
			NoFlags = 0,
			// Token: 0x04000B04 RID: 2820
			[Token(Token = "0x4000B04")]
			PreventNormalFlips = 1
		}
	}
}
