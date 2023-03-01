using System;
using System.Collections.Generic;
using Endnight.Types;
using Endnight.Utilities;
using Endnight.Utilities.PropertyAttributes;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001B4 RID: 436
[Token(Token = "0x20001B4")]
[Serializable]
public class GreebleDefinitionDeprecated
{
	// Token: 0x06000C4E RID: 3150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C4E")]
	[Address(RVA = "0x2F64FC0", Offset = "0x2F63FC0", VA = "0x182F64FC0")]
	public GreebleDefinitionDeprecated()
	{
	}

	// Token: 0x04000B16 RID: 2838
	[Token(Token = "0x4000B16")]
	[FieldOffset(Offset = "0x10")]
	[Tooltip("DEPRECATED Use PrefabVariations instead. This value can be ignored for now and will be removed in the future.")]
	[ReadOnly]
	public string DetailMapKey;

	// Token: 0x04000B17 RID: 2839
	[Token(Token = "0x4000B17")]
	[FieldOffset(Offset = "0x18")]
	[Tooltip("DEPRECATED Use PrefabVariations instead. This value can be ignored for now and will be removed in the future.")]
	[ReadOnly]
	public GameObject Prefab;

	// Token: 0x04000B18 RID: 2840
	[Token(Token = "0x4000B18")]
	[FieldOffset(Offset = "0x20")]
	public List<NamedGameObject> PrefabVariations;

	// Token: 0x04000B19 RID: 2841
	[Token(Token = "0x4000B19")]
	[FieldOffset(Offset = "0x28")]
	[Tooltip("Determines the chance that this definition is used over other definitions within this zone.")]
	[Range(1f, 100f)]
	public int Chance;

	// Token: 0x04000B1A RID: 2842
	[Token(Token = "0x4000B1A")]
	[FieldOffset(Offset = "0x2C")]
	public float RespawnTime;

	// Token: 0x04000B1B RID: 2843
	[Token(Token = "0x4000B1B")]
	[FieldOffset(Offset = "0x30")]
	public float MinAgeMinutes;

	// Token: 0x04000B1C RID: 2844
	[Token(Token = "0x4000B1C")]
	[FieldOffset(Offset = "0x34")]
	public float MaxAgeMinutes;

	// Token: 0x04000B1D RID: 2845
	[Token(Token = "0x4000B1D")]
	[FieldOffset(Offset = "0x38")]
	[Tooltip("Instances will not spawn on slopes steeper than this angle(degrees).")]
	[Range(0f, 90f)]
	public int SlopeCutoff;

	// Token: 0x04000B1E RID: 2846
	[Token(Token = "0x4000B1E")]
	[FieldOffset(Offset = "0x3C")]
	public bool MatchSurfaceNormal;

	// Token: 0x04000B1F RID: 2847
	[Token(Token = "0x4000B1F")]
	[FieldOffset(Offset = "0x40")]
	[Header("Surface Masks:")]
	public LayerMask SurfaceMask;

	// Token: 0x04000B20 RID: 2848
	[Token(Token = "0x4000B20")]
	[FieldOffset(Offset = "0x44")]
	public LayerMask KillMask;

	// Token: 0x04000B21 RID: 2849
	[Token(Token = "0x4000B21")]
	[FieldOffset(Offset = "0x48")]
	public int[] TerrainTextureMask;

	// Token: 0x04000B22 RID: 2850
	[Token(Token = "0x4000B22")]
	[FieldOffset(Offset = "0x50")]
	[Header("Rotation:")]
	public bool RandomizeRotation;

	// Token: 0x04000B23 RID: 2851
	[Token(Token = "0x4000B23")]
	[FieldOffset(Offset = "0x51")]
	public bool AllowRotationX;

	// Token: 0x04000B24 RID: 2852
	[Token(Token = "0x4000B24")]
	[FieldOffset(Offset = "0x52")]
	public bool AllowRotationY;

