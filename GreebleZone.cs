using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using PathCreation;
using TheForest.Utils.WorkSchedulerInterfaces;
using UnityEngine;

// Token: 0x020001BF RID: 447
[Token(Token = "0x20001BF")]
public class GreebleZone : MonoBehaviour, IThreadSafeTask
{
	// Token: 0x17000178 RID: 376
	// (get) Token: 0x06000C89 RID: 3209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000178")]
	public List<GreebleZoneVolume> Volumes
	{
		[Token(Token = "0x6000C89")]
		[Address(RVA = "0x541220", Offset = "0x540220", VA = "0x180541220")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x06000C8A RID: 3210 RVA: 0x00005178 File Offset: 0x00003378
	// (set) Token: 0x06000C8B RID: 3211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000179")]
	public static bool AlwaysShowGizmos
	{
		[Token(Token = "0x6000C8A")]
		[Address(RVA = "0x2F6FED0", Offset = "0x2F6EED0", VA = "0x182F6FED0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0x2F6FF70", Offset = "0x2F6EF70", VA = "0x182F6FF70")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x06000C8C RID: 3212 RVA: 0x00005190 File Offset: 0x00003390
	// (set) Token: 0x06000C8D RID: 3213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700017A")]
	public static bool WireFrameGizmos
	{
		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x2F6FF30", Offset = "0x2F6EF30", VA = "0x182F6FF30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x2F6FFB0", Offset = "0x2F6EFB0", VA = "0x182F6FFB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700017B RID: 379
	// (get) Token: 0x06000C8E RID: 3214 RVA: 0x000051A8 File Offset: 0x000033A8
	[Token(Token = "0x1700017B")]
	public Bounds Bounds
	{
		[Token(Token = "0x6000C8E")]
		[Address(RVA = "0x2F6FF10", Offset = "0x2F6EF10", VA = "0x182F6FF10")]
		get
		{
			return default(Bounds);
		}
	}

	// Token: 0x1700017C RID: 380
	// (get) Token: 0x06000C8F RID: 3215 RVA: 0x000051C0 File Offset: 0x000033C0
	[Token(Token = "0x1700017C")]
	public int MaxInstancesModified
	{
		[Token(Token = "0x6000C8F")]
		[Address(RVA = "0x6B7210", Offset = "0x6B6210", VA = "0x1806B7210")]
		get
		{
			return default(int);
		}
	}

	// Token: 0x1700017D RID: 381
	// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C91 RID: 3217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700017D")]
	public GreebleZonesManager.GZData ZoneData
	{
		[Token(Token = "0x6000C90")]
		[Address(RVA = "0x7B98F0", Offset = "0x7B88F0", VA = "0x1807B98F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C91")]
		[Address(RVA = "0x7B9920", Offset = "0x7B8920", VA = "0x1807B9920")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700017E RID: 382
	// (get) Token: 0x06000C92 RID: 3218 RVA: 0x000051D8 File Offset: 0x000033D8
	// (set) Token: 0x06000C93 RID: 3219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700017E")]
	public bool CurrentlyVisible
	{
		[Token(Token = "0x6000C92")]
		[Address(RVA = "0x5CC180", Offset = "0x5CB180", VA = "0x1805CC180")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C93")]
		[Address(RVA = "0x6DE720", Offset = "0x6DD720", VA = "0x1806DE720")]
		private set
		{
		}
	}

	// Token: 0x1700017F RID: 383
	// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C95 RID: 3221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700017F")]
	public GameObject[] Instances
	{
		[Token(Token = "0x6000C94")]
		[Address(RVA = "0x7B98E0", Offset = "0x7B88E0", VA = "0x1807B98E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C95")]
		[Address(RVA = "0x7B9910", Offset = "0x7B8910", VA = "0x1807B9910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000180 RID: 384
	// (get) Token: 0x06000C96 RID: 3222 RVA: 0x000051F0 File Offset: 0x000033F0
	// (set) Token: 0x06000C97 RID: 3223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000180")]
	public bool ShouldDoMainThreadRefresh
	{
		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x217BF20", Offset = "0x217AF20", VA = "0x18217BF20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C97")]
		[Address(RVA = "0x217C040", Offset = "0x217B040", VA = "0x18217C040", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x06000C98 RID: 3224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C98")]
	[Address(RVA = "0x2F6A900", Offset = "0x2F69900", VA = "0x182F6A900")]
	private void Awake()
	{
	}

	// Token: 0x06000C99 RID: 3225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C99")]
	[Address(RVA = "0x2F6B880", Offset = "0x2F6A880", VA = "0x182F6B880")]
	private void OnEnable()
	{
	}

	// Token: 0x06000C9A RID: 3226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9A")]
	[Address(RVA = "0x2F6B840", Offset = "0x2F6A840", VA = "0x182F6B840")]
	private void OnDisable()
	{
	}

	// Token: 0x06000C9B RID: 3227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9B")]
	[Address(RVA = "0x2F6B7E0", Offset = "0x2F6A7E0", VA = "0x182F6B7E0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000C9C RID: 3228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9C")]
	[Address(RVA = "0x2F6BAE0", Offset = "0x2F6AAE0", VA = "0x182F6BAE0")]
	public void RespawnAll()
	{
	}

	// Token: 0x06000C9D RID: 3229 RVA: 0x00005208 File Offset: 0x00003408
	[Token(Token = "0x6000C9D")]
	[Address(RVA = "0x7BB9F0", Offset = "0x7BA9F0", VA = "0x1807BB9F0")]
	private int GetModifiedInstanceCount(int rawCount)
	{
		return default(int);
	}

	// Token: 0x06000C9E RID: 3230 RVA: 0x00005220 File Offset: 0x00003420
	[Token(Token = "0x6000C9E")]
	[Address(RVA = "0x2F6B6D0", Offset = "0x2F6A6D0", VA = "0x182F6B6D0")]
	private int GetRandomSeed()
	{
		return default(int);
	}

	// Token: 0x06000C9F RID: 3231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9F")]
	[Address(RVA = "0x2F6BA70", Offset = "0x2F6AA70", VA = "0x182F6BA70")]
	private void RegenerateSeed()
	{
	}

	// Token: 0x06000CA0 RID: 3232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA0")]
	[Address(RVA = "0x2F6BF10", Offset = "0x2F6AF10", VA = "0x182F6BF10")]
	private void ScheduledSpawn()
	{
	}

	// Token: 0x06000CA1 RID: 3233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA1")]
	[Address(RVA = "0x2F6C690", Offset = "0x2F6B690", VA = "0x182F6C690")]
	private void SpawnIndex(int index, bool forPreview = false)
	{
	}

	// Token: 0x06000CA2 RID: 3234 RVA: 0x00005238 File Offset: 0x00003438
	[Token(Token = "0x6000CA2")]
	[Address(RVA = "0x2F6AA40", Offset = "0x2F69A40", VA = "0x182F6AA40")]
	private static float CachedElapsedGameTime()
	{
		return default(float);
	}

	// Token: 0x06000CA3 RID: 3235 RVA: 0x00005250 File Offset: 0x00003450
	[Token(Token = "0x6000CA3")]
	[Address(RVA = "0x2F6AB20", Offset = "0x2F69B20", VA = "0x182F6AB20")]
	private bool DefinitionIndex(GreebleGlobalDefinition.SpawnObjectType prefabVariation, out int definitionIndex, out int variationIndex)
	{
		return default(bool);
	}

	// Token: 0x06000CA4 RID: 3236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA4")]
	[Address(RVA = "0x2F6BFC0", Offset = "0x2F6AFC0", VA = "0x182F6BFC0")]
	private void SetDestroyed(int index)
	{
	}

	// Token: 0x06000CA5 RID: 3237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA5")]
	[Address(RVA = "0x2F6A780", Offset = "0x2F69780", VA = "0x182F6A780")]
	private static void ApplyModifiers(GameObject affectedObject, GreebleGlobalDefinition greebleDefinition)
	{
	}

	// Token: 0x06000CA6 RID: 3238 RVA: 0x00005268 File Offset: 0x00003468
	[Token(Token = "0x6000CA6")]
	[Address(RVA = "0x2F6E9E0", Offset = "0x2F6D9E0", VA = "0x182F6E9E0")]
	private bool TryPlaceInstance(GreebleGlobalDefinition greebleDefinition, out GreebleZone.PlacementResults results)
	{
		return default(bool);
	}

	// Token: 0x06000CA7 RID: 3239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA7")]
	[Address(RVA = "0x2F6D590", Offset = "0x2F6C590", VA = "0x182F6D590")]
	private void TryPlaceInstanceBox(ref float distance, out Vector3 worldSpacePoint, out Vector3 worldSpaceDirection)
	{
	}

	// Token: 0x06000CA8 RID: 3240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA8")]
	[Address(RVA = "0x2F6D9C0", Offset = "0x2F6C9C0", VA = "0x182F6D9C0")]
	private void TryPlaceInstanceSphere(GreebleGlobalDefinition greebleDefinition, ref Vector3 worldSpacePoint, out Vector3 worldSpaceDirection, out float distance)
	{
	}

	// Token: 0x06000CA9 RID: 3241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA9")]
	[Address(RVA = "0x2F6E1E0", Offset = "0x2F6D1E0", VA = "0x182F6E1E0")]
	private void TryPlaceInstanceSpline(List<Transform> insideVolumes, ref Vector3 worldSpacePoint, out Vector3 worldSpaceDirection, out float distance)
	{
	}

	// Token: 0x06000CAA RID: 3242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAA")]
	[Address(RVA = "0x2F6BA60", Offset = "0x2F6AA60", VA = "0x182F6BA60")]
	private void PreviewInstances()
	{
	}

	// Token: 0x06000CAB RID: 3243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAB")]
	[Address(RVA = "0x2F6C030", Offset = "0x2F6B030", VA = "0x182F6C030")]
	public void SpawnAll(bool forPreview = false)
	{
	}

	// Token: 0x06000CAC RID: 3244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAC")]
	[Address(RVA = "0x2F6AC40", Offset = "0x2F69C40", VA = "0x182F6AC40")]
	public void DespawnAll()
	{
	}

	// Token: 0x06000CAD RID: 3245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAD")]
	[Address(RVA = "0x2F6B0A0", Offset = "0x2F6A0A0", VA = "0x182F6B0A0")]
	private void DespawnIndex(int i)
	{
	}

	// Token: 0x06000CAE RID: 3246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAE")]
	[Address(RVA = "0x2F6BB10", Offset = "0x2F6AB10", VA = "0x182F6BB10")]
	private void ScaleBasedOffDensity()
	{
	}

	// Token: 0x06000CAF RID: 3247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAF")]
	[Address(RVA = "0x2F6D2C0", Offset = "0x2F6C2C0", VA = "0x182F6D2C0", Slot = "6")]
	public void ThreadedRefresh()
	{
	}

	// Token: 0x06000CB0 RID: 3248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB0")]
	[Address(RVA = "0x2F6B790", Offset = "0x2F6A790", VA = "0x182F6B790", Slot = "7")]
	public void MainThreadRefresh()
	{
	}

	// Token: 0x06000CB1 RID: 3249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB1")]
	[Address(RVA = "0x2F6FA60", Offset = "0x2F6EA60", VA = "0x182F6FA60")]
	private void UpdateMovedMaskVolumes()
	{
	}

	// Token: 0x06000CB2 RID: 3250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB2")]
	[Address(RVA = "0x2F6F790", Offset = "0x2F6E790", VA = "0x182F6F790")]
	private void UpdateDynamicMaskLocation()
	{
	}

	// Token: 0x06000CB3 RID: 3251 RVA: 0x00005280 File Offset: 0x00003480
	[Token(Token = "0x6000CB3")]
	[Address(RVA = "0x2F6B3A0", Offset = "0x2F6A3A0", VA = "0x182F6B3A0")]
	private bool DynamicMaskContains(Vector3 instancePos)
	{
		return default(bool);
	}

	// Token: 0x06000CB4 RID: 3252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB4")]
	[Address(RVA = "0x2F6FD50", Offset = "0x2F6ED50", VA = "0x182F6FD50")]
	private void UpdateVisibility()
	{
	}

	// Token: 0x06000CB5 RID: 3253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CB5")]
	[Address(RVA = "0x2F6B410", Offset = "0x2F6A410", VA = "0x182F6B410")]
	public GreebleGlobalDefinition GetDefinitionAtInstanceIndex(int index)
	{
		return null;
	}

	// Token: 0x06000CB6 RID: 3254 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CB6")]
	[Address(RVA = "0x2F6B5B0", Offset = "0x2F6A5B0", VA = "0x182F6B5B0")]
	public GreebleGlobalDefinition.SpawnObjectType GetObjectVariationAtInstanceIndex(int index)
	{
		return null;
	}

	// Token: 0x06000CB7 RID: 3255 RVA: 0x00005298 File Offset: 0x00003498
	[Token(Token = "0x6000CB7")]
	[Address(RVA = "0x2F6B500", Offset = "0x2F6A500", VA = "0x182F6B500")]
	public Vector3 GetInstanceScaleMultiplier(int index)
	{
		return default(Vector3);
	}

	// Token: 0x06000CB8 RID: 3256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB8")]
	[Address(RVA = "0x2F6C020", Offset = "0x2F6B020", VA = "0x182F6C020")]
	public void SetGizmoColor(Color color)
	{
	}

	// Token: 0x06000CB9 RID: 3257 RVA: 0x000052B0 File Offset: 0x000034B0
	[Token(Token = "0x6000CB9")]
	[Address(RVA = "0x2560480", Offset = "0x255F480", VA = "0x182560480")]
	public Color GetGizmoColor()
	{
		return default(Color);
	}

	// Token: 0x06000CBA RID: 3258 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CBA")]
	[Address(RVA = "0x2F6B760", Offset = "0x2F6A760", VA = "0x182F6B760", Slot = "8")]
	public string GetTaskName()
	{
		return null;
	}

	// Token: 0x06000CBB RID: 3259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CBB")]
	[Address(RVA = "0x2F6FD90", Offset = "0x2F6ED90", VA = "0x182F6FD90")]
	public GreebleZone()
	{
	}

	// Token: 0x04000B61 RID: 2913
	[Token(Token = "0x4000B61")]
	private const string PreviewSpawnedInstanceTag = "GreeblePreview";

	// Token: 0x04000B62 RID: 2914
	[Token(Token = "0x4000B62")]
	[FieldOffset(Offset = "0x20")]
	private bool _currentlyVisible;

	// Token: 0x04000B63 RID: 2915
	[Token(Token = "0x4000B63")]
	[FieldOffset(Offset = "0x21")]
	private bool _allSpawned;

	// Token: 0x04000B64 RID: 2916
	[Token(Token = "0x4000B64")]
	[FieldOffset(Offset = "0x22")]
	public bool MarkDirtyForBake;

	// Token: 0x04000B65 RID: 2917
	[Token(Token = "0x4000B65")]
	[FieldOffset(Offset = "0x23")]
	public bool MpSync;

	// Token: 0x04000B66 RID: 2918
	[Token(Token = "0x4000B66")]
	[FieldOffset(Offset = "0x24")]
	public GreebleShape Shape;

	// Token: 0x04000B67 RID: 2919
	[Token(Token = "0x4000B67")]
	[FieldOffset(Offset = "0x28")]
	[Range(1f, 1000f)]
	public float Radius;

	// Token: 0x04000B68 RID: 2920
	[Token(Token = "0x4000B68")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 Size;

	// Token: 0x04000B69 RID: 2921
	[Token(Token = "0x4000B69")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<GreebleZoneVolume> _volumes;

	// Token: 0x04000B6A RID: 2922
	[Token(Token = "0x4000B6A")]
	[FieldOffset(Offset = "0x40")]
	public bool SnapHeightAboveTerrain;

	// Token: 0x04000B6B RID: 2923
	[Token(Token = "0x4000B6B")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _snapHeightOffset;

	// Token: 0x04000B6C RID: 2924
	[Token(Token = "0x4000B6C")]
	[FieldOffset(Offset = "0x48")]
	public bool AllowRegrowth;

	// Token: 0x04000B6D RID: 2925
	[Token(Token = "0x4000B6D")]
	[FieldOffset(Offset = "0x49")]
	public bool ShowPreviewInstancesInInspector;

	// Token: 0x04000B6E RID: 2926
	[Token(Token = "0x4000B6E")]
	[FieldOffset(Offset = "0x4C")]
	[Range(1f, 100000f)]
	[SerializeField]
	private int MaxInstances;

	// Token: 0x04000B6F RID: 2927
	[Token(Token = "0x4000B6F")]
	[FieldOffset(Offset = "0x50")]
	[Tooltip("This is the number of attempts which will be made when a spawn index fails to find a valid placement position.")]
	[SerializeField]
	[Range(0f, 100f)]
	private int _placementRetryAttempts;

	// Token: 0x04000B70 RID: 2928
	[Token(Token = "0x4000B70")]
	[FieldOffset(Offset = "0x54")]
	[Range(0f, 500f)]
	public float ToggleDistance;

	// Token: 0x04000B71 RID: 2929
	[Token(Token = "0x4000B71")]
	[FieldOffset(Offset = "0x58")]
	public GreebleRayDirection Direction;

	// Token: 0x04000B72 RID: 2930
	[Token(Token = "0x4000B72")]
	[FieldOffset(Offset = "0x5C")]
	[Range(0f, 100000f)]
	public int RandomSeed;

	// Token: 0x04000B73 RID: 2931
	[Token(Token = "0x4000B73")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private bool _enableDynamicMaskVolume;

	// Token: 0x04000B74 RID: 2932
	[Token(Token = "0x4000B74")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float _dynamicMaskRadius;

	// Token: 0x04000B75 RID: 2933
	[Token(Token = "0x4000B75")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private int _dynamicMaskUpdateCount;

	// Token: 0x04000B76 RID: 2934
	[Token(Token = "0x4000B76")]
	[FieldOffset(Offset = "0x70")]
	public GreebleDefinitionDeprecated[] GreebleDefinitions;

	// Token: 0x04000B77 RID: 2935
	[Token(Token = "0x4000B77")]
	[FieldOffset(Offset = "0x78")]
	[HideInInspector]
	[SerializeField]
	public bool _definitionsHaveBeenConverted;

	// Token: 0x04000B78 RID: 2936
	[Token(Token = "0x4000B78")]
	[FieldOffset(Offset = "0x80")]
	public GreebleZone.GlobalDefinitions[] GlobalGreebleDefinitions;

	// Token: 0x04000B79 RID: 2937
	[Token(Token = "0x4000B79")]
	[FieldOffset(Offset = "0x88")]
	[Space]
	[SerializeField]
	public GreebleGlobalDefinition[] _greebleDefinitions;

	// Token: 0x04000B7A RID: 2938
	[Token(Token = "0x4000B7A")]
	[FieldOffset(Offset = "0x90")]
	public Action<int, GameObject> OnSpawned;

	// Token: 0x04000B7B RID: 2939
	[Token(Token = "0x4000B7B")]
	[FieldOffset(Offset = "0x98")]
	private int InstanceCount;

	// Token: 0x04000B7C RID: 2940
	[Token(Token = "0x4000B7C")]
	[FieldOffset(Offset = "0xA0")]
	private GreebleZone.GreebleInstanceData[] InstanceData;

	// Token: 0x04000B7D RID: 2941
	[Token(Token = "0x4000B7D")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[HideInInspector]
	private GreebleZone[] _overlappinGreebleZones;

	// Token: 0x04000B7E RID: 2942
	[Token(Token = "0x4000B7E")]
	[FieldOffset(Offset = "0xB0")]
	private bool _nextVisible;

	// Token: 0x04000B7F RID: 2943
	[Token(Token = "0x4000B7F")]
	[FieldOffset(Offset = "0xB4")]
	private int wsToken;

	// Token: 0x04000B80 RID: 2944
	[Token(Token = "0x4000B80")]
	[FieldOffset(Offset = "0xB8")]
	private int scheduledSpawnIndex;

	// Token: 0x04000B81 RID: 2945
	[Token(Token = "0x4000B81")]
	[FieldOffset(Offset = "0xBC")]
	private Vector3 _position;

	// Token: 0x04000B82 RID: 2946
	[Token(Token = "0x4000B82")]
	[FieldOffset(Offset = "0xC8")]
	private float _raycastCost;

	// Token: 0x04000B83 RID: 2947
	[Token(Token = "0x4000B83")]
	[FieldOffset(Offset = "0xCC")]
	private float _canPlaceValidPointCost;

	// Token: 0x04000B84 RID: 2948
	[Token(Token = "0x4000B84")]
	[FieldOffset(Offset = "0xD0")]
	private PathCreator _pathCreator;

	// Token: 0x04000B85 RID: 2949
	[Token(Token = "0x4000B85")]
	[FieldOffset(Offset = "0xD8")]
	private Bounds _boundingVolume;

	// Token: 0x04000B88 RID: 2952
	[Token(Token = "0x4000B88")]
	[FieldOffset(Offset = "0xF0")]
	[HideInInspector]
	[SerializeField]
	private Color _gizmoColor;

	// Token: 0x04000B8C RID: 2956
	[Token(Token = "0x4000B8C")]
	[FieldOffset(Offset = "0x118")]
	private List<Vector3> _clusterWorldPositions;

	// Token: 0x04000B8D RID: 2957
	[Token(Token = "0x4000B8D")]
	[FieldOffset(Offset = "0x120")]
	private int _clustersGeneratedWithSeed;

	// Token: 0x04000B8E RID: 2958
	[Token(Token = "0x4000B8E")]
	[FieldOffset(Offset = "0x124")]
	private float _spawnCost;

	// Token: 0x04000B8F RID: 2959
	[Token(Token = "0x4000B8F")]
	[FieldOffset(Offset = "0x128")]
	private int _updateMovedMaskIndex;

	// Token: 0x04000B90 RID: 2960
	[Token(Token = "0x4000B90")]
	[FieldOffset(Offset = "0x12C")]
	private Vector3 _dynamicMaskLocation;

	// Token: 0x04000B91 RID: 2961
	[Token(Token = "0x4000B91")]
	[FieldOffset(Offset = "0x138")]
	private Vector3 _cachedPlayerPosition;

	// Token: 0x04000B92 RID: 2962
	[Token(Token = "0x4000B92")]
	[FieldOffset(Offset = "0x4")]
	private static int _cachedTimeOfDaySecondsFrame;

	// Token: 0x04000B93 RID: 2963
	[Token(Token = "0x4000B93")]
	[FieldOffset(Offset = "0x8")]
	private static float _cachedTimeOfDaySeconds;

	// Token: 0x04000B94 RID: 2964
	[Token(Token = "0x4000B94")]
	[FieldOffset(Offset = "0xC")]
	private static RaycastHit _singleHitBuffer;

	// Token: 0x04000B95 RID: 2965
	[Token(Token = "0x4000B95")]
	[FieldOffset(Offset = "0x144")]
	private float _boundingVolumeSqrMag;

	// Token: 0x020001C0 RID: 448
	[Token(Token = "0x20001C0")]
	[Serializable]
	public struct GlobalDefinitions
	{
		// Token: 0x04000B96 RID: 2966
		[Token(Token = "0x4000B96")]
		[FieldOffset(Offset = "0x0")]
		public GreebleGlobalDefinition _globalDefinition;

		// Token: 0x04000B97 RID: 2967
		[Token(Token = "0x4000B97")]
		[FieldOffset(Offset = "0x8")]
		[HideInInspector]
		public bool _override;

		// Token: 0x04000B98 RID: 2968
		[Token(Token = "0x4000B98")]
		[FieldOffset(Offset = "0x9")]
		[HideInInspector]
		public bool _resetOverrideFromGlobal;

		// Token: 0x04000B99 RID: 2969
		[Token(Token = "0x4000B99")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public GreebleDefinitionDeprecated _overrideDefinition;

		// Token: 0x04000B9A RID: 2970
		[Token(Token = "0x4000B9A")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public string _name;
	}

	// Token: 0x020001C1 RID: 449
	[Token(Token = "0x20001C1")]
	public struct GreebleInstanceData
	{
		// Token: 0x04000B9B RID: 2971
		[Token(Token = "0x4000B9B")]
		[FieldOffset(Offset = "0x0")]
		public bool Spawned;

		// Token: 0x04000B9C RID: 2972
		[Token(Token = "0x4000B9C")]
		[FieldOffset(Offset = "0x1")]
		public bool Destroyed;

		// Token: 0x04000B9D RID: 2973
		[Token(Token = "0x4000B9D")]
		[FieldOffset(Offset = "0x4")]
		public float CreationTime;

		// Token: 0x04000B9E RID: 2974
		[Token(Token = "0x4000B9E")]
		[FieldOffset(Offset = "0x8")]
		public int DefinitionIndex;

		// Token: 0x04000B9F RID: 2975
		[Token(Token = "0x4000B9F")]
		[FieldOffset(Offset = "0xC")]
		public int PrefabVariationIndex;

		// Token: 0x04000BA0 RID: 2976
		[Token(Token = "0x4000BA0")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 ScaleMultiplier;

		// Token: 0x04000BA1 RID: 2977
		[Token(Token = "0x4000BA1")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 Position;
	}

	// Token: 0x020001C2 RID: 450
	[Token(Token = "0x20001C2")]
	private struct PlacementResults
	{
		// Token: 0x04000BA2 RID: 2978
		[Token(Token = "0x4000BA2")]
		[FieldOffset(Offset = "0x0")]
		public Ray Ray;

		// Token: 0x04000BA3 RID: 2979
		[Token(Token = "0x4000BA3")]
		[FieldOffset(Offset = "0x18")]
		public float Distance;

		// Token: 0x04000BA4 RID: 2980
		[Token(Token = "0x4000BA4")]
		[FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;
	}
}
