using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	public class DijkstraGraphDistance
	{
		// Token: 0x060001E3 RID: 483 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1F3A690", Offset = "0x1F38C90", VA = "0x181F3A690")]
		public DijkstraGraphDistance(int nMaxID, bool bSparse, Func<int, bool> nodeFilterF, Func<int, int, float> nodeDistanceF, Func<int, IEnumerable<int>> neighboursF, [Optional] IEnumerable<Vector2d> seeds)
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1F3AD80", Offset = "0x1F39380", VA = "0x181F3AD80")]
		public static DijkstraGraphDistance MeshVertices(DMesh3 mesh, bool bSparse = false)
		{
			return null;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1F3B190", Offset = "0x1F39790", VA = "0x181F3B190")]
		public static DijkstraGraphDistance MeshTriangles(DMesh3 mesh, bool bSparse = false)
		{
			return null;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1F3B570", Offset = "0x1F39B70", VA = "0x181F3B570")]
		public void Reset()
		{
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1F3B740", Offset = "0x1F39D40", VA = "0x181F3B740")]
		public void AddSeed(int id, float seed_dist)
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000311C File Offset: 0x0000131C
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1F3B840", Offset = "0x1F39E40", VA = "0x181F3B840")]
		public bool IsSeed(int id)
		{
			return default(bool);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1F3B8E0", Offset = "0x1F39EE0", VA = "0x181F3B8E0")]
		public void Compute()
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1F3BAC0", Offset = "0x1F3A0C0", VA = "0x181F3BAC0")]
		protected void Compute_Sparse()
		{
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1F3BBF0", Offset = "0x1F3A1F0", VA = "0x181F3BBF0")]
		protected void Compute_Dense()
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1F3BE00", Offset = "0x1F3A400", VA = "0x181F3BE00")]
		public void ComputeToMaxDistance(float fMaxDistance)
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1F3C170", Offset = "0x1F3A770", VA = "0x181F3C170")]
		protected void ComputeToMaxDistance_Sparse(float fMaxDistance)
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1F3C2C0", Offset = "0x1F3A8C0", VA = "0x181F3C2C0")]
		protected void ComputeToMaxDistance_Dense(float fMaxDistance)
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1F3C470", Offset = "0x1F3AA70", VA = "0x181F3C470")]
		public void ComputeToNode(int node_id, float fMaxDistance = 3.4028235E+38f)
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1F3C7F0", Offset = "0x1F3ADF0", VA = "0x181F3C7F0")]
		protected void ComputeToNode_Sparse(int node_id, float fMaxDistance)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1F3C950", Offset = "0x1F3AF50", VA = "0x181F3C950")]
		protected void ComputeToNode_Dense(int node_id, float fMaxDistance)
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00003134 File Offset: 0x00001334
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1F3CB10", Offset = "0x1F3B110", VA = "0x181F3CB10")]
		public int ComputeToNode(Func<int, bool> terminatingNodeF, float fMaxDistance = 3.4028235E+38f)
		{
			return 0;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000314C File Offset: 0x0000134C
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1F3CD40", Offset = "0x1F3B340", VA = "0x181F3CD40")]
		protected int ComputeToNode_Sparse(Func<int, bool> terminatingNodeF, float fMaxDistance)
		{
			return 0;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00003164 File Offset: 0x00001364
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1F3CEC0", Offset = "0x1F3B4C0", VA = "0x181F3CEC0")]
		protected int ComputeToNode_Dense(Func<int, bool> terminatingNodeF, float fMaxDistance)
		{
			return 0;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0000317C File Offset: 0x0000137C
		[Token(Token = "0x17000024")]
		public float MaxDistance
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x1F3D0A0", Offset = "0x1F3B6A0", VA = "0x181F3D0A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00003194 File Offset: 0x00001394
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1F3D0B0", Offset = "0x1F3B6B0", VA = "0x181F3D0B0")]
		public float GetDistance(int id)
		{
			return 0f;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1F3D170", Offset = "0x1F3B770", VA = "0x181F3D170")]
		public List<int> GetOrder()
		{
			return null;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000031AC File Offset: 0x000013AC
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1F3D1E0", Offset = "0x1F3B7E0", VA = "0x181F3D1E0")]
		public bool GetPathToSeed(int fromv, List<int> path)
		{
			return default(bool);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1F3D3F0", Offset = "0x1F3B9F0", VA = "0x181F3D3F0")]
		private DijkstraGraphDistance.GraphNode get_node(int id)
		{
			return null;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1F3D570", Offset = "0x1F3BB70", VA = "0x181F3D570")]
		private void update_neighbours_sparse(DijkstraGraphDistance.GraphNode parent)
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1F3D950", Offset = "0x1F3BF50", VA = "0x181F3D950")]
		private void enqueue_node_dense(int id, float dist, int parent_id)
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1F3D9D0", Offset = "0x1F3BFD0", VA = "0x181F3D9D0")]
		private void update_neighbours_dense(int parent_id)
		{
		}

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		public const float InvalidValue = 3.4028235E+38f;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool TrackOrder;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DynamicPriorityQueue<DijkstraGraphDistance.GraphNode> SparseQueue;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SparseObjectList<DijkstraGraphDistance.GraphNode> SparseNodes;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MemoryPool<DijkstraGraphDistance.GraphNode> SparseNodePool;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IndexPriorityQueue DenseQueue;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DijkstraGraphDistance.GraphNodeStruct[] DenseNodes;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Func<int, bool> NodeFilterF;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Func<int, int, float> NodeDistanceF;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Func<int, IEnumerable<int>> NeighboursF;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> Seeds;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float max_value;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<int> order;

		// Token: 0x02000067 RID: 103
		[Token(Token = "0x2000067")]
		private class GraphNode : DynamicPriorityQueueNode, IEquatable<DijkstraGraphDistance.GraphNode>
		{
			// Token: 0x060001FD RID: 509 RVA: 0x000031C4 File Offset: 0x000013C4
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x1F07270", Offset = "0x1F05870", VA = "0x181F07270", Slot = "4")]
			public bool Equals(DijkstraGraphDistance.GraphNode other)
			{
				return default(bool);
			}

			// Token: 0x060001FE RID: 510 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public GraphNode()
			{
			}

			// Token: 0x040001FB RID: 507
			[Token(Token = "0x40001FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int id;

			// Token: 0x040001FC RID: 508
			[Token(Token = "0x40001FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DijkstraGraphDistance.GraphNode parent;

			// Token: 0x040001FD RID: 509
			[Token(Token = "0x40001FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool frozen;
		}

		// Token: 0x02000068 RID: 104
		[Token(Token = "0x2000068")]
		private struct GraphNodeStruct : IEquatable<DijkstraGraphDistance.GraphNodeStruct>
		{
			// Token: 0x060001FF RID: 511 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x1F3DD40", Offset = "0x1F3C340", VA = "0x181F3DD40")]
			public GraphNodeStruct(int id, int parent, float distance)
			{
			}

			// Token: 0x06000200 RID: 512 RVA: 0x000031DC File Offset: 0x000013DC
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x60E0F0", Offset = "0x60C6F0", VA = "0x18060E0F0", Slot = "4")]
			public bool Equals(DijkstraGraphDistance.GraphNodeStruct other)
			{
				return default(bool);
			}

			// Token: 0x040001FE RID: 510
			[Token(Token = "0x40001FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int id;

			// Token: 0x040001FF RID: 511
			[Token(Token = "0x40001FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int parent;

			// Token: 0x04000200 RID: 512
			[Token(Token = "0x4000200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool frozen;

			// Token: 0x04000201 RID: 513
			[Token(Token = "0x4000201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float distance;

			// Token: 0x04000202 RID: 514
			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly DijkstraGraphDistance.GraphNodeStruct Zero;
		}
	}
}
