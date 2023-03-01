using System;
using System.Collections.Generic;
using Endnight.Types;
using Endnight.Utilities;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001B2 RID: 434
[Token(Token = "0x20001B2")]
[CreateAssetMenu(fileName = "GreebleGlobalDefinition", menuName = "Sons/Environment/GreebleDefinition", order = 0)]
public class GreebleGlobalDefinition : ScriptableObject
{
	// Token: 0x17000175 RID: 373
	// (get) Token: 0x06000C43 RID: 3139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000175")]
	public List<GreebleGlobalDefinition.SpawnObjectType> ObjectVariations
	{
		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000C44 RID: 3140 RVA: 0x00004EC0 File Offset: 0x000030C0
	[Token(Token = "0x6000C44")]
	[Address(RVA = "0x2F65640", Offset = "0x2F64640", VA = "0x182F65640")]
	public bool IsAgeAppropriate(float ageInMinutes)
	{
		return default(bool);
	}

	// Token: 0x06000C45 RID: 3141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C45")]
	[Address(RVA = "0x2F65700", Offset = "0x2F64700", VA = "0x182F65700")]
	public GreebleGlobalDefinition()
	{
	}

	// Token: 0x04000AF1 RID: 2801
	[Token(Token = "0x4000AF1")]
	[FieldOffset(Offset = "0x18")]
	public List<NamedGameObject> PrefabVariations;

	// Token: 0x04000AF2 RID: 2802
	[Token(Token = "0x4000AF2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<GreebleGlobalDefinition.SpawnObjectType> _objectVariations;

	// Token: 0x04000AF3 RID: 2803
	[Token(Token = "0x4000AF3")]
	[FieldOffset(Offset = "0x28")]
	[Tooltip("Determines the chance that this definition is used over other definitions within this zone.")]
	[Range(1f, 100f)]
	public int Chance;

	// Token: 0x04000AF4 RID: 2804
	[Token(Token = "0x4000AF4")]
	[FieldOffset(Offset = "0x2C")]
	public float RespawnTime;

	// Token: 0x04000AF5 RID: 2805
	[Token(Token = "0x4000AF5")]
	[FieldOffset(Offset = "0x30")]
	public float MinAgeMinutes;

	// Token: 0x04000AF6 RID: 2806
	[Token(Token = "0x4000AF6")]
	[FieldOffset(Offset = "0x34")]
	public float MaxAgeMinutes;

	// Token: 0x04000AF7 RID: 2807
	[Token(Token = "0x4000AF7")]
	[FieldOffset(Offset = "0x38")]
	[Range(0f, 90f)]
	[Tooltip("Instances will not spawn on slopes steeper than this angle(degrees).")]
	public int SlopeCutoff;

	// Token: 0x04000AF8 RID: 2808
	[Token(Token = "0x4000AF8")]
	[FieldOffset(Offset = "0x3C")]
	public bool MatchSurfaceNormal;

	// Token: 0x04000AF9 RID: 2809
	[Token(Token = "0x4000AF9")]
	[FieldOffset(Offset = "0x40")]
	public float BuryDepth;

	// Token: 0x04000AFA RID: 2810
	[Token(Token = "0x4000AFA")]
	[FieldOffset(Offset = "0x44")]
	public LayerMask SurfaceMask;

	// Token: 0x04000AFB RID: 2811
	[Token(Token = "0x4000AFB")]
	[FieldOffset(Offset = "0x48")]
	public LayerMask KillMask;

	// Token: 0x04000AFC RID: 2812
	[Token(Token = "0x4000AFC")]
	[FieldOffset(Offset = "0x50")]
	public int[] TerrainTextureMask;

	// Token: 0x04000AFD RID: 2813
	[Token(Token = "0x4000AFD")]
	[FieldOffset(Offset = "0x58")]
	public bool RandomizeRotation;

	// Token: 0x04000AFE RID: 2814
	[Token(Token = "0x4000AFE")]
	[FieldOffset(Offset = "0x59")]
	public bool AllowRotationX;

	// Token: 0x04000AFF RID: 2815
	[Token(Token = "0x4000AFF")]
	[FieldOffset(Offset = "0x5A")]
	public bool AllowRotationY;

	// Token: 0x04000B00 RID: 2816
	[Token(Token = "0x4000B00")]
	[FieldOffset(Offset = "0x5B")]
	public bool AllowRotationZ;

	// Token: 0x04000B01 RID: 2817
	[Token(Token = "0x4000B01")]
	[FieldOffset(Offset = "0x5C")]
	public bool ClusterInstances;

	// Token: 0x04000B02 RID: 2818
	[Token(Token = "0x4000B02")]
	[FieldOffset(Offset = "0x60")]
	public Vector2Int ClusterCount;

	// Token: 0x04000B03 RID: 2819
	[Token(Token = "0x4000B03")]
	[FieldOffset(Offset = "0x68")]
	public Vector2 ClusterRadius;

	// Token: 0x04000B04 RID: 2820
	[Token(Token = "0x4000B04")]
	[FieldOffset(Offset = "0x70")]
	public AnimationCurve CentreOutPlacementChance;

	// Token: 0x04000B05 RID: 2821
	[Token(Token = "0x4000B05")]
	[FieldOffset(Offset = "0x78")]
	public AnimationCurve SplinePlacementChance;

	// Token: 0x04000B06 RID: 2822
	[Token(Token = "0x4000B06")]
	[FieldOffset(Offset = "0x80")]
	[Range(0.1f, 10f)]
	public float MinimumScaleMultiplier;

	// Token: 0x04000B07 RID: 2823
	[Token(Token = "0x4000B07")]
	[FieldOffset(Offset = "0x84")]
	[Range(0.1f, 10f)]
	public float MaximumScaleMultiplier;

	// Token: 0x04000B08 RID: 2824
	[Token(Token = "0x4000B08")]
	[FieldOffset(Offset = "0x88")]
	[Tooltip("This is the minimum spacing which is checked at the time of spawning against other instances of this type.")]
	[Range(0f, 100f)]
	public float MinimumSpacing;

	// Token: 0x04000B09 RID: 2825
	[Token(Token = "0x4000B09")]
	[FieldOffset(Offset = "0x8C")]
	[Tooltip("This is the minimum spacing which is checked at the time of spawning against any overlapping zones.")]
	[Range(0f, 100f)]
	public float MinimumGlobalSpacing;

	// Token: 0x04000B0A RID: 2826
	[Token(Token = "0x4000B0A")]
	[FieldOffset(Offset = "0x90")]
	public bool ScaleBasedOffDensity;

	// Token: 0x04000B0B RID: 2827
	[Token(Token = "0x4000B0B")]
	[FieldOffset(Offset = "0x94")]
	[Range(0f, 5f)]
	public float DensityCheckRange;

	// Token: 0x04000B0C RID: 2828
	[Token(Token = "0x4000B0C")]
	[FieldOffset(Offset = "0x98")]
	[Range(0f, 2f)]
	public float MinScaleMultiplier;

	// Token: 0x04000B0D RID: 2829
	[Token(Token = "0x4000B0D")]
	[FieldOffset(Offset = "0x9C")]
	[Range(0f, 2f)]
	public float MaxScaleMultiplier;

	// Token: 0x04000B0E RID: 2830
	[Token(Token = "0x4000B0E")]
	[FieldOffset(Offset = "0xA0")]
	[Range(0f, 10f)]
	public int FullDensityCount;

	// Token: 0x04000B0F RID: 2831
	[Token(Token = "0x4000B0F")]
	[FieldOffset(Offset = "0xA4")]
	[EnumFlags]
	public GreebleDefinitionModifier.ModifierLayers ModifierLayers;

	// Token: 0x04000B10 RID: 2832
	[Token(Token = "0x4000B10")]
	[FieldOffset(Offset = "0xA8")]
	[EnumFlags]
	public GreebleDefinitionModifier.GroupLayers GroupLayers;

	// Token: 0x04000B11 RID: 2833
	[Token(Token = "0x4000B11")]
	[FieldOffset(Offset = "0xAC")]
	[HideInInspector]
	[SerializeField]
	private bool _variantsAreConverted;

	// Token: 0x020001B3 RID: 435
	[Token(Token = "0x20001B3")]
	[Serializable]
	public class SpawnObjectType
	{
		// Token: 0x06000C46 RID: 3142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x2F71DE0", Offset = "0x2F70DE0", VA = "0x182F71DE0")]
		private void VerifyObject()
		{
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00004ED8 File Offset: 0x000030D8
		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x2F71CC0", Offset = "0x2F70CC0", VA = "0x182F71CC0")]
		private bool ShowGameObjectField()
		{
			return default(bool);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00004EF0 File Offset: 0x000030F0
		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x2F71D20", Offset = "0x2F70D20", VA = "0x182F71D20")]
		private bool ShowLocatorDataField()
		{
			return default(bool);
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x2F71C10", Offset = "0x2F70C10", VA = "0x182F71C10")]
		public Object GetObject()
		{
			return null;
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00004F08 File Offset: 0x00003108
		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x2F71D80", Offset = "0x2F70D80", VA = "0x182F71D80")]
		public bool TryGetLocatorData(out WorldObjectLocatorData locatorData)
		{
			return default(bool);
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00004F20 File Offset: 0x00003120
		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x2F71DB0", Offset = "0x2F70DB0", VA = "0x182F71DB0")]
		public bool TryGetPrefab(out GameObject prefab)
		{
			return default(bool);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C4C")]
		public void ConversionHelperSetSpawnObject<T>(T spawnObject)
		{
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public SpawnObjectType()
		{
		}

		// Token: 0x04000B12 RID: 2834
		[Token(Token = "0x4000B12")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Object _spawnObject;

		// Token: 0x04000B13 RID: 2835
		[Token(Token = "0x4000B13")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _gameObject;

		// Token: 0x04000B14 RID: 2836
		[Token(Token = "0x4000B14")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WorldObjectLocatorData _locatorData;

		// Token: 0x04000B15 RID: 2837
		[Token(Token = "0x4000B15")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		private bool _isGameObject;
	}
}
