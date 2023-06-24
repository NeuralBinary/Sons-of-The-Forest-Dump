using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public static class LODMaker
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2A5DEE0", Offset = "0x2A5C4E0", VA = "0x182A5DEE0")]
	public static Mesh MakeLODMesh(Mesh orig, float aMaxWeight, bool recalcNormals = true, float removeSmallParts = 1f, bool reuseOldMesh = false)
	{
		return null;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2A5DF30", Offset = "0x2A5C530", VA = "0x182A5DF30")]
	public static Mesh MakeLODMesh(Mesh orig, float aMaxWeight, float removeSmallParts, float protectNormals, float protectUvs, float smallTrianglesFirst, float protectSubMeshesAndSharpEdges, bool recalcNormals, bool reuseOldMesh = false)
	{
		return null;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2A5E150", Offset = "0x2A5C750", VA = "0x182A5E150")]
	private static void GetWeights(float aMaxWeight, float removeSmallParts, float protectNormals, float protectUvs, float smallTrianglesFirst, float protectSubMeshesAndSharpEdges, out float sideLengthWeight, out float oldAngleWeight, out float newAngleWeight, out float uvWeight, out float areaDiffWeight, out float normalWeight, out float vertexWeight, out float centerDistanceWeight)
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2A5E220", Offset = "0x2A5C820", VA = "0x182A5E220")]
	public static void MakeLODMeshInBackground(object data)
	{
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2A5F900", Offset = "0x2A5DF00", VA = "0x182A5F900")]
	private static Mesh MakeLODMesh(Mesh orig, float maxWeight, float removeSmallParts, float sideLengthWeight, float oldAngleWeight, float newAngleWeight, float uvWeight, float areaDiffWeight, float normalWeight, float vertexWeight, float centerDistanceWeight, bool recalcNormals, bool reuseOldMesh)
	{
		return null;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2A609B0", Offset = "0x2A5EFB0", VA = "0x182A609B0")]
	private static void MakeLODMesh(Vector3[] vs, Vector3[] ns, Vector2[] uv1s, Vector2[] uv2s, Vector2[] uv3s, Vector2[] uv4s, Color32[] colors32, int[] ts, ref Matrix4x4[] bindposes, BoneWeight[] bws, ref int[] subMeshOffsets, Bounds meshBounds, float maxWeight, float removeSmallParts, float sideLengthWeight, float oldAngleWeight, float newAngleWeight, float uvWeight, float areaDiffWeight, float normalWeight, float vertexWeight, float centerDistanceWeight, out List<Vector3> newVs, out List<Vector3> newNs, out List<Vector2> newUv1s, out List<Vector2> newUv2s, out List<Vector2> newUv3s, out List<Vector2> newUv4s, out List<Color32> newColors32, out List<int> newTs, out List<BoneWeight> newBws)
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002058 File Offset: 0x00000258
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2A63E10", Offset = "0x2A62410", VA = "0x182A63E10")]
	private static bool AnyWeightOK(float[] weights, float aMaxWeight)
	{
		return default(bool);
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2A63E50", Offset = "0x2A62450", VA = "0x182A63E50")]
	private static int[] GetAdjacentTriangles(int[] ts, int tIdx, List<List<int>> trianglesPerVertex, int[] uniqueVs, int[] triangleGroups, List<List<int>> trianglesPerGroup)
	{
		return null;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2A645E0", Offset = "0x2A62BE0", VA = "0x182A645E0")]
	private static void SetTriangleGroup(int tIdx0, int tIdx1, int[] triangleGroups, List<List<int>> trianglesPerGroup)
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2A649B0", Offset = "0x2A62FB0", VA = "0x182A649B0")]
	private static void GetTotalAngleAndCenterDistanceForCorner(int[] ts, Vector3[] vs, int[] movedVs, int vertexIdx, Vector3[] centerDistances, ref float totalAngle, ref Vector3 totalCenterDist)
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2A65070", Offset = "0x2A63670", VA = "0x182A65070")]
	private static void GetTotalAngleAndCenterDistanceForNewCorner(int[] ts, Vector3[] vs, int[] movedVs, int[] uniqueVs, int vertexIdx, int newIdx, Vector3[] centerDistances, float maxWeight, ref float totalAngle, ref Vector3 totalCenterDist, ref bool flipsTriangles)
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2A659F0", Offset = "0x2A63FF0", VA = "0x182A659F0")]
	private static void GetUVStretchAndAreaForCorner(int[] ts, Vector3[] vs, int[] movedVs, int[] uniqueVs, Vector2[] uvs, int cFrom, int cTo, ref float affectedUvAreaDiff, ref float affectedAreaDiff, ref float totalUvAreaDiff, ref float totalAreaDiff)
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002070 File Offset: 0x00000270
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2A66260", Offset = "0x2A64860", VA = "0x182A66260")]
	private static float GetNormalDiffForCorners(Vector3[] ns, int corner1, int corner2)
	{
		return 0f;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2A662F0", Offset = "0x2A648F0", VA = "0x182A662F0")]
	private static void MergeVertices(ref int oldV, int newV, bool[] hasTwinVS, Vector3[] vs, int[] triangles, Vector2[] uv1s, Vector2[] uv2s, Vector2[] uv3s, Vector2[] uv4s, Color32[] colors32, bool[] deletedVertices, int[] movedVs, int[] uniqueVs, int[] movedUv1s, int[] movedUv2s, int[] movedUv3s, int[] movedUv4s, int[] movedColors, List<List<int>> trianglesPerVertex, bool logYN)
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2A66960", Offset = "0x2A64F60", VA = "0x182A66960")]
	private static void MoveVertex(int oldV, int newV, int[] movedVs, int[] uniqueVs, int[] movedUv1s, int[] movedUv2s, int[] movedUv3s, int[] movedUv4s, int[] movedColors)
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2A66AF0", Offset = "0x2A650F0", VA = "0x182A66AF0")]
	private static void FillNewMeshArray(Vector3[] vs, bool[] vdel, int[] movedVs, Vector3[] ns, Vector2[] uv1s, int[] movedUv1s, Vector2[] uv2s, int[] movedUv2s, Vector2[] uv3s, int[] movedUv3s, Vector2[] uv4s, int[] movedUv4s, Color32[] colors32, int[] movedColors, BoneWeight[] bws, List<Vector3> newVs, List<Vector3> newNs, List<Vector2> newUv1s, List<Vector2> newUv2s, List<Vector2> newUv3s, List<Vector2> newUv4s, List<Color32> newColors32, List<BoneWeight> newBws, int[] o2n)
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2A671C0", Offset = "0x2A657C0", VA = "0x182A671C0")]
	private static void FillNewMeshTriangles(int[] oldTriangles, int[] o2n, List<int> newTriangles, int[] subMeshOffsets, int[] triangleGroups, List<int> newTGrps)
	{
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2A67430", Offset = "0x2A65A30", VA = "0x182A67430")]
	public static void RemoveUnusedVertices(List<Vector3> vs, List<Vector3> ns, List<Vector2> uv1s, List<Vector2> uv2s, List<Vector2> uv3s, List<Vector2> uv4s, List<Color32> colors32, List<BoneWeight> bws, List<int> ts)
	{
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2A67A80", Offset = "0x2A66080", VA = "0x182A67A80")]
	public static void RemoveUnusedVertices(List<Vector3> vs, List<Vector3> ns, List<Vector2> uv1s, List<Vector2> uv2s, List<Vector2> uv3s, List<Vector2> uv4s, List<Color32> colors32, List<BoneWeight> bws, List<List<int>> subMeshes)
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2A68290", Offset = "0x2A66890", VA = "0x182A68290")]
	public static void RemoveUnusedVertices(List<Vector3> vs, List<Vector3> ns, List<Vector2> uv1s, List<Vector2> uv2s, List<Vector2> uv3s, List<Vector2> uv4s, List<Color32> colors32, List<BoneWeight> bws, Dictionary<Material, List<int>> subMeshes)
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2A68CA0", Offset = "0x2A672A0", VA = "0x182A68CA0")]
	private static void RemoveEmptyTriangles(List<Vector3> newVs, List<Vector3> newNs, List<Vector2> newUv1s, List<Vector2> newUv2s, List<Vector2> newUv3s, List<Vector2> newUv4s, List<Color32> newColors32, List<int> newTs, List<BoneWeight> newBws, int[] subMeshOffsets, List<int> newTGrps)
	{
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2A69340", Offset = "0x2A67940", VA = "0x182A69340")]
	private static void RemoveMiniTriangleGroups(float removeSmallParts, Vector3 sizeMultiplier, float aMaxWeight, List<Vector3> newVs, List<int> newTs, int[] subMeshOffsets, List<int> newTGrps)
	{
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2A69A10", Offset = "0x2A68010", VA = "0x182A69A10")]
	public static Mesh CreateNewMesh(Vector3[] vs, Vector3[] ns, Vector2[] uv1s, Vector2[] uv2s, Vector2[] uv3s, Vector2[] uv4s, Color32[] colors32, int[] ts, BoneWeight[] bws, Matrix4x4[] bindposes, int[] subMeshOffsets, bool recalcNormals)
	{
		return null;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2A69B10", Offset = "0x2A68110", VA = "0x182A69B10")]
	public static void FillMesh(Mesh mesh, Vector3[] vs, Vector3[] ns, Vector2[] uv1s, Vector2[] uv2s, Vector2[] uv3s, Vector2[] uv4s, Color32[] colors32, int[] ts, BoneWeight[] bws, Matrix4x4[] bindposes, int[] subMeshOffsets, bool recalcNormals)
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002088 File Offset: 0x00000288
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2A6A170", Offset = "0x2A68770", VA = "0x182A6A170")]
	private static float AngleCornerDiff(float angle)
	{
		return 0f;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000020A0 File Offset: 0x000002A0
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2A6A250", Offset = "0x2A68850", VA = "0x182A6A250")]
	private static float AngleDiff(float angle)
	{
		return 0f;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000020B8 File Offset: 0x000002B8
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2A6A2D0", Offset = "0x2A688D0", VA = "0x182A6A2D0")]
	private static float Area(Vector3 p0, Vector3 p1, Vector3 p2)
	{
		return 0f;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2A6A4B0", Offset = "0x2A68AB0", VA = "0x182A6A4B0")]
	private static int GetVertexEqualTo(Vector3 v, List<int> orderedVertices, Vector3[] vs)
	{
		return 0;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2A6A740", Offset = "0x2A68D40", VA = "0x182A6A740")]
	private static List<int> GetVerticesEqualTo(Vector3 v, List<int> orderedVertices, Vector3[] vs)
	{
		return null;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2A6A940", Offset = "0x2A68F40", VA = "0x182A6A940")]
	private static List<int> GetVerticesWithinBox(Vector3 from, Vector3 to, List<int> orderedVertices, Vector3[] vs)
	{
		return null;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2A6AB80", Offset = "0x2A69180", VA = "0x182A6AB80")]
	private static int GetLastVertexWithYSmaller(float y, List<int> orderedVertices, Vector3[] vs, int limitSearchRange)
	{
		return 0;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2A6AD60", Offset = "0x2A69360", VA = "0x182A6AD60")]
	private static bool IsVertexObscured(Vector3[] vs, Vector3[] ns, int[] ts, bool[] vObscured, int[] uniqueVs, Vector3 vertexBoxSize, List<int> orderedVertices, List<List<int>> trianglesPerVertex, int[] subMeshIdxPerVertex, float maxObscureDist, bool hiddenByOtherSubmesh, Vector3 vertex, Vector3 normal, int i)
	{
		return default(bool);
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2A6B5D0", Offset = "0x2A69BD0", VA = "0x182A6B5D0")]
	public static float FindCollision(Vector3 fromPos, Vector3 direction, Vector3 pointOnPlane, Vector3 normalPlane)
	{
		return 0f;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2A6B6F0", Offset = "0x2A69CF0", VA = "0x182A6B6F0")]
	private static void Log(string msg)
	{
	}
}
