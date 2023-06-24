using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using PathCreation;
using TheForest.Utils.WorkSchedulerInterfaces;
using UnityEngine;

// Token: 0x020001BE RID: 446
[Token(Token = "0x20001BE")]
public class GreebleZone : MonoBehaviour, IThreadSafeTask
{
	// Token: 0x17000181 RID: 385
	// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000181")]
	public List<GreebleZoneVolume> Volumes
	{
		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000182 RID: 386
	// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x000053B8 File Offset: 0x000035B8
	// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000182")]
	public static bool AlwaysShowGizmos
	{
		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0x36F1680", Offset = "0x36EFC80", VA = "0x1836F1680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000CE6")]
		[Address(RVA = "0x36F16C0", Offset = "0x36EFCC0", VA = "0x1836F16C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000183 RID: 387
	// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x000053D0 File Offset: 0x000035D0
	// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000183")]
	public static bool WireFrameGizmos
	{
		[Token(Token = "0x6000CE7")]
		[Address(RVA = "0x36F1700", Offset = "0x36EFD00", VA = "0x1836F1700")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000CE8")]
		[Address(RVA = "0x36F1740", Offset = "0x36EFD40", VA = "0x1836F1740")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000184 RID: 388
	// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x000053E8 File Offset: 0x000035E8
	[Token(Token = "0x17000184")]
	public Bounds Bounds
	{
		[Token(Token = "0x6000CE9")]
		[Address(RVA = "0x36F1780", Offset = "0x36EFD80", VA = "0x1836F1780")]
		get
		{
			return default(Bounds);
		}
	}

	// Token: 0x17000185 RID: 389
	// (get) Token: 0x06000CEA RID: 3306 RVA: 0x00005400 File Offset: 0x00003600
	[Token(Token = "0x17000185")]
	public int MaxInstancesModified
	{
		[Token(Token = "0x6000CEA")]
		[Address(RVA = "0x7849B0", Offset = "0x782FB0", VA = "0x1807849B0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000186 RID: 390
	// (get) Token: 0x06000CEB RID: 3307 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000CEC RID: 3308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000186")]
	public GreebleZonesManager.GZData ZoneData
	{
		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0x8DF480", Offset = "0x8DDA80", VA = "0x1808DF480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x8DF490", Offset = "0x8DDA90", VA = "0x1808DF490")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000187 RID: 391
	// (get) Token: 0x06000CED RID: 3309 RVA: 0x00005418 File Offset: 0x00003618
	// (set) Token: 0x06000CEE RID: 3310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000187")]
	public bool CurrentlyVisible
	{
		[Token(Token = "0x6000CED")]
		[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0x7AAFD0", Offset = "0x7A95D0", VA = "0x1807AAFD0")]
		private set
		{
		}
	}

	// Token: 0x17000188 RID: 392
	// (get) Token: 0x06000CEF RID: 3311 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000CF0 RID: 3312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000188")]
	public GameObject[] Instances
	{
		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x8DF4F0", Offset = "0x8DDAF0", VA = "0x1808DF4F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000CF0")]
		[Address(RVA = "0x8DF500", Offset = "0x8DDB00", VA = "0x1808DF500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000189 RID: 393
	// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x00005430 File Offset: 0x00003630
	// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000189")]
	public bool ShouldDoMainThreadRefresh
	{
		[Token(Token = "0x6000CF1")]
		[Address(RVA = "0x257EC60", Offset = "0x257D260", VA = "0x18257EC60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000CF2")]
		[Address(RVA = "0x257EC70", Offset = "0x257D270", VA = "0x18257EC70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x06000CF3 RID: 3315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF3")]
	[Address(RVA = "0x36F17A0", Offset = "0x36EFDA0", VA = "0x1836F17A0")]
	private void Awake()
	{
	}

	// Token: 0x06000CF4 RID: 3316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF4")]
	[Address(RVA = "0x36F1960", Offset = "0x36EFF60", VA = "0x1836F1960")]
	private void OnEnable()
	{
	}

	// Token: 0x06000CF5 RID: 3317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF5")]
	[Address(RVA = "0x36F1D80", Offset = "0x36F0380", VA = "0x1836F1D80")]
	private void OnDisable()
	{
	}

	// Token: 0x06000CF6 RID: 3318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF6")]
	[Address(RVA = "0x36F1DC0", Offset = "0x36F03C0", VA = "0x1836F1DC0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000CF7 RID: 3319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF7")]
	[Address(RVA = "0x36F1F10", Offset = "0x36F0510", VA = "0x1836F1F10")]
	public void RespawnAll()
	{
	}

	// Token: 0x06000CF8 RID: 3320 RVA: 0x00005448 File Offset: 0x00003648
	[Token(Token = "0x6000CF8")]
	[Address(RVA = "0x8EC050", Offset = "0x8EA650", VA = "0x1808EC050")]
	private int GetModifiedInstanceCount(int rawCount)
	{
		return 0;
	}

	// Token: 0x06000CF9 RID: 3321 RVA: 0x00005460 File Offset: 0x00003660
	[Token(Token = "0x6000CF9")]
	[Address(RVA = "0x36F1F80", Offset = "0x36F0580", VA = "0x1836F1F80")]
	private int GetRandomSeed()
	{
		return 0;
	}

	// Token: 0x06000CFA RID: 3322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFA")]
	[Address(RVA = "0x36F2090", Offset = "0x36F0690", VA = "0x1836F2090")]
	private void RegenerateSeed()
	{
	}

	// Token: 0x06000CFB RID: 3323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFB")]
	[Address(RVA = "0x36F21F0", Offset = "0x36F07F0", VA = "0x1836F21F0")]
	private void ScheduledSpawn()
	{
	}

	// Token: 0x06000CFC RID: 3324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFC")]
	[Address(RVA = "0x36F22A0", Offset = "0x36F08A0", VA = "0x1836F22A0")]
	private void SpawnIndex(int index, bool forPreview = false)
	{
	}

	// Token: 0x06000CFD RID: 3325 RVA: 0x00005478 File Offset: 0x00003678
	[Token(Token = "0x6000CFD")]
	[Address(RVA = "0x36F3230", Offset = "0x36F1830", VA = "0x1836F3230")]
	private static float CachedElapsedGameTime()
	{
		return 0f;
	}

	// Token: 0x06000CFE RID: 3326 RVA: 0x00005490 File Offset: 0x00003690
	[Token(Token = "0x6000CFE")]
	[Address(RVA = "0x36F33A0", Offset = "0x36F19A0", VA = "0x1836F33A0")]
	private bool DefinitionIndex(GreebleGlobalDefinition.SpawnObjectType prefabVariation, out int definitionIndex, out int variationIndex)
	{
		return default(bool);
	}

	// Token: 0x06000CFF RID: 3327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFF")]
	[Address(RVA = "0x36F34B0", Offset = "0x36F1AB0", VA = "0x1836F34B0")]
	private void SetDestroyed(int index)
	{
	}

	// Token: 0x06000D00 RID: 3328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D00")]
	[Address(RVA = "0x36F3510", Offset = "0x36F1B10", VA = "0x1836F3510")]
	private static void ApplyModifiers(GameObject affectedObject, GreebleGlobalDefinition greebleDefinition)
	{
	}

	// Token: 0x06000D01 RID: 3329 RVA: 0x000054A8 File Offset: 0x000036A8
	[Token(Token = "0x6000D01")]
	[Address(RVA = "0x36F36D0", Offset = "0x36F1CD0", VA = "0x1836F36D0")]
	private bool TryPlaceInstance(GreebleGlobalDefinition greebleDefinition, out GreebleZone.PlacementResults results)
	{
		return default(bool);
	}

	// Token: 0x06000D02 RID: 3330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D02")]
	[Address(RVA = "0x36F48E0", Offset = "0x36F2EE0", VA = "0x1836F48E0")]
	private void TryPlaceInstanceBox(ref float distance, out Vector3 worldSpacePoint, out Vector3 worldSpaceDirection)
	{
	}

	// Token: 0x06000D03 RID: 3331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D03")]
	[Address(RVA = "0x36F4E80", Offset = "0x36F3480", VA = "0x1836F4E80")]
	private void TryPlaceInstanceSphere(GreebleGlobalDefinition greebleDefinition, ref Vector3 worldSpacePoint, out Vector3 worldSpaceDirection, out float distance)
	{
	}

	// Token: 0x06000D04 RID: 3332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D04")]
	[Address(RVA = "0x36F5A00", Offset = "0x36F4000", VA = "0x1836F5A00")]
	private void TryPlaceInstanceSpline(List<Transform> insideVolumes, ref Vector3 worldSpacePoint, out Vector3 worldSpaceDirection, out float distance)
	{
	}

	// Token: 0x06000D05 RID: 3333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D05")]
	[Address(RVA = "0x36F6400", Offset = "0x36F4A00", VA = "0x1836F6400")]
	private void PreviewInstances()
	{
	}

	// Token: 0x06000D06 RID: 3334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D06")]
	[Address(RVA = "0x36F6410", Offset = "0x36F4A10", VA = "0x1836F6410")]
	public void SpawnAll(bool forPreview = false)
	{
	}

	// Token: 0x06000D07 RID: 3335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D07")]
	[Address(RVA = "0x36F6E80", Offset = "0x36F5480", VA = "0x1836F6E80")]
	public void DespawnAll()
	{
	}

	// Token: 0x06000D08 RID: 3336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D08")]
	[Address(RVA = "0x36F6EF0", Offset = "0x36F54F0", VA = "0x1836F6EF0")]
	private void DespawnIndex(int i)
	{
	}

	// Token: 0x06000D09 RID: 3337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D09")]
	[Address(RVA = "0x36F72A0", Offset = "0x36F58A0", VA = "0x1836F72A0")]
	private void ScaleBasedOffDensity()
	{
	}

	// Token: 0x06000D0A RID: 3338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D0A")]
	[Address(RVA = "0x36F7820", Offset = "0x36F5E20", VA = "0x1836F7820", Slot = "6")]
	public void ThreadedRefresh()
	{
	}

	// Token: 0x06000D0B RID: 3339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D0B")]
	[Address(RVA = "0x36F7A70", Offset = "0x36F6070", VA = "0x1836F7A70", Slot = "7")]
	public void MainThreadRefresh()
	{
	}

	// Token: 0x06000D0C RID: 3340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D0C")]
	[Address(RVA = "0x36F7AC0", Offset = "0x36F60C0", VA = "0x1836F7AC0")]
	private void UpdateMovedMaskVolumes()
	{
	}

	// Token: 0x06000D0D RID: 3341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D0D")]
	[Address(RVA = "0x36F7E60", Offset = "0x36F6460", VA = "0x1836F7E60")]
	private void UpdateDynamicMaskLocation()
	{
	}

	// Token: 0x06000D0E RID: 3342 RVA: 0x000054C0 File Offset: 0x000036C0
	[Token(Token = "0x6000D0E")]
	[Address(RVA = "0x36F8180", Offset = "0x36F6780", VA = "0x1836F8180")]
	private bool DynamicMaskContains(Vector3 instancePos)
	{
		return default(bool);
	}

	// Token: 0x06000D0F RID: 3343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D0F")]
	[Address(RVA = "0x36F81F0", Offset = "0x36F67F0", VA = "0x1836F81F0")]
	private void UpdateVisibility()
	{
	}

	// Token: 0x06000D10 RID: 3344 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D10")]
	[Address(RVA = "0x36F8230", Offset = "0x36F6830", VA = "0x1836F8230")]
	public GreebleGlobalDefinition GetDefinitionAtInstanceIndex(int index)
	{
		return null;
	}

	// Token: 0x06000D11 RID: 3345 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D11")]
	[Address(RVA = "0x36F8320", Offset = "0x36F6920", VA = "0x1836F8320")]
	public GreebleGlobalDefinition.SpawnObjectType GetObjectVariationAtInstanceIndex(int index)
	{
		return null;
	}

	// Token: 0x06000D12 RID: 3346 RVA: 0x000054D8 File Offset: 0x000036D8
	[Token(Token = "0x6000D12")]
	[Address(RVA = "0x36F8450", Offset = "0x36F6A50", VA = "0x1836F8450")]
	public Vector3 GetInstanceScaleMultiplier(int index)
	{
		return default(Vector3);
	}

	// Token: 0x06000D13 RID: 3347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D13")]
	[Address(RVA = "0x36F8500", Offset = "0x36F6B00", VA = "0x1836F8500")]
	public void SetGizmoColor(Color color)
	{
	}

	// Token: 0x06000D14 RID: 3348 RVA: 0x000054F0 File Offset: 0x000036F0
	[Token(Token = "0x6000D14")]
	[Address(RVA = "0x2A2C0D0", Offset = "0x2A2A6D0", VA = "0x182A2C0D0")]
	public Color GetGizmoColor()
	{
		return default(Color);
	}

	// Token: 0x06000D15 RID: 3349 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D15")]
	[Address(RVA = "0x36F8510", Offset = "0x36F6B10", VA = "0x1836F8510", Slot = "8")]
	public string GetTaskName()
	{
		return null;
	}

	// Token: 0x06000D16 RID: 3350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D16")]
	[Address(RVA = "0x36F8540", Offset = "0x36F6B40", VA = "0x1836F8540")]
	public GreebleZone()
	{
	}

	// Token: 0x04000B90 RID: 2960
	[Token(Token = "0x4000B90")]
	private const string PreviewSpawnedInstanceTag = "GreeblePreview";

	// Token: 0x04000B91 RID: 2961
	[Token(Token = "0x4000B91")]
	[FieldOffset(Offset = "0x20")]
	private bool _currentlyVisible;

	// Token: 0x04000B92 RID: 2962
	[Token(Token = "0x4000B92")]
	[FieldOffset(Offset = "0x21")]
	private bool _allSpawned;

	// Token: 0x04000B93 RID: 2963
	[Token(Token = "0x4000B93")]
	[FieldOffset(Offset = "0x22")]
	public bool MarkDirtyForBake;

	// Token: 0x04000B94 RID: 2964
	[Token(Token = "0x4000B94")]
	[FieldOffset(Offset = "0x23")]
	public bool MpSync;

	// Token: 0x04000B95 RID: 2965
	[Token(Token = "0x4000B95")]
	[FieldOffset(Offset = "0x24")]
	public GreebleShape Shape;

	// Token: 0x04000B96 RID: 2966
	[Token(Token = "0x4000B96")]
	[FieldOffset(Offset = "0x28")]
	[Range(1f, 1000f)]
	public float Radius;

	// Token: 0x04000B97 RID: 2967
	[Token(Token = "0x4000B97")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 Size;

	// Token: 0x04000B98 RID: 2968
	[Token(Token = "0x4000B98")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<GreebleZoneVolume> _volumes;

	// Token: 0x04000B99 RID: 2969
	[Token(Token = "0x4000B99")]
	[FieldOffset(Offset = "0x40")]
	public bool SnapHeightAboveTerrain;

	// Token: 0x04000B9A RID: 2970
	[Token(Token = "0x4000B9A")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _snapHeightOffset;

	// Token: 0x04000B9B RID: 2971
	[Token(Token = "0x4000B9B")]
	[FieldOffset(Offset = "0x48")]
	public bool AllowRegrowth;

	// Token: 0x04000B9C RID: 2972
	[Token(Token = "0x4000B9C")]
	[FieldOffset(Offset = "0x49")]
	public bool ShowPreviewInstancesInInspector;

	// Token: 0x04000B9D RID: 2973
	[Token(Token = "0x4000B9D")]
	[FieldOffset(Offset = "0x4C")]
	[Range(1f, 100000f)]
	[SerializeField]
	private int MaxInstances;

	// Token: 0x04000B9E RID: 2974
	[Token(Token = "0x4000B9E")]
	[FieldOffset(Offset = "0x50")]
	[Tooltip("This is the number of attempts which will be made when a spawn index fails to find a valid placement position.")]
	[SerializeField]
	[Range(0f, 100f)]
	private int _placementRetryAttempts;

	// Token: 0x04000B9F RID: 2975
	[Token(Token = "0x4000B9F")]
	[FieldOffset(Offset = "0x54")]
	[Range(0f, 500f)]
	public float ToggleDistance;

	// Token: 0x04000BA0 RID: 2976
	[Token(Token = "0x4000BA0")]
	[FieldOffset(Offset = "0x58")]
	public GreebleRayDirection Direction;

	// Token: 0x04000BA1 RID: 2977
	[Token(Token = "0x4000BA1")]
	[FieldOffset(Offset = "0x5C")]
	[Range(0f, 100000f)]
	public int RandomSeed;

	// Token: 0x04000BA2 RID: 2978
	[Token(Token = "0x4000BA2")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private bool _enableDynamicMaskVolume;

	// Token: 0x04000BA3 RID: 2979
	[Token(Token = "0x4000BA3")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float _dynamicMaskRadius;

	// Token: 0x04000BA4 RID: 2980
	[Token(Token = "0x4000BA4")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private int _dynamicMaskUpdateCount;

	// Token: 0x04000BA5 RID: 2981
	[Token(Token = "0x4000BA5")]
	[FieldOffset(Offset = "0x70")]
	public GreebleDefinitionDeprecated[] GreebleDefinitions;

	// Token: 0x04000BA6 RID: 2982
	[Token(Token = "0x4000BA6")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[HideInInspector]
	public bool _definitionsHaveBeenConverted;

	// Token: 0x04000BA7 RID: 2983
	[Token(Token = "0x4000BA7")]
	[FieldOffset(Offset = "0x80")]
	public GreebleZone.GlobalDefinitions[] GlobalGreebleDefinitions;

	// Token: 0x04000BA8 RID: 2984
	[Token(Token = "0x4000BA8")]
	[FieldOffset(Offset = "0x88")]
	[Space]
	[SerializeField]
	public GreebleGlobalDefinition[] _greebleDefinitions;

	// Token: 0x04000BA9 RID: 2985
	[Token(Token = "0x4000BA9")]
	[FieldOffset(Offset = "0x90")]
	public Action<int, GameObject> OnSpawned;

	// Token: 0x04000BAA RID: 2986
	[Token(Token = "0x4000BAA")]
	[FieldOffset(Offset = "0x98")]
	private int InstanceCount;

	// Token: 0x04000BAB RID: 2987
	[Token(Token = "0x4000BAB")]
	[FieldOffset(Offset = "0xA0")]
	private GreebleZone.GreebleInstanceData[] InstanceData;

	// Token: 0x04000BAC RID: 2988
	[Token(Token = "0x4000BAC")]
	[FieldOffset(Offset = "0xA8")]
	[HideInInspector]
	[SerializeField]
	private GreebleZone[] _overlappinGreebleZones;

	// Token: 0x04000BAD RID: 2989
	[Token(Token = "0x4000BAD")]
	[FieldOffset(Offset = "0xB0")]
	private bool _nextVisible;

	// Token: 0x04000BAE RID: 2990
	[Token(Token = "0x4000BAE")]
	[FieldOffset(Offset = "0xB4")]
	private int wsToken;

	// Token: 0x04000BAF RID: 2991
	[Token(Token = "0x4000BAF")]
	[FieldOffset(Offset = "0xB8")]
	private int scheduledSpawnIndex;

	// Token: 0x04000BB0 RID: 2992
	[Token(Token = "0x4000BB0")]
	[FieldOffset(Offset = "0xBC")]
	private Vector3 _position;

	// Token: 0x04000BB1 RID: 2993
	[Token(Token = "0x4000BB1")]
	[FieldOffset(Offset = "0xC8")]
	private float _raycastCost;

	// Token: 0x04000BB2 RID: 2994
	[Token(Token = "0x4000BB2")]
	[FieldOffset(Offset = "0xCC")]
	private float _canPlaceValidPointCost;

	// Token: 0x04000BB3 RID: 2995
	[Token(Token = "0x4000BB3")]
	[FieldOffset(Offset = "0xD0")]
	private PathCreator _pathCreator;

	// Token: 0x04000BB4 RID: 2996
	[Token(Token = "0x4000BB4")]
	[FieldOffset(Offset = "0xD8")]
	private Bounds _boundingVolume;

	// Token: 0x04000BB7 RID: 2999
	[Token(Token = "0x4000BB7")]
	[FieldOffset(Offset = "0xF0")]
	[HideInInspector]
	[SerializeField]
	private Color _gizmoColor;

	// Token: 0x04000BBB RID: 3003
	[Token(Token = "0x4000BBB")]
	[FieldOffset(Offset = "0x118")]
	private List<Vector3> _clusterWorldPositions;

	// Token: 0x04000BBC RID: 3004
	[Token(Token = "0x4000BBC")]
	[FieldOffset(Offset = "0x120")]
	private int _clustersGeneratedWithSeed;

	// Token: 0x04000BBD RID: 3005
	[Token(Token = "0x4000BBD")]
	[FieldOffset(Offset = "0x124")]
	private float _spawnCost;

	// Token: 0x04000BBE RID: 3006
	[Token(Token = "0x4000BBE")]
	[FieldOffset(Offset = "0x128")]
	private int _updateMovedMaskIndex;

	// Token: 0x04000BBF RID: 3007
	[Token(Token = "0x4000BBF")]
	[FieldOffset(Offset = "0x12C")]
	private Vector3 _dynamicMaskLocation;

	// Token: 0x04000BC0 RID: 3008
	[Token(Token = "0x4000BC0")]
	[FieldOffset(Offset = "0x138")]
	private Vector3 _cachedPlayerPosition;

	// Token: 0x04000BC1 RID: 3009
	[Token(Token = "0x4000BC1")]
	[FieldOffset(Offset = "0x4")]
	private static int _cachedTimeOfDaySecondsFrame;

	// Token: 0x04000BC2 RID: 3010
	[Token(Token = "0x4000BC2")]
	[FieldOffset(Offset = "0x8")]
	private static float _cachedTimeOfDaySeconds;

	// Token: 0x04000BC3 RID: 3011
	[Token(Token = "0x4000BC3")]
	[FieldOffset(Offset = "0xC")]
	private static RaycastHit _singleHitBuffer;

	// Token: 0x04000BC4 RID: 3012
	[Token(Token = "0x4000BC4")]
	[FieldOffset(Offset = "0x144")]
	private float _boundingVolumeSqrMag;

	// Token: 0x020001BF RID: 447
	[Token(Token = "0x20001BF")]
	[Serializable]
	public struct GlobalDefinitions
	{
		// Token: 0x04000BC5 RID: 3013
		[Token(Token = "0x4000BC5")]
		[FieldOffset(Offset = "0x0")]
		public GreebleGlobalDefinition _globalDefinition;

		// Token: 0x04000BC6 RID: 3014
		[Token(Token = "0x4000BC6")]
		[FieldOffset(Offset = "0x8")]
		[HideInInspector]
		public bool _override;

		// Token: 0x04000BC7 RID: 3015
		[Token(Token = "0x4000BC7")]
		[FieldOffset(Offset = "0x9")]
		[HideInInspector]
		public bool _resetOverrideFromGlobal;

		// Token: 0x04000BC8 RID: 3016
		[Token(Token = "0x4000BC8")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public GreebleDefinitionDeprecated _overrideDefinition;

		// Token: 0x04000BC9 RID: 3017
		[Token(Token = "0x4000BC9")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public string _name;
	}

	// Token: 0x020001C0 RID: 448
	[Token(Token = "0x20001C0")]
	public struct GreebleInstanceData
	{
		// Token: 0x04000BCA RID: 3018
		[Token(Token = "0x4000BCA")]
		[FieldOffset(Offset = "0x0")]
		public bool Spawned;

		// Token: 0x04000BCB RID: 3019
		[Token(Token = "0x4000BCB")]
		[FieldOffset(Offset = "0x1")]
		public bool Destroyed;

		// Token: 0x04000BCC RID: 3020
		[Token(Token = "0x4000BCC")]
		[FieldOffset(Offset = "0x4")]
		public float CreationTime;

		// Token: 0x04000BCD RID: 3021
		[Token(Token = "0x4000BCD")]
		[FieldOffset(Offset = "0x8")]
		public int DefinitionIndex;

		// Token: 0x04000BCE RID: 3022
		[Token(Token = "0x4000BCE")]
		[FieldOffset(Offset = "0xC")]
		public int PrefabVariationIndex;

		// Token: 0x04000BCF RID: 3023
		[Token(Token = "0x4000BCF")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 ScaleMultiplier;

		// Token: 0x04000BD0 RID: 3024
		[Token(Token = "0x4000BD0")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 Position;
	}

	// Token: 0x020001C1 RID: 449
	[Token(Token = "0x20001C1")]
	private struct PlacementResults
	{
		// Token: 0x04000BD1 RID: 3025
		[Token(Token = "0x4000BD1")]
		[FieldOffset(Offset = "0x0")]
		public Ray Ray;

		// Token: 0x04000BD2 RID: 3026
		[Token(Token = "0x4000BD2")]
		[FieldOffset(Offset = "0x18")]
		public float Distance;

		// Token: 0x04000BD3 RID: 3027
		[Token(Token = "0x4000BD3")]
		[FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;
	}
}
