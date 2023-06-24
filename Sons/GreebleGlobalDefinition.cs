using System;
using System.Collections.Generic;
using Endnight.Types;
using Endnight.Utilities;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001B1 RID: 433
[Token(Token = "0x20001B1")]
[CreateAssetMenu(fileName = "GreebleGlobalDefinition", menuName = "Sons/Environment/GreebleDefinition", order = 0)]
public class GreebleGlobalDefinition : ScriptableObject
{
	// Token: 0x1700017E RID: 382
	// (get) Token: 0x06000C9D RID: 3229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700017E")]
	public List<GreebleGlobalDefinition.SpawnObjectType> ObjectVariations
	{
		[Token(Token = "0x6000C9D")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000C9E RID: 3230 RVA: 0x000050E8 File Offset: 0x000032E8
	[Token(Token = "0x6000C9E")]
	[Address(RVA = "0x36E9A80", Offset = "0x36E8080", VA = "0x1836E9A80")]
	public bool IsAgeAppropriate(float ageInMinutes)
	{
		return default(bool);
	}

	// Token: 0x06000C9F RID: 3231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9F")]
	[Address(RVA = "0x36E9B40", Offset = "0x36E8140", VA = "0x1836E9B40")]
	public GreebleGlobalDefinition()
	{
	}

	// Token: 0x04000B1C RID: 2844
	[Token(Token = "0x4000B1C")]
	[FieldOffset(Offset = "0x18")]
	public List<NamedGameObject> PrefabVariations;

	// Token: 0x04000B1D RID: 2845
	[Token(Token = "0x4000B1D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<GreebleGlobalDefinition.SpawnObjectType> _objectVariations;

	// Token: 0x04000B1E RID: 2846
	[Token(Token = "0x4000B1E")]
	[FieldOffset(Offset = "0x28")]
	[Range(1f, 100f)]
	[Tooltip("Determines the chance that this definition is used over other definitions within this zone.")]
	public int Chance;

	// Token: 0x04000B1F RID: 2847
	[Token(Token = "0x4000B1F")]
	[FieldOffset(Offset = "0x2C")]
	public float RespawnTime;

	// Token: 0x04000B20 RID: 2848
	[Token(Token = "0x4000B20")]
	[FieldOffset(Offset = "0x30")]
	public float MinAgeMinutes;

	// Token: 0x04000B21 RID: 2849
	[Token(Token = "0x4000B21")]
	[FieldOffset(Offset = "0x34")]
	public float MaxAgeMinutes;

	// Token: 0x04000B22 RID: 2850
	[Token(Token = "0x4000B22")]
	[FieldOffset(Offset = "0x38")]
	[Tooltip("Instances will not spawn on slopes steeper than this angle(degrees).")]
	[Range(0f, 90f)]
	public int SlopeCutoff;

	// Token: 0x04000B23 RID: 2851
	[Token(Token = "0x4000B23")]
	[FieldOffset(Offset = "0x3C")]
	public bool MatchSurfaceNormal;

	// Token: 0x04000B24 RID: 2852
	[Token(Token = "0x4000B24")]
	[FieldOffset(Offset = "0x40")]
	public float BuryDepth;

	// Token: 0x04000B25 RID: 2853
	[Token(Token = "0x4000B25")]
	[FieldOffset(Offset = "0x44")]
	public LayerMask SurfaceMask;

	// Token: 0x04000B26 RID: 2854
	[Token(Token = "0x4000B26")]
	[FieldOffset(Offset = "0x48")]
	public LayerMask KillMask;

	// Token: 0x04000B27 RID: 2855
	[Token(Token = "0x4000B27")]
	[FieldOffset(Offset = "0x50")]
	public int[] TerrainTextureMask;

	// Token: 0x04000B28 RID: 2856
	[Token(Token = "0x4000B28")]
	[FieldOffset(Offset = "0x58")]
	public bool UseBlockTagMask;

	// Token: 0x04000B29 RID: 2857
	[Token(Token = "0x4000B29")]
	[FieldOffset(Offset = "0x60")]
	public List<string> BlockTagMask;

	// Token: 0x04000B2A RID: 2858
	[Token(Token = "0x4000B2A")]
	[FieldOffset(Offset = "0x68")]
	public bool UseAllowTagMask;

	// Token: 0x04000B2B RID: 2859
	[Token(Token = "0x4000B2B")]
	[FieldOffset(Offset = "0x70")]
	public List<string> AllowTagMask;

	// Token: 0x04000B2C RID: 2860
	[Token(Token = "0x4000B2C")]
	[FieldOffset(Offset = "0x78")]
	public bool RandomizeRotation;

	// Token: 0x04000B2D RID: 2861
	[Token(Token = "0x4000B2D")]
	[FieldOffset(Offset = "0x79")]
	public bool AllowRotationX;

	// Token: 0x04000B2E RID: 2862
	[Token(Token = "0x4000B2E")]
	[FieldOffset(Offset = "0x7A")]
	public bool AllowRotationY;

	// Token: 0x04000B2F RID: 2863
	[Token(Token = "0x4000B2F")]
	[FieldOffset(Offset = "0x7B")]
	public bool AllowRotationZ;

	// Token: 0x04000B30 RID: 2864
	[Token(Token = "0x4000B30")]
	[FieldOffset(Offset = "0x7C")]
	public bool ClusterInstances;

	// Token: 0x04000B31 RID: 2865
	[Token(Token = "0x4000B31")]
	[FieldOffset(Offset = "0x80")]
	public Vector2Int ClusterCount;

	// Token: 0x04000B32 RID: 2866
	[Token(Token = "0x4000B32")]
	[FieldOffset(Offset = "0x88")]
	public Vector2 ClusterRadius;

	// Token: 0x04000B33 RID: 2867
	[Token(Token = "0x4000B33")]
	[FieldOffset(Offset = "0x90")]
	public AnimationCurve CentreOutPlacementChance;

	// Token: 0x04000B34 RID: 2868
	[Token(Token = "0x4000B34")]
	[FieldOffset(Offset = "0x98")]
	public AnimationCurve SplinePlacementChance;

	// Token: 0x04000B35 RID: 2869
	[Token(Token = "0x4000B35")]
	[FieldOffset(Offset = "0xA0")]
	[Range(0.1f, 10f)]
	public float MinimumScaleMultiplier;

	// Token: 0x04000B36 RID: 2870
	[Token(Token = "0x4000B36")]
	[FieldOffset(Offset = "0xA4")]
	[Range(0.1f, 10f)]
	public float MaximumScaleMultiplier;

	// Token: 0x04000B37 RID: 2871
	[Token(Token = "0x4000B37")]
	[FieldOffset(Offset = "0xA8")]
	[Range(0f, 100f)]
	[Tooltip("This is the minimum spacing which is checked at the time of spawning against other instances of this type.")]
	public float MinimumSpacing;

	// Token: 0x04000B38 RID: 2872
	[Token(Token = "0x4000B38")]
	[FieldOffset(Offset = "0xAC")]
	[Tooltip("This is the minimum spacing which is checked at the time of spawning against any overlapping zones.")]
	[Range(0f, 100f)]
	public float MinimumGlobalSpacing;

	// Token: 0x04000B39 RID: 2873
	[Token(Token = "0x4000B39")]
	[FieldOffset(Offset = "0xB0")]
	public bool ScaleBasedOffDensity;

	// Token: 0x04000B3A RID: 2874
	[Token(Token = "0x4000B3A")]
	[FieldOffset(Offset = "0xB4")]
	[Range(0f, 5f)]
	public float DensityCheckRange;

	// Token: 0x04000B3B RID: 2875
	[Token(Token = "0x4000B3B")]
	[FieldOffset(Offset = "0xB8")]
	[Range(0f, 2f)]
	public float MinScaleMultiplier;

	// Token: 0x04000B3C RID: 2876
	[Token(Token = "0x4000B3C")]
	[FieldOffset(Offset = "0xBC")]
	[Range(0f, 2f)]
	public float MaxScaleMultiplier;

	// Token: 0x04000B3D RID: 2877
	[Token(Token = "0x4000B3D")]
	[FieldOffset(Offset = "0xC0")]
	[Range(0f, 10f)]
	public int FullDensityCount;

	// Token: 0x04000B3E RID: 2878
	[Token(Token = "0x4000B3E")]
	[FieldOffset(Offset = "0xC4")]
	[EnumFlags]
	public GreebleDefinitionModifier.ModifierLayers ModifierLayers;

	// Token: 0x04000B3F RID: 2879
	[Token(Token = "0x4000B3F")]
	[FieldOffset(Offset = "0xC8")]
	[EnumFlags]
	public GreebleDefinitionModifier.GroupLayers GroupLayers;

	// Token: 0x04000B40 RID: 2880
	[Token(Token = "0x4000B40")]
	[FieldOffset(Offset = "0xCC")]
	[HideInInspector]
	[SerializeField]
	private bool _variantsAreConverted;

	// Token: 0x020001B2 RID: 434
	[Token(Token = "0x20001B2")]
	[Serializable]
	public class SpawnObjectType
	{
		// Token: 0x06000CA0 RID: 3232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CA0")]
		[Address(RVA = "0x36E9ED0", Offset = "0x36E84D0", VA = "0x1836E9ED0")]
		private void VerifyObject()
		{
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00005100 File Offset: 0x00003300
		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0x36EA110", Offset = "0x36E8710", VA = "0x1836EA110")]
		private bool ShowGameObjectField()
		{
			return default(bool);
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00005118 File Offset: 0x00003318
		[Token(Token = "0x6000CA2")]
		[Address(RVA = "0x36EA1E0", Offset = "0x36E87E0", VA = "0x1836EA1E0")]
		private bool ShowLocatorDataField()
		{
			return default(bool);
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA3")]
		[Address(RVA = "0x36EA2B0", Offset = "0x36E88B0", VA = "0x1836EA2B0")]
		public UnityEngine.Object GetObject()
		{
			return null;
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00005130 File Offset: 0x00003330
		[Token(Token = "0x6000CA4")]
		[Address(RVA = "0x36EA420", Offset = "0x36E8A20", VA = "0x1836EA420")]
		public bool TryGetLocatorData(out WorldObjectLocatorData locatorData)
		{
			return default(bool);
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00005148 File Offset: 0x00003348
		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0x36EA480", Offset = "0x36E8A80", VA = "0x1836EA480")]
		public bool TryGetPrefab(out GameObject prefab)
		{
			return default(bool);
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CA6")]
		public void ConversionHelperSetSpawnObject<T>(T spawnObject)
		{
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SpawnObjectType()
		{
		}

		// Token: 0x04000B41 RID: 2881
		[Token(Token = "0x4000B41")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private UnityEngine.Object _spawnObject;

		// Token: 0x04000B42 RID: 2882
		[Token(Token = "0x4000B42")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _gameObject;

		// Token: 0x04000B43 RID: 2883
		[Token(Token = "0x4000B43")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WorldObjectLocatorData _locatorData;

		// Token: 0x04000B44 RID: 2884
		[Token(Token = "0x4000B44")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		private bool _isGameObject;
	}
}
