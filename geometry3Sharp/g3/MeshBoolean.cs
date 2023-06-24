using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002D1 RID: 721
	[Token(Token = "0x20002D1")]
	public class MeshBoolean
	{
		// Token: 0x0600190B RID: 6411 RVA: 0x000125CC File Offset: 0x000107CC
		[Token(Token = "0x600190B")]
		[Address(RVA = "0x1EF5C10", Offset = "0x1EF4210", VA = "0x181EF5C10")]
		public bool Compute()
		{
			return default(bool);
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600190C")]
		[Address(RVA = "0x1EF6200", Offset = "0x1EF4800", VA = "0x181EF6200")]
		private void resolve_vtx_pairs()
		{
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600190D")]
		[Address(RVA = "0x1EF6370", Offset = "0x1EF4970", VA = "0x181EF6370")]
		private void split_missing(MeshMeshCut fromOp, MeshMeshCut toOp, DMesh3 fromMesh, DMesh3 toMesh, HashSet<int> fromVerts, HashSet<int> toVerts)
		{
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x000125E4 File Offset: 0x000107E4
		[Token(Token = "0x600190E")]
		[Address(RVA = "0x1EF6960", Offset = "0x1EF4F60", VA = "0x181EF6960")]
		private int find_nearest_vertex(DMesh3 mesh, Vector3d v, HashSet<int> vertices)
		{
			return 0;
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x000125FC File Offset: 0x000107FC
		[Token(Token = "0x600190F")]
		[Address(RVA = "0x1EF6B60", Offset = "0x1EF5160", VA = "0x181EF6B60")]
		private int find_nearest_edge(DMesh3 mesh, Vector3d v, HashSet<int> vertices)
		{
			return 0;
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001910")]
		[Address(RVA = "0x1EF71B0", Offset = "0x1EF57B0", VA = "0x181EF71B0")]
		public MeshBoolean()
		{
		}

		// Token: 0x04000CA0 RID: 3232
		[Token(Token = "0x4000CA0")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Target;

		// Token: 0x04000CA1 RID: 3233
		[Token(Token = "0x4000CA1")]
		[FieldOffset(Offset = "0x18")]
		public DMesh3 Tool;

		// Token: 0x04000CA2 RID: 3234
		[Token(Token = "0x4000CA2")]
		[FieldOffset(Offset = "0x20")]
		public double VertexSnapTol;

		// Token: 0x04000CA3 RID: 3235
		[Token(Token = "0x4000CA3")]
		[FieldOffset(Offset = "0x28")]
		public DMesh3 Result;

		// Token: 0x04000CA4 RID: 3236
		[Token(Token = "0x4000CA4")]
		[FieldOffset(Offset = "0x30")]
		private MeshMeshCut cutTargetOp;

		// Token: 0x04000CA5 RID: 3237
		[Token(Token = "0x4000CA5")]
		[FieldOffset(Offset = "0x38")]
		private MeshMeshCut cutToolOp;

		// Token: 0x04000CA6 RID: 3238
		[Token(Token = "0x4000CA6")]
		[FieldOffset(Offset = "0x40")]
		private DMesh3 cutTargetMesh;

		// Token: 0x04000CA7 RID: 3239
		[Token(Token = "0x4000CA7")]
		[FieldOffset(Offset = "0x48")]
		private DMesh3 cutToolMesh;
	}
}
