using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000237 RID: 567
	[Token(Token = "0x2000237")]
	public class DSubmesh3
	{
		// Token: 0x06001453 RID: 5203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001453")]
		[Address(RVA = "0x1E80020", Offset = "0x1E7E620", VA = "0x181E80020")]
		public DSubmesh3(DMesh3 mesh, int[] subTriangles)
		{
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001454")]
		[Address(RVA = "0x1E800B0", Offset = "0x1E7E6B0", VA = "0x181E800B0")]
		public DSubmesh3(DMesh3 mesh, IEnumerable<int> subTriangles, int nTriEstimate = 0)
		{
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001455")]
		[Address(RVA = "0x1E80130", Offset = "0x1E7E730", VA = "0x181E80130")]
		public DSubmesh3(DMesh3 mesh)
		{
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001456")]
		[Address(RVA = "0x1E801A0", Offset = "0x1E7E7A0", VA = "0x181E801A0")]
		public void Compute(int[] subTriangles)
		{
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001457")]
		[Address(RVA = "0x1E801C0", Offset = "0x1E7E7C0", VA = "0x181E801C0")]
		public void Compute(IEnumerable<int> subTriangles, int nTriEstimate = 0)
		{
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0000FEFC File Offset: 0x0000E0FC
		[Token(Token = "0x6001458")]
		[Address(RVA = "0x1E801D0", Offset = "0x1E7E7D0", VA = "0x181E801D0")]
		public int MapVertexToSubmesh(int base_vID)
		{
			return 0;
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x0000FF14 File Offset: 0x0000E114
		[Token(Token = "0x6001459")]
		[Address(RVA = "0x1E801F0", Offset = "0x1E7E7F0", VA = "0x181E801F0")]
		public int MapVertexToBaseMesh(int sub_vID)
		{
			return 0;
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x0000FF2C File Offset: 0x0000E12C
		[Token(Token = "0x600145A")]
		[Address(RVA = "0x1E80270", Offset = "0x1E7E870", VA = "0x181E80270")]
		public Index2i MapVerticesToSubmesh(Index2i v)
		{
			return default(Index2i);
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0000FF44 File Offset: 0x0000E144
		[Token(Token = "0x600145B")]
		[Address(RVA = "0x1E802C0", Offset = "0x1E7E8C0", VA = "0x181E802C0")]
		public Index2i MapVerticesToBaseMesh(Index2i v)
		{
			return default(Index2i);
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600145C")]
		[Address(RVA = "0x1E80300", Offset = "0x1E7E900", VA = "0x181E80300")]
		public void MapVerticesToSubmesh(int[] vertices)
		{
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x0000FF5C File Offset: 0x0000E15C
		[Token(Token = "0x600145D")]
		[Address(RVA = "0x1E80420", Offset = "0x1E7EA20", VA = "0x181E80420")]
		public int MapEdgeToSubmesh(int base_eid)
		{
			return 0;
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600145E")]
		[Address(RVA = "0x1E804B0", Offset = "0x1E7EAB0", VA = "0x181E804B0")]
		public void MapEdgesToSubmesh(int[] edges)
		{
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x0000FF74 File Offset: 0x0000E174
		[Token(Token = "0x600145F")]
		[Address(RVA = "0x1E80590", Offset = "0x1E7EB90", VA = "0x181E80590")]
		public int MapEdgeToBaseMesh(int sub_eid)
		{
			return 0;
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x0000FF8C File Offset: 0x0000E18C
		[Token(Token = "0x6001460")]
		[Address(RVA = "0x1E80610", Offset = "0x1E7EC10", VA = "0x181E80610")]
		public int MapTriangleToSubmesh(int base_tID)
		{
			return 0;
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x0000FFA4 File Offset: 0x0000E1A4
		[Token(Token = "0x6001461")]
		[Address(RVA = "0x1E80690", Offset = "0x1E7EC90", VA = "0x181E80690")]
		public int MapTriangleToBaseMesh(int sub_tID)
		{
			return 0;
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001462")]
		[Address(RVA = "0x1E80760", Offset = "0x1E7ED60", VA = "0x181E80760")]
		public void MapTrianglesToSubmesh(int[] triangles)
		{
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001463")]
		[Address(RVA = "0x1E80830", Offset = "0x1E7EE30", VA = "0x181E80830")]
		public void ComputeBoundaryInfo(int[] subTriangles)
		{
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001464")]
		[Address(RVA = "0x1E80850", Offset = "0x1E7EE50", VA = "0x181E80850")]
		public void ComputeBoundaryInfo(IEnumerable<int> triangles, int tri_count_est)
		{
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001465")]
		[Address(RVA = "0x1E81160", Offset = "0x1E7F760", VA = "0x181E81160")]
		private void compute(IEnumerable<int> triangles, int tri_count_est)
		{
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001466")]
		[Address(RVA = "0x1E81A20", Offset = "0x1E80020", VA = "0x181E81A20")]
		public static DMesh3 QuickSubmesh(DMesh3 mesh, int[] triangles)
		{
			return null;
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001467")]
		[Address(RVA = "0x1E81B00", Offset = "0x1E80100", VA = "0x181E81B00")]
		public static DMesh3 QuickSubmesh(DMesh3 mesh, IEnumerable<int> triangles)
		{
			return null;
		}

		// Token: 0x0400097D RID: 2429
		[Token(Token = "0x400097D")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 BaseMesh;

		// Token: 0x0400097E RID: 2430
		[Token(Token = "0x400097E")]
		[FieldOffset(Offset = "0x18")]
		public DMesh3 SubMesh;

		// Token: 0x0400097F RID: 2431
		[Token(Token = "0x400097F")]
		[FieldOffset(Offset = "0x20")]
		public MeshComponents WantComponents;

		// Token: 0x04000980 RID: 2432
		[Token(Token = "0x4000980")]
		[FieldOffset(Offset = "0x24")]
		public bool ComputeTriMaps;

		// Token: 0x04000981 RID: 2433
		[Token(Token = "0x4000981")]
		[FieldOffset(Offset = "0x28")]
		public int OverrideGroupID;

		// Token: 0x04000982 RID: 2434
		[Token(Token = "0x4000982")]
		[FieldOffset(Offset = "0x30")]
		public IndexFlagSet BaseSubmeshV;

		// Token: 0x04000983 RID: 2435
		[Token(Token = "0x4000983")]
		[FieldOffset(Offset = "0x38")]
		public IndexMap BaseToSubV;

		// Token: 0x04000984 RID: 2436
		[Token(Token = "0x4000984")]
		[FieldOffset(Offset = "0x40")]
		public DVector<int> SubToBaseV;

		// Token: 0x04000985 RID: 2437
		[Token(Token = "0x4000985")]
		[FieldOffset(Offset = "0x48")]
		public IndexMap BaseToSubT;

		// Token: 0x04000986 RID: 2438
		[Token(Token = "0x4000986")]
		[FieldOffset(Offset = "0x50")]
		public DVector<int> SubToBaseT;

		// Token: 0x04000987 RID: 2439
		[Token(Token = "0x4000987")]
		[FieldOffset(Offset = "0x58")]
		public IndexHashSet BaseBorderE;

		// Token: 0x04000988 RID: 2440
		[Token(Token = "0x4000988")]
		[FieldOffset(Offset = "0x60")]
		public IndexHashSet BaseBoundaryE;

		// Token: 0x04000989 RID: 2441
		[Token(Token = "0x4000989")]
		[FieldOffset(Offset = "0x68")]
		public IndexHashSet BaseBorderV;
	}
}