	// Token: 0x04000B25 RID: 2853
	[Token(Token = "0x4000B25")]
	[FieldOffset(Offset = "0x53")]
	public bool AllowRotationZ;

	// Token: 0x04000B26 RID: 2854
	[Token(Token = "0x4000B26")]
	[FieldOffset(Offset = "0x54")]
	public bool HasCustomActiveValue;

	// Token: 0x04000B27 RID: 2855
	[Token(Token = "0x4000B27")]
	[FieldOffset(Offset = "0x58")]
	[Header("Spawn Chance Curves:")]
	public AnimationCurve CentreOutPlacementChance;

	// Token: 0x04000B28 RID: 2856
	[Token(Token = "0x4000B28")]
	[FieldOffset(Offset = "0x60")]
	public AnimationCurve SplinePlacementChance;

	// Token: 0x04000B29 RID: 2857
	[Token(Token = "0x4000B29")]
	[FieldOffset(Offset = "0x68")]
	[Header("Scaling:")]
	[Range(0.1f, 10f)]
	public float MinimumScaleMultiplier;

	// Token: 0x04000B2A RID: 2858
	[Token(Token = "0x4000B2A")]
	[FieldOffset(Offset = "0x6C")]
	[Range(0.1f, 10f)]
	public float MaximumScaleMultiplier;

	// Token: 0x04000B2B RID: 2859
	[Token(Token = "0x4000B2B")]
	[FieldOffset(Offset = "0x70")]
	[Tooltip("This is the minimum spacing which is checked at the time of spawning against other instances of this type.")]
	[Range(0f, 100f)]
	public float MinimumSpacing;

	// Token: 0x04000B2C RID: 2860
	[Token(Token = "0x4000B2C")]
	[FieldOffset(Offset = "0x74")]
	[Tooltip("This is the minimum spacing which is checked at the time of spawning against any overlapping zones.")]
	[Range(0f, 100f)]
	public float MinimumGlobalSpacing;

	// Token: 0x04000B2D RID: 2861
	[Token(Token = "0x4000B2D")]
	[FieldOffset(Offset = "0x78")]
	[Header("Baking on Options:")]
	[Header("Density Scaling:")]
	public bool ScaleBasedOffDensity;

	// Token: 0x04000B2E RID: 2862
	[Token(Token = "0x4000B2E")]
	[FieldOffset(Offset = "0x7C")]
	[Range(0f, 5f)]
	public float DensityCheckRange;

	// Token: 0x04000B2F RID: 2863
	[Token(Token = "0x4000B2F")]
	[FieldOffset(Offset = "0x80")]
	[Range(0f, 2f)]
	public float MinScaleMultiplier;

	// Token: 0x04000B30 RID: 2864
	[Token(Token = "0x4000B30")]
	[FieldOffset(Offset = "0x84")]
	[Range(0f, 2f)]
	public float MaxScaleMultiplier;

	// Token: 0x04000B31 RID: 2865
	[Token(Token = "0x4000B31")]
	[FieldOffset(Offset = "0x88")]
	[Range(0f, 10f)]
	public int FullDensityCount;

	// Token: 0x04000B32 RID: 2866
	[Token(Token = "0x4000B32")]
	[FieldOffset(Offset = "0x90")]
	public List<GreebleDefinitionModifier> Modifiers;

	// Token: 0x04000B33 RID: 2867
	[Token(Token = "0x4000B33")]
	[FieldOffset(Offset = "0x98")]
	[Header("Modifier Layers to Apply:")]
	[EnumFlags]
	public GreebleDefinitionModifier.ModifierLayers ModifierLayers;

	// Token: 0x04000B34 RID: 2868
	[Token(Token = "0x4000B34")]
	[FieldOffset(Offset = "0x9C")]
	[EnumFlags]
	public GreebleDefinitionModifier.GroupLayers GroupLayers;
}
