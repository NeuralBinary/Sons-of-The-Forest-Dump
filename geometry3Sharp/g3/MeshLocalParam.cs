using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002E7 RID: 743
	[Token(Token = "0x20002E7")]
	public class MeshLocalParam
	{
		// Token: 0x06001963 RID: 6499 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001963")]
		[Address(RVA = "0x1F04FC0", Offset = "0x1F035C0", VA = "0x181F04FC0")]
		public MeshLocalParam(int nMaxID, Func<int, Vector3f> nodePositionF, Func<int, Vector3f> nodeNormalF, Func<int, IEnumerable<int>> neighboursF)
		{
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001964")]
		[Address(RVA = "0x1F052C0", Offset = "0x1F038C0", VA = "0x181F052C0")]
		public void Reset()
		{
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001965")]
		[Address(RVA = "0x1F05380", Offset = "0x1F03980", VA = "0x181F05380")]
		public void ComputeToMaxDistance(Frame3f seedFrame, Index3i seedNbrs, float fMaxGraphDistance)
		{
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001966")]
		[Address(RVA = "0x1F056E0", Offset = "0x1F03CE0", VA = "0x181F056E0")]
		public void TransformUV(float fScale, Vector2f vTranslate)
		{
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001967 RID: 6503 RVA: 0x0001289C File Offset: 0x00010A9C
		[Token(Token = "0x170003DE")]
		public float MaxGraphDistance
		{
			[Token(Token = "0x6001967")]
			[Address(RVA = "0x1F05980", Offset = "0x1F03F80", VA = "0x181F05980")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x000128B4 File Offset: 0x00010AB4
		[Token(Token = "0x170003DF")]
		public float MaxUVDistance
		{
			[Token(Token = "0x6001968")]
			[Address(RVA = "0xA53160", Offset = "0xA51760", VA = "0x180A53160")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x000128CC File Offset: 0x00010ACC
		[Token(Token = "0x6001969")]
		[Address(RVA = "0x1F05990", Offset = "0x1F03F90", VA = "0x181F05990")]
		public Vector2f GetUV(int id)
		{
			return default(Vector2f);
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600196A")]
		[Address(RVA = "0x1F05A50", Offset = "0x1F04050", VA = "0x181F05A50")]
		public void ApplyUVs(Action<int, Vector2f> applyF)
		{
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x000128E4 File Offset: 0x00010AE4
		[Token(Token = "0x600196B")]
		[Address(RVA = "0x1F05C90", Offset = "0x1F04290", VA = "0x181F05C90")]
		private Vector2f compute_local_uv(ref Frame3f f, Vector3f pos)
		{
			return default(Vector2f);
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x000128FC File Offset: 0x00010AFC
		[Token(Token = "0x600196C")]
		[Address(RVA = "0x1F05E70", Offset = "0x1F04470", VA = "0x181F05E70")]
		private Vector2f propagate_uv(Vector3f pos, Vector2f nbrUV, ref Frame3f fNbr, ref Frame3f fSeed)
		{
			return default(Vector2f);
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600196D")]
		[Address(RVA = "0x1F063E0", Offset = "0x1F049E0", VA = "0x181F063E0")]
		private void update_uv_expmap(MeshLocalParam.GraphNode node)
		{
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600196E")]
		[Address(RVA = "0x1F06610", Offset = "0x1F04C10", VA = "0x181F06610")]
		private void update_uv_upwind_expmap(MeshLocalParam.GraphNode node)
		{
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600196F")]
		[Address(RVA = "0x1F06BE0", Offset = "0x1F051E0", VA = "0x181F06BE0")]
		private void update_uv_planar(MeshLocalParam.GraphNode g)
		{
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001970")]
		[Address(RVA = "0x1F06C70", Offset = "0x1F05270", VA = "0x181F06C70")]
		private MeshLocalParam.GraphNode get_node(int id, bool bCreateIfMissing = true)
		{
			return null;
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001971")]
		[Address(RVA = "0x1F06E40", Offset = "0x1F05440", VA = "0x181F06E40")]
		private void update_neighbours_sparse(MeshLocalParam.GraphNode parent)
		{
		}

		// Token: 0x04000D21 RID: 3361
		[Token(Token = "0x4000D21")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector2f InvalidUV;

		// Token: 0x04000D22 RID: 3362
		[Token(Token = "0x4000D22")]
		[FieldOffset(Offset = "0x10")]
		public MeshLocalParam.UVModes UVMode;

		// Token: 0x04000D23 RID: 3363
		[Token(Token = "0x4000D23")]
		[FieldOffset(Offset = "0x18")]
		private DynamicPriorityQueue<MeshLocalParam.GraphNode> SparseQueue;

		// Token: 0x04000D24 RID: 3364
		[Token(Token = "0x4000D24")]
		[FieldOffset(Offset = "0x20")]
		private SparseObjectList<MeshLocalParam.GraphNode> SparseNodes;

		// Token: 0x04000D25 RID: 3365
		[Token(Token = "0x4000D25")]
		[FieldOffset(Offset = "0x28")]
		private MemoryPool<MeshLocalParam.GraphNode> SparseNodePool;

		// Token: 0x04000D26 RID: 3366
		[Token(Token = "0x4000D26")]
		[FieldOffset(Offset = "0x30")]
		private Func<int, Vector3f> PositionF;

		// Token: 0x04000D27 RID: 3367
		[Token(Token = "0x4000D27")]
		[FieldOffset(Offset = "0x38")]
		private Func<int, Vector3f> NormalF;

		// Token: 0x04000D28 RID: 3368
		[Token(Token = "0x4000D28")]
		[FieldOffset(Offset = "0x40")]
		private Func<int, IEnumerable<int>> NeighboursF;

		// Token: 0x04000D29 RID: 3369
		[Token(Token = "0x4000D29")]
		[FieldOffset(Offset = "0x48")]
		private Frame3f SeedFrame;

		// Token: 0x04000D2A RID: 3370
		[Token(Token = "0x4000D2A")]
		[FieldOffset(Offset = "0x64")]
		private float max_graph_distance;

		// Token: 0x04000D2B RID: 3371
		[Token(Token = "0x4000D2B")]
		[FieldOffset(Offset = "0x68")]
		private float max_uv_distance;

		// Token: 0x020002E8 RID: 744
		[Token(Token = "0x20002E8")]
		public enum UVModes
		{
			// Token: 0x04000D2D RID: 3373
			[Token(Token = "0x4000D2D")]
			ExponentialMap,
			// Token: 0x04000D2E RID: 3374
			[Token(Token = "0x4000D2E")]
			ExponentialMap_UpwindAvg,
			// Token: 0x04000D2F RID: 3375
			[Token(Token = "0x4000D2F")]
			PlanarProjection
		}

		// Token: 0x020002E9 RID: 745
		[Token(Token = "0x20002E9")]
		private class GraphNode : DynamicPriorityQueueNode, IEquatable<MeshLocalParam.GraphNode>
		{
			// Token: 0x06001973 RID: 6515 RVA: 0x00012914 File Offset: 0x00010B14
			[Token(Token = "0x6001973")]
			[Address(RVA = "0x1F07270", Offset = "0x1F05870", VA = "0x181F07270", Slot = "4")]
			public bool Equals(MeshLocalParam.GraphNode other)
			{
				return default(bool);
			}

			// Token: 0x06001974 RID: 6516 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001974")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public GraphNode()
			{
			}

			// Token: 0x04000D30 RID: 3376
			[Token(Token = "0x4000D30")]
			[FieldOffset(Offset = "0x18")]
			public int id;

			// Token: 0x04000D31 RID: 3377
			[Token(Token = "0x4000D31")]
			[FieldOffset(Offset = "0x20")]
			public MeshLocalParam.GraphNode parent;

			// Token: 0x04000D32 RID: 3378
			[Token(Token = "0x4000D32")]
			[FieldOffset(Offset = "0x28")]
			public float graph_distance;

			// Token: 0x04000D33 RID: 3379
			[Token(Token = "0x4000D33")]
			[FieldOffset(Offset = "0x2C")]
			public Vector2f uv;

			// Token: 0x04000D34 RID: 3380
			[Token(Token = "0x4000D34")]
			[FieldOffset(Offset = "0x34")]
			public bool frozen;
		}
	}
}
