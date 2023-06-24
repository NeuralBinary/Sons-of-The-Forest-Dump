using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Lodding
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[AddComponentMenu("Sons/Lodding/CustomBillboard")]
	public class CustomBillboard : MonoBehaviour
	{
		// Token: 0x06000005 RID: 5 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x30B8A80", Offset = "0x30B7080", VA = "0x1830B8A80")]
		private bool HasMeshDivisions()
		{
			return default(bool);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x30B8A90", Offset = "0x30B7090", VA = "0x1830B8A90")]
		public static void SetIgnoreBillboardChanges(bool value)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x5EA850", Offset = "0x5E8E50", VA = "0x1805EA850")]
		public void SetFadeNearDistance(float value)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x623B90", Offset = "0x622190", VA = "0x180623B90")]
		public void SetFadeFarDistance(float value)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x30B8AF0", Offset = "0x30B70F0", VA = "0x1830B8AF0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x30B8B50", Offset = "0x30B7150", VA = "0x1830B8B50")]
		private void OnEnable()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x30B8D10", Offset = "0x30B7310", VA = "0x1830B8D10")]
		private void OnDisable()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x30B8E60", Offset = "0x30B7460", VA = "0x1830B8E60")]
		private void Awake()
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x30B93D0", Offset = "0x30B79D0", VA = "0x1830B93D0")]
		private void RefreshMaterialInstance()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x30B98B0", Offset = "0x30B7EB0", VA = "0x1830B98B0")]
		private void DestroyOldInstance()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x30B99E0", Offset = "0x30B7FE0", VA = "0x1830B99E0")]
		private void AssignMaterialToBuckets(Material materialInstance)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x30B9B70", Offset = "0x30B8170", VA = "0x1830B9B70")]
		private Material CreateMaterialInstance()
		{
			return null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x30B9D90", Offset = "0x30B8390", VA = "0x1830B9D90")]
		private Material GetFirstBucketInstancedMaterial()
		{
			return null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x30B9E30", Offset = "0x30B8430", VA = "0x1830B9E30")]
		private Material GetSharedMaterial()
		{
			return null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x30BA050", Offset = "0x30B8650", VA = "0x1830BA050")]
		private Material GetFirstBucketSharedMaterial()
		{
			return null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x30BA0F0", Offset = "0x30B86F0", VA = "0x1830BA0F0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x30BA480", Offset = "0x30B8A80", VA = "0x1830BA480")]
		private void UpdateBuckets(int startIndex, int endIndex)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x30BA540", Offset = "0x30B8B40", VA = "0x1830BA540")]
		private void UpdateStipplingRange()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x30BA5B0", Offset = "0x30B8BB0", VA = "0x1830BA5B0")]
		private void UpdateVisibility(int startIndex, int endIndex)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x30BA750", Offset = "0x30B8D50", VA = "0x1830BA750")]
		private float CalculateDistanceToBucketCenter(int bucketIndex, Vector3 position)
		{
			return 0f;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x30BA840", Offset = "0x30B8E40", VA = "0x1830BA840")]
		private void SetShaderStippleRange(Vector4 value)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x30BAAC0", Offset = "0x30B90C0", VA = "0x1830BAAC0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x30BB0E0", Offset = "0x30B96E0", VA = "0x1830BB0E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x30BB4A0", Offset = "0x30B9AA0", VA = "0x1830BB4A0")]
		internal static void ClearAsset(UnityEngine.Object target)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x30BB600", Offset = "0x30B9C00", VA = "0x1830BB600")]
		public int Register(Vector3 position, Quaternion rotation, float scale)
		{
			return 0;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x30BB700", Offset = "0x30B9D00", VA = "0x1830BB700")]
		public int RegisterCache(Vector3 position, Quaternion rotation, float scale)
		{
			return 0;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x30BB800", Offset = "0x30B9E00", VA = "0x1830BB800")]
		private int GetPackedIndex(int bucketIndex, int subIndex)
		{
			return 0;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x30BB810", Offset = "0x30B9E10", VA = "0x1830BB810")]
		private void GetUnpackedIndexes(int source, out int bucketIndex, out int subIndex)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x30BB8A0", Offset = "0x30B9EA0", VA = "0x1830BB8A0")]
		private int GetBucketIndex(Vector3 position)
		{
			return 0;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x30BB960", Offset = "0x30B9F60", VA = "0x1830BB960")]
		private float CalculateBucketSize()
		{
			return 0f;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x30BB980", Offset = "0x30B9F80", VA = "0x1830BB980")]
		private void CreateMissingBucketObjects()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x30BBAB0", Offset = "0x30BA0B0", VA = "0x1830BBAB0")]
		private void InitializeBuckets(bool skipObjects = false)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x30BC110", Offset = "0x30BA710", VA = "0x1830BC110")]
		private void FixBucketCount(int count)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x30BC2D0", Offset = "0x30BA8D0", VA = "0x1830BC2D0")]
		public void SetPosition(int index, Vector3 position)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x30BC3D0", Offset = "0x30BA9D0", VA = "0x1830BC3D0")]
		internal static float GetYRotation(Quaternion rotation)
		{
			return 0f;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x30BC4C0", Offset = "0x30BAAC0", VA = "0x1830BC4C0")]
		public void SetAlive(int index, bool alive)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x30BC5E0", Offset = "0x30BABE0", VA = "0x1830BC5E0")]
		public Transform GetLightProbeAnchorOverride()
		{
			return null;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
		public bool GetUsesHorizontal()
		{
			return default(bool);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0")]
		public float GetHorizontalOffset()
		{
			return 0f;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
		public float GetHorizontalSize()
		{
			return 0f;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x76BE00", Offset = "0x76A400", VA = "0x18076BE00")]
		public LodSettingsTypeEnum GetBillboardType()
		{
			return LodSettingsTypeEnum.Trees;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x30BC630", Offset = "0x30BAC30", VA = "0x1830BC630")]
		public void SetActive(bool activeValue)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x30BC790", Offset = "0x30BAD90", VA = "0x1830BC790")]
		public void SetSkipBuildCount(int skipBuildCount)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x30BC8F0", Offset = "0x30BAEF0", VA = "0x1830BC8F0")]
		public void ClearCacheData()
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x30BCB80", Offset = "0x30BB180", VA = "0x1830BCB80")]
		public void InitializeCacheData()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x30BCB90", Offset = "0x30BB190", VA = "0x1830BCB90")]
		public void SetDirty()
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x30BCD10", Offset = "0x30BB310", VA = "0x1830BCD10")]
		public CustomBillboard()
		{
		}

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x20")]
		[Header("Editing")]
		[SerializeField]
		private bool _deinstanceMaterial;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Header("Stippling Settings:")]
		[FormerlySerializedAs("FadeNearDistance")]
		private float _fadeNearDistance;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("FadeFarDistance")]
		private float _fadeFarDistance;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x2C")]
		[FormerlySerializedAs("FarKillDistance")]
		[SerializeField]
		private float _farKillDistance;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x30")]
		[Header("Horizontal Billboard Settings:")]
		[SerializeField]
		[FormerlySerializedAs("UsesHorizontal")]
		private bool _usesHorizontal;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x34")]
		[FormerlySerializedAs("HorizontalOffset")]
		[SerializeField]
		private float _horizontalOffset;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[FormerlySerializedAs("HorizontalSize")]
		private float _horizontalSize;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int _skipBuildCount;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private CustomBillboard.BillboardType _billboardRangeType;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private LodSettingsTypeEnum _billboardType;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _useMaterialInstance;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x4C")]
		[FormerlySerializedAs("_meshDivisions")]
		[SerializeField]
		private int _bucketDivisions;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _maxDimension;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _minDimension;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int _stipplingUpdateRate;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private int _bucketFrameUpdateCount;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly Vector2 Uv0;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly Vector2 Uv1;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly Vector2 Uv2;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly Vector2 Uv3;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x60")]
		private bool _positionChange;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x61")]
		private bool _aliveChange;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x62")]
		private bool _usingHorizontal;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x63")]
		private bool _rebuildMesh;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int StippleRangeSqrId;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int MeshTreeStippleNear;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int MeshTreeStippleFar;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x2C")]
		private static readonly int MeshSmallTreeStippleNear;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x30")]
		private static readonly int MeshSmallTreeStippleFar;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x34")]
		private static readonly int MeshBushStippleNear;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x38")]
		private static readonly int MeshBushStippleFar;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x3C")]
		private static readonly int MeshRockStippleNear;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x40")]
		private static readonly int MeshRockStippleFar;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<SubBillboardData> _meshBuckets;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x70")]
		private Material _materialInstance;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x78")]
		private Material _materialAsset;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x48")]
		private static Transform _lightProbeAnchorOverride;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x80")]
		private Vector4 _stippleRangeSqrDefault;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x90")]
		private bool _stippleRangeSqrStored;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x94")]
		private Vector4 _finalStipplingRange;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0xA4")]
		private int _maxRegisteredCount;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x50")]
		private static bool _ignoreBillboardChanges;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		private const int RegisterIndexShift = 9;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x54")]
		private static readonly int RegisterIndexShiftMax;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x58")]
		private static readonly int RegisterIndexShiftMask;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0xA8")]
		private MeshRenderer _sourceMeshRenderer;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0xB0")]
		private bool _noSourceMeshRenderer;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x60")]
		private static ProfilerMarker _profilerMarkerLateUpdate;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x68")]
		private static ProfilerMarker _profilerMarkerUpdateStipplingRange;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x70")]
		private static ProfilerMarker _profilerMarkerUpdateVisibility;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0xB4")]
		private int _updateStartIndex;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0xB8")]
		private int _updateEndIndex;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0xBC")]
		private int _stipplingUpdateOffset;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0xC0")]
		private int _currentRegisteredCount;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0xC4")]
		private bool _isActive;

		// Token: 0x02000006 RID: 6
		[Token(Token = "0x2000006")]
		public enum BillboardType
		{
			// Token: 0x04000040 RID: 64
			[Token(Token = "0x4000040")]
			Tree,
			// Token: 0x04000041 RID: 65
			[Token(Token = "0x4000041")]
			SmallTree,
			// Token: 0x04000042 RID: 66
			[Token(Token = "0x4000042")]
			Rock,
			// Token: 0x04000043 RID: 67
			[Token(Token = "0x4000043")]
			Bush,
			// Token: 0x04000044 RID: 68
			[Token(Token = "0x4000044")]
			CONVERTED
		}
	}
}
