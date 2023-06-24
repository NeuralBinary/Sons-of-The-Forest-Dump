using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Lodding;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000006")]
[CreateAssetMenu(fileName = "WorldObjectLocatorData", menuName = "Sons/Environment/WorldObjectLocatorData", order = 0)]
public class WorldObjectLocatorData : ScriptableObject, ISerializationCallbackReceiver
{
	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000015 RID: 21 RVA: 0x0000209C File Offset: 0x0000029C
	// (set) Token: 0x06000016 RID: 22 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x17000002")]
	public bool ExcludedFromCache
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x75A6B0", Offset = "0x758CB0", VA = "0x18075A6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000017 RID: 23 RVA: 0x00002098 File Offset: 0x00000298
	[Token(Token = "0x17000003")]
	public Transform Lod0
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000018 RID: 24 RVA: 0x00002098 File Offset: 0x00000298
	[Token(Token = "0x17000004")]
	public Transform Lod1
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000019 RID: 25 RVA: 0x00002098 File Offset: 0x00000298
	[Token(Token = "0x17000005")]
	public Transform Lod2
	{
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600001A RID: 26 RVA: 0x00002098 File Offset: 0x00000298
	[Token(Token = "0x17000006")]
	public Transform LodLightmap
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600001B RID: 27 RVA: 0x00002098 File Offset: 0x00000298
	[Token(Token = "0x17000007")]
	public CustomBillboard Billboard
	{
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600001C RID: 28 RVA: 0x000020B4 File Offset: 0x000002B4
	[Token(Token = "0x17000008")]
	public LodSettingsTypeEnum Type
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x671130", Offset = "0x66F730", VA = "0x180671130")]
		get
		{
			return LodSettingsTypeEnum.Trees;
		}
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002098 File Offset: 0x00000298
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2F90590", Offset = "0x2F8EB90", VA = "0x182F90590")]
	public string GetPoolName()
	{
		return null;
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600001E RID: 30 RVA: 0x000020CC File Offset: 0x000002CC
	[Token(Token = "0x17000009")]
	public bool DisableLods
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x5F2120", Offset = "0x5F0720", VA = "0x1805F2120")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002098 File Offset: 0x00000298
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
	public GameObject GetLod0Prefab()
	{
		return null;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void OnValidate()
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x000020E4 File Offset: 0x000002E4
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2F906F0", Offset = "0x2F8ECF0", VA = "0x182F906F0")]
	public bool MatchesAnyLod(GameObject prefabSource)
	{
		return default(bool);
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002098 File Offset: 0x00000298
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2F90A80", Offset = "0x2F8F080", VA = "0x182F90A80")]
	private static Transform SetupLightProbeUsageOverridePrefab(LightProbeUsage lightProbeUsage, Transform sourcePrefab)
	{
		return null;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x000020FC File Offset: 0x000002FC
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2F90E10", Offset = "0x2F8F410", VA = "0x182F90E10")]
	private static int GenerateVirtualPrefabHashCode(int lightProbeUsage, int sourcePrefabInstanceId)
	{
		return 0;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002098 File Offset: 0x00000298
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2F90E20", Offset = "0x2F8F420", VA = "0x182F90E20")]
	public static Transform GetLightProbeUsageOverridePrefab(LightProbeUsage lightProbeUsage, ref Transform[] lightProbeUsageOverridePrefabs, Transform sourcePrefab)
	{
		return null;
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002098 File Offset: 0x00000298
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
	public Transform GetLod0LightProbeUsageOverridePrefab(LightProbeUsage lightProbeUsage)
	{
		return null;
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002098 File Offset: 0x00000298
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
	public Transform GetLod1LightProbeUsageOverridePrefab(LightProbeUsage lightProbeUsage)
	{
		return null;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002098 File Offset: 0x00000298
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
	public Transform GetLod2LightProbeUsageOverridePrefab(LightProbeUsage lightProbeUsage)
	{
		return null;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002098 File Offset: 0x00000298
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x2F91140", Offset = "0x2F8F740", VA = "0x182F91140")]
	private static string GetDefaultGenerateHoudiniDefPath()
	{
		return null;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void OnValidateEditor()
	{
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void UpdateMaterials(GameObject lodTarget)
	{
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
	public WorldObjectLocatorData()
	{
	}

	// Token: 0x04000050 RID: 80
	[Token(Token = "0x4000050")]
	private const string BushPoolName = "Bushes";

	// Token: 0x04000051 RID: 81
	[Token(Token = "0x4000051")]
	private const string CavePoolName = "Caves";

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Header("LOD Properties:")]
	private GameObject _lod0Prefab;

	// Token: 0x04000054 RID: 84
	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	[SerializeField]
	private Transform _lod0Transform;

	// Token: 0x04000055 RID: 85
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject _lod1Prefab;

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	[SerializeField]
	private Transform _lod1Transform;

	// Token: 0x04000057 RID: 87
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject _lod2Prefab;

	// Token: 0x04000058 RID: 88
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x48")]
	[HideInInspector]
	[SerializeField]
	private Transform _lod2Transform;

	// Token: 0x04000059 RID: 89
	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool _disableLods;

	// Token: 0x0400005A RID: 90
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject _billboardPrefab;

	// Token: 0x0400005B RID: 91
	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x60")]
	[HideInInspector]
	[SerializeField]
	private CustomBillboard _billboard;

	// Token: 0x0400005C RID: 92
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private bool _blockMaterialStipple;

	// Token: 0x0400005D RID: 93
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private LodSettingsTypeEnum _type;

	// Token: 0x0400005E RID: 94
	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject _lodLightmapPrefab;

	// Token: 0x0400005F RID: 95
	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[HideInInspector]
	private Transform _lodLightmap;

	// Token: 0x04000060 RID: 96
	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x80")]
	private string _cachedPoolName;

	// Token: 0x04000061 RID: 97
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x88")]
	[NonSerialized]
	private Transform[] _lod0LightProbeUsageOverridePrefabs;

	// Token: 0x04000062 RID: 98
	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x90")]
	[NonSerialized]
	private Transform[] _lod1LightProbeUsageOverridePrefabs;

	// Token: 0x04000063 RID: 99
	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x98")]
	[NonSerialized]
	private Transform[] _lod2LightProbeUsageOverridePrefabs;

	// Token: 0x04000064 RID: 100
	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, Transform> _virtualLodSources;

	// Token: 0x04000065 RID: 101
	[Token(Token = "0x4000065")]
	private const string ExportCultureName = "en-US";

	// Token: 0x04000066 RID: 102
	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int GlobalStippleIndexId;

	// Token: 0x04000067 RID: 103
	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int TreestipplingString;

	// Token: 0x04000068 RID: 104
	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int GlobalStipplingBool;

	// Token: 0x04000069 RID: 105
	[Token(Token = "0x4000069")]
	private const string TreeStipplingKeywordString = "TREESTIPPLING_ON";
}
