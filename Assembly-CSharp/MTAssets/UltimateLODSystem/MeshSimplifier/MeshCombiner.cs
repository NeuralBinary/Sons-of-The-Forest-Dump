using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace MTAssets.UltimateLODSystem.MeshSimplifier
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	public static class MeshCombiner
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x5F9F00", Offset = "0x5F8500", VA = "0x1805F9F00")]
		public static Mesh CombineMeshes(Transform rootTransform, MeshRenderer[] renderers, out Material[] resultMaterials)
		{
			return null;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x5FA8E0", Offset = "0x5F8EE0", VA = "0x1805FA8E0")]
		public static Mesh CombineMeshes(Transform rootTransform, SkinnedMeshRenderer[] renderers, out Material[] resultMaterials, out Transform[] resultBones)
		{
			return null;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x5FB140", Offset = "0x5F9740", VA = "0x1805FB140")]
		public static Mesh CombineMeshes(Mesh[] meshes, Matrix4x4[] transforms, Material[][] materials, out Material[] resultMaterials)
		{
			return null;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x5FB260", Offset = "0x5F9860", VA = "0x1805FB260")]
		public static Mesh CombineMeshes(Mesh[] meshes, Matrix4x4[] transforms, Material[][] materials, Transform[][] bones, out Material[] resultMaterials, out Transform[] resultBones)
		{
			return null;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x5FCED0", Offset = "0x5FB4D0", VA = "0x1805FCED0")]
		private static void CopyVertexPositions(ICollection<Vector3> list, Vector3[] arr)
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B6")]
		private static void CopyVertexAttributes<T>(ref List<T> dest, IEnumerable<T> src, int previousVertexCount, int meshVertexCount, int totalVertexCount, T defaultValue)
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60001B7")]
		private static T[] MergeArrays<T>(T[] arr1, T[] arr2)
		{
			return null;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x5FD030", Offset = "0x5FB630", VA = "0x1805FD030")]
		private static void TransformVertices(Vector3[] vertices, ref Matrix4x4 transform)
		{
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x5FD140", Offset = "0x5FB740", VA = "0x1805FD140")]
		private static void TransformNormals(Vector3[] normals, ref Matrix4x4 transform)
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x5FD230", Offset = "0x5FB830", VA = "0x1805FD230")]
		private static void TransformTangents(Vector4[] tangents, ref Matrix4x4 transform)
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x5FD320", Offset = "0x5FB920", VA = "0x1805FD320")]
		private static void RemapBones(BoneWeight[] boneWeights, int[] boneIndices)
		{
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x5FD440", Offset = "0x5FBA40", VA = "0x1805FD440")]
		private static bool CanReadMesh(Mesh mesh)
		{
			return default(bool);
		}
	}
}
