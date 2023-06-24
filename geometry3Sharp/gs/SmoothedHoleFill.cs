using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using g3;
using Il2CppDummyDll;

namespace gs
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	public class SmoothedHoleFill
	{
		// Token: 0x060000CB RID: 203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1E114A0", Offset = "0x1E0FAA0", VA = "0x181E114A0")]
		public SmoothedHoleFill(DMesh3 mesh, [Optional] EdgeLoop fillLoop)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002774 File Offset: 0x00000974
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1E11600", Offset = "0x1E0FC00", VA = "0x181E11600")]
		public bool Apply()
		{
			return default(bool);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1E11CB0", Offset = "0x1E102B0", VA = "0x181E11CB0")]
		private void smooth_and_remesh_preserve(MeshFaceSelection tris, bool bFinal)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1E11F30", Offset = "0x1E10530", VA = "0x181E11F30")]
		private void smooth_and_remesh(MeshFaceSelection tris)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1E12230", Offset = "0x1E10830", VA = "0x181E12230")]
		private EdgeLoop select_loop_tris_hint(MeshBoundaryLoops loops)
		{
			return null;
		}

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3d OffsetDirection;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public double OffsetDistance;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public double TargetEdgeLength;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public double SmoothAlpha;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int InitialRemeshPasses;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool RemeshBeforeSmooth;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool RemeshAfterSmooth;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Action<Remesher, bool> ConfigureRemesherF;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool EnableLaplacianSmooth;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int SmoothSolveIterations;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool ConstrainToHoleInterior;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public EdgeLoop FillLoop;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<int> BorderHintTris;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int[] FillTriangles;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int[] FillVertices;
	}
}
