using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200026D RID: 621
	[Token(Token = "0x200026D")]
	public class MeshNormals
	{
		// Token: 0x060015EC RID: 5612 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015EC")]
		[Address(RVA = "0x1EA15E0", Offset = "0x1E9FBE0", VA = "0x181EA15E0")]
		public MeshNormals(IMesh mesh, MeshNormals.NormalsTypes eType = MeshNormals.NormalsTypes.Vertex_OneRingFaceAverage_AreaWeighted)
		{
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015ED")]
		[Address(RVA = "0x1EA1820", Offset = "0x1E9FE20", VA = "0x181EA1820")]
		public void Compute()
		{
		}

		// Token: 0x17000373 RID: 883
		[Token(Token = "0x17000373")]
		public Vector3d this[int vid]
		{
			[Token(Token = "0x60015EE")]
			[Address(RVA = "0x1EA1830", Offset = "0x1E9FE30", VA = "0x181EA1830")]
			get
			{
				return default(Vector3d);
			}
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015EF")]
		[Address(RVA = "0x1EA18F0", Offset = "0x1E9FEF0", VA = "0x181EA18F0")]
		public void CopyTo(DMesh3 SetMesh)
		{
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015F0")]
		[Address(RVA = "0x1EA1C10", Offset = "0x1EA0210", VA = "0x181EA1C10")]
		private void Compute_FaceAvg_AreaWeighted()
		{
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60015F1")]
		[Address(RVA = "0x1EA1F00", Offset = "0x1EA0500", VA = "0x181EA1F00")]
		public static void QuickCompute(DMesh3 mesh)
		{
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00010ACC File Offset: 0x0000ECCC
		[Token(Token = "0x60015F2")]
		[Address(RVA = "0x1EA1F80", Offset = "0x1EA0580", VA = "0x181EA1F80")]
		public static Vector3d QuickCompute(DMesh3 mesh, int vid, MeshNormals.NormalsTypes type = MeshNormals.NormalsTypes.Vertex_OneRingFaceAverage_AreaWeighted)
		{
			return default(Vector3d);
		}

		// Token: 0x04000A57 RID: 2647
		[Token(Token = "0x4000A57")]
		[FieldOffset(Offset = "0x10")]
		public IMesh Mesh;

		// Token: 0x04000A58 RID: 2648
		[Token(Token = "0x4000A58")]
		[FieldOffset(Offset = "0x18")]
		public DVector<Vector3d> Normals;

		// Token: 0x04000A59 RID: 2649
		[Token(Token = "0x4000A59")]
		[FieldOffset(Offset = "0x20")]
		public Func<int, Vector3d> VertexF;

		// Token: 0x04000A5A RID: 2650
		[Token(Token = "0x4000A5A")]
		[FieldOffset(Offset = "0x28")]
		public MeshNormals.NormalsTypes NormalType;

		// Token: 0x0200026E RID: 622
		[Token(Token = "0x200026E")]
		public enum NormalsTypes
		{
			// Token: 0x04000A5C RID: 2652
			[Token(Token = "0x4000A5C")]
			Vertex_OneRingFaceAverage_AreaWeighted
		}
	}
}
