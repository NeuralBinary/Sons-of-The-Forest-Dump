using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.TerrainDetail;
using UnityEngine;

namespace Endnight.Environment
{
	// Token: 0x020004D5 RID: 1237
	[Token(Token = "0x20004D5")]
	public class TerrainDetailGeneration : MonoBehaviour
	{
		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046D")]
		public List<NamedObject> DetailLibrary
		{
			[Token(Token = "0x6001FA5")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA6")]
		[Address(RVA = "0x2D33670", Offset = "0x2D32670", VA = "0x182D33670")]
		private static WorldObjectLocatorManager GetManager()
		{
			return null;
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA7")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void Awake()
		{
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA8")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void GenerateFromBakedScene()
		{
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x00009228 File Offset: 0x00007428
		[Token(Token = "0x6001FA9")]
		[Address(RVA = "0x2D336E0", Offset = "0x2D326E0", VA = "0x182D336E0")]
		private int GetWorldLocatorIdIndex(WorldLocatorId uid, List<WorldLocatorId> existingHashes)
		{
			return default(int);
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FAA")]
		[Address(RVA = "0x2D33370", Offset = "0x2D32370", VA = "0x182D33370")]
		private void AddPoolLinks(WorldObjectLocatorData locatorData)
		{
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FAB")]
		[Address(RVA = "0x2D33280", Offset = "0x2D32280", VA = "0x182D33280")]
		private void AddPoolLink(Transform transformTarget)
		{
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FAC")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void AddPoolLinkToPrefabAsset(GameObject prefab)
		{
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FAD")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		[ContextMenu("Generate Instances")]
		private void GeneratePrefabsFromBakedScene()
		{
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x00009240 File Offset: 0x00007440
		[Token(Token = "0x6001FAE")]
		[Address(RVA = "0x2D337F0", Offset = "0x2D327F0", VA = "0x182D337F0")]
		private bool IsInside(Vector3 position, ICollection<Collider> colliders)
		{
			return default(bool);
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FAF")]
		[Address(RVA = "0x2D335A0", Offset = "0x2D325A0", VA = "0x182D335A0")]
		private Object GetDetailSource(TerrainDetail detail)
		{
			return null;
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FB0")]
		[Address(RVA = "0x2D33440", Offset = "0x2D32440", VA = "0x182D33440")]
		private Object GetDetailSourceFromDetailId(string detailId)
		{
			return null;
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FB1")]
		[Address(RVA = "0x2D33AB0", Offset = "0x2D32AB0", VA = "0x182D33AB0")]
		private GameObject SpawnInstance(GameObject source, Vector3 worldPosition, Quaternion worldRotation, Vector3 localScale, Transform parent)
		{
			return null;
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB2")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		[ContextMenu("Generate Lightmap Mesh Setup")]
		public void GenerateLightmapMeshSetup()
		{
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB3")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		[ContextMenu("Clear All Children")]
		private void ClearAllChildren()
		{
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB4")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void CreateCombinedMeshesButton()
		{
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x00009258 File Offset: 0x00007458
		[Token(Token = "0x6001FB5")]
		[Address(RVA = "0x2D336C0", Offset = "0x2D326C0", VA = "0x182D336C0")]
		private bool GetResultPath(out string resultPath)
		{
			return default(bool);
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x00009270 File Offset: 0x00007470
		[Token(Token = "0x6001FB6")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970")]
		[ContextMenu("Generate Lightmap Instances")]
		private bool GenerateLightmapPrefabsFromBakedScene()
		{
			return default(bool);
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB7")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void CreateLightmapPrefab(List<TerrainDetailMap> detailMaps, int iMap, string title, int totalMaps, int total, ref int currentIndex, ref bool cancelled)
		{
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB8")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void CreateLightmapPrefab(TerrainDetail eachDetail)
		{
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x00009288 File Offset: 0x00007488
		[Token(Token = "0x6001FB9")]
		[Address(RVA = "0x2D33420", Offset = "0x2D32420", VA = "0x182D33420")]
		private static Color GetButtonColor()
		{
			return default(Color);
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FBA")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public static void CreateCombinedMeshes([Optional] string resultPath, bool startLightmapBake = false, bool saveScene = false, bool applyPrefabOverride = false)
		{
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x000092A0 File Offset: 0x000074A0
		[Token(Token = "0x6001FBB")]
		[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0")]
		private static bool GetLightmapMeshesPath(ref string resultPath)
		{
			return default(bool);
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FBC")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private static void BuildLightmapMeshes(string resultPath, Transform transform)
		{
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FBD")]
		[Address(RVA = "0x2D33C10", Offset = "0x2D32C10", VA = "0x182D33C10")]
		public TerrainDetailGeneration()
		{
		}

		// Token: 0x04001D3B RID: 7483
		[Token(Token = "0x4001D3B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _generateOnAwake;

		// Token: 0x04001D3C RID: 7484
		[Token(Token = "0x4001D3C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<NamedObject> _detailLibrary;

		// Token: 0x04001D3D RID: 7485
		[Token(Token = "0x4001D3D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Collider> _excludeColliders;

		// Token: 0x04001D3E RID: 7486
		[Token(Token = "0x4001D3E")]
		[FieldOffset(Offset = "0x38")]
		private string _cachedPath;

		// Token: 0x04001D3F RID: 7487
		[Token(Token = "0x4001D3F")]
		[FieldOffset(Offset = "0x40")]
		private string _defaultName;

		// Token: 0x04001D40 RID: 7488
		[Token(Token = "0x4001D40")]
		[FieldOffset(Offset = "0x48")]
		[Header("Options")]
		[Header("Lightmapping")]
		[SerializeField]
		private bool _applyPrefabOverride;

		// Token: 0x04001D41 RID: 7489
		[Token(Token = "0x4001D41")]
		[FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool _saveScene;

		// Token: 0x04001D42 RID: 7490
		[Token(Token = "0x4001D42")]
		[FieldOffset(Offset = "0x4A")]
		[SerializeField]
		private bool _startLightmapBake;

		// Token: 0x04001D43 RID: 7491
		[Token(Token = "0x4001D43")]
		private const int MaxVertsPerMesh = 16383;
	}
}
