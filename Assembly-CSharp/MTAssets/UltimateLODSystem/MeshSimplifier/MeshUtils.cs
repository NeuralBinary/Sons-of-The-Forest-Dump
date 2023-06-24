using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace MTAssets.UltimateLODSystem.MeshSimplifier
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	public static class MeshUtils
	{
		// Token: 0x06000217 RID: 535 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x60B020", Offset = "0x609620", VA = "0x18060B020")]
		public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector2>[] uvs, Matrix4x4[] bindposes, BlendShape[] blendShapes)
		{
			return null;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x60B0F0", Offset = "0x6096F0", VA = "0x18060B0F0")]
		public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector4>[] uvs, Matrix4x4[] bindposes, BlendShape[] blendShapes)
		{
			return null;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x60B1C0", Offset = "0x6097C0", VA = "0x18060B1C0")]
		public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, Color[] colors, BoneWeight[] boneWeights, List<Vector2>[] uvs2D, List<Vector3>[] uvs3D, List<Vector4>[] uvs4D, Matrix4x4[] bindposes, BlendShape[] blendShapes)
		{
			return null;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x60B5E0", Offset = "0x609BE0", VA = "0x18060B5E0")]
		public static BlendShape[] GetMeshBlendShapes(Mesh mesh)
		{
			return null;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x60BAD0", Offset = "0x60A0D0", VA = "0x18060BAD0")]
		public static void ApplyMeshBlendShapes(Mesh mesh, BlendShape[] blendShapes)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x60BCF0", Offset = "0x60A2F0", VA = "0x18060BCF0")]
		public static IList<Vector4>[] GetMeshUVs(Mesh mesh)
		{
			return null;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x60BFE0", Offset = "0x60A5E0", VA = "0x18060BFE0")]
		public static IList<Vector2> GetMeshUVs2D(Mesh mesh, int channel)
		{
			return null;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x60C1E0", Offset = "0x60A7E0", VA = "0x18060C1E0")]
		public static IList<Vector3> GetMeshUVs3D(Mesh mesh, int channel)
		{
			return null;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x60C520", Offset = "0x60AB20", VA = "0x18060C520")]
		public static IList<Vector4> GetMeshUVs(Mesh mesh, int channel)
		{
			return null;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x60C720", Offset = "0x60AD20", VA = "0x18060C720")]
		public static int GetUsedUVComponents(IList<Vector4> uvs)
		{
			return 0;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x60C9C0", Offset = "0x60AFC0", VA = "0x18060C9C0")]
		public static Vector2[] ConvertUVsTo2D(IList<Vector4> uvs)
		{
			return null;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x60CB20", Offset = "0x60B120", VA = "0x18060CB20")]
		public static Vector3[] ConvertUVsTo3D(IList<Vector4> uvs)
		{
			return null;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x60CCA0", Offset = "0x60B2A0", VA = "0x18060CCA0")]
		private static void GetIndexMinMax(int[] indices, out int minIndex, out int maxIndex)
		{
		}

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int UVChannelCount;
	}
}
