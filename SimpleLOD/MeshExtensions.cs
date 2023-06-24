using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace OrbCreationExtensions
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public static class MeshExtensions
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2A7D600", Offset = "0x2A7BC00", VA = "0x182A7D600")]
		public static void RecalculateTangents(this Mesh mesh)
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2A7DEE0", Offset = "0x2A7C4E0", VA = "0x182A7DEE0")]
		public static Mesh ScaledRotatedTranslatedMesh(this Mesh mesh, Vector3 scale, Quaternion rotate, Vector3 translate)
		{
			return null;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2A7E2E0", Offset = "0x2A7C8E0", VA = "0x182A7E2E0")]
		public static bool IsSkinnedMesh(this Mesh mesh)
		{
			return default(bool);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2A7E3F0", Offset = "0x2A7C9F0", VA = "0x182A7E3F0")]
		public static int GetTriangleCount(this Mesh orig)
		{
			return 0;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2A7E430", Offset = "0x2A7CA30", VA = "0x182A7E430")]
		public static Mesh MakeLODMesh(this Mesh orig, float aMaxWeight, bool recalcNormals, float removeSmallParts = 1f, float protectNormals = 1f, float protectUvs = 1f, float protectSubMeshesAndSharpEdges = 1f, float smallTrianglesFirst = 1f)
		{
			return null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2A7E490", Offset = "0x2A7CA90", VA = "0x182A7E490")]
		public static IEnumerator MakeLODMeshInBackground(this Mesh mesh, float maxWeight, bool recalcNormals, float removeSmallParts, Action<Mesh> result)
		{
			return null;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2A7E5C0", Offset = "0x2A7CBC0", VA = "0x182A7E5C0")]
		public static Mesh[] MakeLODMeshes(this Mesh mesh, float[] maxWeights, bool recalcNormals, float removeSmallParts = 1f, float protectNormals = 1f, float protectUvs = 1f, float protectSubMeshesAndSharpEdges = 1f, float smallTrianglesFirst = 1f, int nrOfSteps = 1)
		{
			return null;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2A7E820", Offset = "0x2A7CE20", VA = "0x182A7E820")]
		public static Vector4 GetUvRange(this Mesh mesh)
		{
			return default(Vector4);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2A7E8D0", Offset = "0x2A7CED0", VA = "0x182A7E8D0")]
		public static bool CheckUvsWithin01Range(this Mesh mesh)
		{
			return default(bool);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2A7E950", Offset = "0x2A7CF50", VA = "0x182A7E950")]
		public static void ClampUvs(this Mesh mesh)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2A7EA60", Offset = "0x2A7D060", VA = "0x182A7EA60")]
		public static void WrapUvs(this Mesh mesh)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2A7EB90", Offset = "0x2A7D190", VA = "0x182A7EB90")]
		public static void SetAtlasRectForSubmesh(this Mesh mesh, Rect atlasRect, int submeshIndex)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2A7EE70", Offset = "0x2A7D470", VA = "0x182A7EE70")]
		public static void MergeSubmeshInto(this Mesh mesh, int from, int to)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2A7F380", Offset = "0x2A7D980", VA = "0x182A7F380")]
		public static Mesh CopyAndRemoveSubmeshes(this Mesh orig, int[] submeshesToRemove)
		{
			return null;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2A80000", Offset = "0x2A7E600", VA = "0x182A80000")]
		public static Mesh CopyAndRemoveHiddenTriangles(this Mesh orig, int subMeshIdx, Matrix4x4 localToWorldMatrix, Mesh[] hidingMeshes, int[] hidingSubMeshes, Matrix4x4[] hidingLocalToWorldMatrices, float maxRemoveDistance = 0.01f)
		{
			return null;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2A818E0", Offset = "0x2A7FEE0", VA = "0x182A818E0")]
		private static bool IsTriangleHidden(Vector3 v0, Vector3 v1, Vector3 v2, float maxDistance, List<Vector3> triMinCorners, List<Vector3> triMaxCorners, List<Vector3> hidingVs, List<int> hidingTs)
		{
			return default(bool);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2A81C90", Offset = "0x2A80290", VA = "0x182A81C90")]
		private static bool IsHidden(Vector3 v, Vector3 n, float maxDistance, List<Vector3> hidingVs, List<int> hidingTs, List<int> trianglesToCheck)
		{
			return default(bool);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2A822A0", Offset = "0x2A808A0", VA = "0x182A822A0")]
		private static List<int> GetTrianglesWithinRange(Vector3 v0, Vector3 v1, Vector3 v2, float maxDistance, List<Vector3> triMinCorners, List<Vector3> triMaxCorners)
		{
			return null;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2A6B5D0", Offset = "0x2A69BD0", VA = "0x182A6B5D0")]
		public static float DistanceToPlane(Vector3 fromPos, Vector3 direction, Vector3 pointOnPlane, Vector3 normalPlane)
		{
			return 0f;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2A82570", Offset = "0x2A80B70", VA = "0x182A82570")]
		public static Vector3 GetNormal(Vector3 v0, Vector3 v1, Vector3 v2)
		{
			return default(Vector3);
		}
	}
}
