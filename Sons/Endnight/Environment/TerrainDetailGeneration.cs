using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.TerrainDetail;
using UnityEngine;

namespace Endnight.Environment
{
	// Token: 0x020004CA RID: 1226
	[Token(Token = "0x20004CA")]
	public class TerrainDetailGeneration : MonoBehaviour
	{
		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047C")]
		public List<NamedObject> DetailLibrary
		{
			[Token(Token = "0x6002009")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200A")]
		[Address(RVA = "0x330F2A0", Offset = "0x330D8A0", VA = "0x18330F2A0")]
		private static WorldObjectLocatorManager GetManager()
		{
			return null;
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void Awake()
		{
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void GenerateFromBakedScene()
		{
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x00009588 File Offset: 0x00007788
		[Token(Token = "0x600200D")]
		[Address(RVA = "0x330F2F0", Offset = "0x330D8F0", VA = "0x18330F2F0")]
		private int GetWorldLocatorIdIndex(WorldLocatorId uid, List<WorldLocatorId> existingHashes)
		{
			return 0;
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200E")]
		[Address(RVA = "0x330F460", Offset = "0x330DA60", VA = "0x18330F460")]
		private void AddPoolLinks(WorldObjectLocatorData locatorData)
		{
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200F")]
		[Address(RVA = "0x330F540", Offset = "0x330DB40", VA = "0x18330F540")]
		private void AddPoolLink(Transform transformTarget)
		{
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002010")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void AddPoolLinkToPrefabAsset(GameObject prefab)
		{
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002011")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[ContextMenu("Generate Instances")]
		private void GeneratePrefabsFromBakedScene()
		{
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x000095A0 File Offset: 0x000077A0
		[Token(Token = "0x6002012")]
		[Address(RVA = "0x330F760", Offset = "0x330DD60", VA = "0x18330F760")]
		private bool IsInside(Vector3 position, ICollection<Collider> colliders)
		{
			return default(bool);
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002013")]
		[Address(RVA = "0x330FA30", Offset = "0x330E030", VA = "0x18330FA30")]
		private UnityEngine.Object GetDetailSource(TerrainDetail detail)
		{
			return null;
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002014")]
		[Address(RVA = "0x330FB50", Offset = "0x330E150", VA = "0x18330FB50")]
		private UnityEngine.Object GetDetailSourceFromDetailId(string detailId)
		{
			return null;
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002015")]
		[Address(RVA = "0x330FCE0", Offset = "0x330E2E0", VA = "0x18330FCE0")]
		private GameObject SpawnInstance(GameObject source, Vector3 worldPosition, Quaternion worldRotation, Vector3 localScale, Transform parent)
		{
			return null;
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002016")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[ContextMenu("Generate Lightmap Mesh Setup")]
		public void GenerateLightmapMeshSetup()
		{
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002017")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[ContextMenu("Clear All Children")]
		private void ClearAllChildren()
		{
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002018")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void CreateCombinedMeshesButton()
		{
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x000095B8 File Offset: 0x000077B8
		[Token(Token = "0x6002019")]
		[Address(RVA = "0x330FFB0", Offset = "0x330E5B0", VA = "0x18330FFB0")]
		private bool GetResultPath(out string resultPath)
		{
			return default(bool);
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x000095D0 File Offset: 0x000077D0
		[Token(Token = "0x600201A")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590")]
		[ContextMenu("Generate Lightmap Instances")]
		private bool GenerateLightmapPrefabsFromBakedScene()
		{
			return default(bool);
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void CreateLightmapPrefab(List<TerrainDetailMap> detailMaps, int iMap, string title, int totalMaps, int total, ref int currentIndex, ref bool cancelled)
		{
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void CreateLightmapPrefab(TerrainDetail eachDetail)
		{
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x000095E8 File Offset: 0x000077E8
		[Token(Token = "0x600201D")]
		[Address(RVA = "0x3310010", Offset = "0x330E610", VA = "0x183310010")]
		private static Color GetButtonColor()
		{
			return default(Color);
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void CreateCombinedMeshes([Optional] string resultPath, bool startLightmapBake = false, bool saveScene = false, bool applyPrefabOverride = false)
		{
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x00009600 File Offset: 0x00007800
		[Token(Token = "0x600201F")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
		private static bool GetLightmapMeshesPath(ref string resultPath)
		{
			return default(bool);
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002020")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private static void BuildLightmapMeshes(string resultPath, Transform transform)
		{
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002021")]
		[Address(RVA = "0x3310030", Offset = "0x330E630", VA = "0x183310030")]
		public TerrainDetailGeneration()
		{
		}

		// Token: 0x04001D77 RID: 7543
		[Token(Token = "0x4001D77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _generateOnAwake;

		// Token: 0x04001D78 RID: 7544
		[Token(Token = "0x4001D78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<NamedObject> _detailLibrary;

		// Token: 0x04001D79 RID: 7545
		[Token(Token = "0x4001D79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Collider> _excludeColliders;

		// Token: 0x04001D7A RID: 7546
		[Token(Token = "0x4001D7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string _cachedPath;

		// Token: 0x04001D7B RID: 7547
		[Token(Token = "0x4001D7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string _defaultName;

		// Token: 0x04001D7C RID: 7548
		[Token(Token = "0x4001D7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Header("Lightmapping")]
		[Header("Options")]
		private bool _applyPrefabOverride;

		// Token: 0x04001D7D RID: 7549
		[Token(Token = "0x4001D7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool _saveScene;

		// Token: 0x04001D7E RID: 7550
		[Token(Token = "0x4001D7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[SerializeField]
		private bool _startLightmapBake;

		// Token: 0x04001D7F RID: 7551
		[Token(Token = "0x4001D7F")]
		private const int MaxVertsPerMesh = 16383;
	}
}
