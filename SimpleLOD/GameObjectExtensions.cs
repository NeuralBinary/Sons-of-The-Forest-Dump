using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace OrbCreationExtensions
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public static class GameObjectExtensions
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2A6DFE0", Offset = "0x2A6C5E0", VA = "0x182A6DFE0")]
		public static Bounds GetWorldBounds(this GameObject go)
		{
			return default(Bounds);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2A6E4E0", Offset = "0x2A6CAE0", VA = "0x182A6E4E0")]
		public static Vector3[] GetBoundsCorners(this Bounds bounds)
		{
			return null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2A6E630", Offset = "0x2A6CC30", VA = "0x182A6E630")]
		public static Vector3[] GetBoundsCenterAndCorners(this Bounds bounds)
		{
			return null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2A6E7B0", Offset = "0x2A6CDB0", VA = "0x182A6E7B0")]
		public static Vector3[] GetWorldBoundsCorners(this GameObject go)
		{
			return null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2A6E900", Offset = "0x2A6CF00", VA = "0x182A6E900")]
		public static Vector3[] GetWorldBoundsCenterAndCorners(this GameObject go)
		{
			return null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2A6EA70", Offset = "0x2A6D070", VA = "0x182A6EA70")]
		public static float GetModelComplexity(this GameObject go)
		{
			return 0f;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2A6EC40", Offset = "0x2A6D240", VA = "0x182A6EC40")]
		public static string GetModelInfoString(this GameObject go)
		{
			return null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2A6F150", Offset = "0x2A6D750", VA = "0x182A6F150")]
		public static GameObject TopParent(this GameObject go)
		{
			return null;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2A6F310", Offset = "0x2A6D910", VA = "0x182A6F310")]
		public static GameObject FindParentWithName(this GameObject go, string parentName)
		{
			return null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2A6F520", Offset = "0x2A6DB20", VA = "0x182A6F520")]
		public static GameObject FindMutualParent(this GameObject go1, GameObject go2)
		{
			return null;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2A6F970", Offset = "0x2A6DF70", VA = "0x182A6F970")]
		public static GameObject FindFirstChildWithName(this GameObject go, string childName)
		{
			return null;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2A6FB10", Offset = "0x2A6E110", VA = "0x182A6FB10")]
		public static bool IsChildWithNameUnique(this GameObject go, string childName)
		{
			return default(bool);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2A6FB40", Offset = "0x2A6E140", VA = "0x182A6FB40")]
		public static void CountChildrenWithName(this GameObject go, string childName, ref int total)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2A6FE50", Offset = "0x2A6E450", VA = "0x182A6FE50")]
		public static GameObject GetGameObjectNamed(this GameObject go, string aStr, GameObject parentGO)
		{
			return null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2A6FFA0", Offset = "0x2A6E5A0", VA = "0x182A6FFA0")]
		public static void DestroyChildren(this GameObject go, bool disabledOnly)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004E")]
		public static T GetFirstComponentInParents<T>(this GameObject go) where T : Component
		{
			return null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004F")]
		public static T GetFirstComponentInChildren<T>(this GameObject go) where T : Component
		{
			return null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2A70510", Offset = "0x2A6EB10", VA = "0x182A70510")]
		public static Mesh[] GetMeshes(this GameObject aGo)
		{
			return null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2A70520", Offset = "0x2A6EB20", VA = "0x182A70520")]
		public static Mesh[] GetMeshes(this GameObject aGo, bool includeDisabled)
		{
			return null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2A707F0", Offset = "0x2A6EDF0", VA = "0x182A707F0")]
		public static int GetTotalVertexCount(this GameObject aGo)
		{
			return 0;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2A70AC0", Offset = "0x2A6F0C0", VA = "0x182A70AC0")]
		public static Mesh Get1stSharedMesh(this GameObject aGo)
		{
			return null;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2A70DB0", Offset = "0x2A6F3B0", VA = "0x182A70DB0")]
		public static void SetMeshes(this GameObject aGo, Mesh[] meshes)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2A70DD0", Offset = "0x2A6F3D0", VA = "0x182A70DD0")]
		public static void SetMeshes(this GameObject aGo, Mesh[] meshes, int lodLevel)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2A70DF0", Offset = "0x2A6F3F0", VA = "0x182A70DF0")]
		public static void SetMeshes(this GameObject aGo, Mesh[] meshes, bool includeDisabled, int lodLevel)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2A71560", Offset = "0x2A6FB60", VA = "0x182A71560")]
		public static Material[] GetMaterials(this GameObject aGo, bool includeDisabled)
		{
			return null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2A717D0", Offset = "0x2A6FDD0", VA = "0x182A717D0")]
		public static Mesh[] CombineMeshes(this GameObject aGO)
		{
			return null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2A71820", Offset = "0x2A6FE20", VA = "0x182A71820")]
		public static Mesh[] CombineMeshes(this GameObject aGO, string[] skipSubmeshNames)
		{
			return null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2A74640", Offset = "0x2A72C40", VA = "0x182A74640")]
		private static int GiveUniqueNameIfNeeded(GameObject aGo, GameObject topGO, int uniqueId)
		{
			return 0;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2A74790", Offset = "0x2A72D90", VA = "0x182A74790")]
		public static void SetUpLODLevels(this GameObject go)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2A747A0", Offset = "0x2A72DA0", VA = "0x182A747A0")]
		public static void SetUpLODLevels(this GameObject go, float maxWeight)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2A749B0", Offset = "0x2A72FB0", VA = "0x182A749B0")]
		public static void SetUpLODLevels(this GameObject go, float[] lodScreenSizes, float[] maxWeights)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2A74B20", Offset = "0x2A73120", VA = "0x182A74B20")]
		public static Mesh[] SetUpLODLevelsWithLODSwitcher(this GameObject go, float[] lodScreenSizes, float[] maxWeights, bool recalcNormals, float removeSmallParts = 1f, float protectNormals = 1f, float protectUvs = 1f, float protectSubMeshesAndSharpEdges = 1f, float smallTrianglesFirst = 1f, int nrOfSteps = 1)
		{
			return null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2A752E0", Offset = "0x2A738E0", VA = "0x182A752E0")]
		public static IEnumerator SetUpLODLevelsWithLODSwitcherInBackground(this GameObject go, float[] lodScreenSizes, float[] maxWeights, bool recalcNormals, float removeSmallParts = 1f, float protectNormals = 1f, float protectUvs = 1f, float protectSubMeshesAndSharpEdges = 1f, float smallTrianglesFirst = 1f)
		{
			return null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2A75460", Offset = "0x2A73A60", VA = "0x182A75460")]
		public static Mesh[] SetUpLODLevelsAndChildrenWithLODSwitcher(this GameObject go, float[] lodScreenSizes, float[] maxWeights, bool recalcNormals, float removeSmallParts, float protectNormals = 1f, float protectUvs = 1f, float protectSubMeshesAndSharpEdges = 1f, float smallTrianglesFirst = 1f, int nrOfSteps = 1)
		{
			return null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2A765D0", Offset = "0x2A74BD0", VA = "0x182A765D0")]
		public static Mesh[] SetUpLODLevelsAndChildrenWithLODGroup(this GameObject go, float[] relativeTransitionHeights, float[] maxWeights, bool recalcNormals, float removeSmallParts, float protectNormals = 1f, float protectUvs = 1f, float protectSubMeshesAndSharpEdges = 1f, float smallTrianglesFirst = 1f, int nrOfSteps = 1)
		{
			return null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2A77810", Offset = "0x2A75E10", VA = "0x182A77810")]
		public static Mesh GetSimplifiedMesh(this GameObject go, float maxWeight, bool recalcNormals, float removeSmallParts, float protectNormals = 1f, float protectUvs = 1f, float protectSubMeshesAndSharpEdges = 1f, float smallTrianglesFirst = 1f, int nrOfSteps = 1)
		{
			return null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2A77E90", Offset = "0x2A76490", VA = "0x182A77E90")]
		public static IEnumerator GetSimplifiedMeshInBackground(this GameObject go, float maxWeight, bool recalcNormals, float removeSmallParts, Action<Mesh> result)
		{
			return null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2A77FC0", Offset = "0x2A765C0", VA = "0x182A77FC0")]
		private static bool MergeMeshInto(Mesh fromMesh, Transform[] fromBones, Material[] fromMaterials, List<Vector3> vertices, List<Vector3> normals, List<Vector2> uv1s, List<Vector2> uv2s, List<Vector2> uv3s, List<Vector2> uv4s, List<Color32> colors32, List<BoneWeight> boneWeights, List<Transform> bones, List<Matrix4x4> bindposes, Dictionary<Material, List<int>> subMeshes, bool usesNegativeScale, Vector4 lightmapScaleOffset, Transform fromTransform, Transform topTransform, string submeshName, string[] skipSubmeshNames)
		{
			return default(bool);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2A7A420", Offset = "0x2A78A20", VA = "0x182A7A420")]
		private static Vector3 ApplyBindPose(Vector3 vertex, Transform bone, Matrix4x4 bindpose, float boneWeight)
		{
			return default(Vector3);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2A7A700", Offset = "0x2A78D00", VA = "0x182A7A700")]
		private static Vector3 UnApplyBindPose(Vector3 vertex, Transform bone, Matrix4x4 bindpose, float boneWeight)
		{
			return default(Vector3);
		}
	}
}
