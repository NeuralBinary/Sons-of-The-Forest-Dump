using System;
using System.Collections.Generic;
using Endnight.Types;
using Endnight.Utilities;
using Endnight.Utilities.PropertyAttributes;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001B3 RID: 435
[Token(Token = "0x20001B3")]
[Serializable]
public class GreebleDefinitionDeprecated
{
	// Token: 0x06000CA8 RID: 3240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA8")]
	[Address(RVA = "0x36EA4E0", Offset = "0x36E8AE0", VA = "0x1836EA4E0")]
	public GreebleDefinitionDeprecated()
	{
	}

	// Token: 0x04000B45 RID: 2885
	[Token(Token = "0x4000B45")]
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Tooltip("DEPRECATED Use PrefabVariations instead. This value can be ignored for now and will be removed in the future.")]
	public string DetailMapKey;

	// Token: 0x04000B46 RID: 2886
	[Token(Token = "0x4000B46")]
	[FieldOffset(Offset = "0x18")]
	[ReadOnly]
	[Tooltip("DEPRECATED Use PrefabVariations instead. This value can be ignored for now and will be removed in the future.")]
	public GameObject Prefab;

	// Token: 0x04000B47 RID: 2887
	[Token(Token = "0x4000B47")]
	[FieldOffset(Offset = "0x20")]
	public List<NamedGameObject> PrefabVariations;

	// Token: 0x04000B48 RID: 2888
	[Token(Token = "0x4000B48")]
	[FieldOffset(Offset = "0x28")]
	[Tooltip("Determines the chance that this definition is used over other definitions within this zone.")]
	[Range(1f, 100f)]
	public int Chance;

	// Token: 0x04000B49 RID: 2889
	[Token(Token = "0x4000B49")]
	[FieldOffset(Offset = "0x2C")]
	public float RespawnTime;

	// Token: 0x04000B4A RID: 2890
	[Token(Token = "0x4000B4A")]
	[FieldOffset(Offset = "0x30")]
	public float MinAgeMinutes;

	// Token: 0x04000B4B RID: 2891
	[Token(Token = "0x4000B4B")]
	[FieldOffset(Offset = "0x34")]
	public float MaxAgeMinutes;

	// Token: 0x04000B4C RID: 2892
	[Token(Token = "0x4000B4C")]
	[FieldOffset(Offset = "0x38")]
	[Range(0f, 90f)]
	[Tooltip("Instances will not spawn on slopes steeper than this angle(degrees).")]
	public int SlopeCutoff;

	// Token: 0x04000B4D RID: 2893
	[Token(Token = "0x4000B4D")]
	[FieldOffset(Offset = "0x3C")]
	public bool MatchSurfaceNormal;

	// Token: 0x04000B4E RID: 2894
	[Token(Token = "0x4000B4E")]
	[FieldOffset(Offset = "0x40")]
	[Header("Surface Masks:")]
	public LayerMask SurfaceMask;

	// Token: 0x04000B4F RID: 2895
	[Token(Token = "0x4000B4F")]
	[FieldOffset(Offset = "0x44")]
	public LayerMask KillMask;

	// Token: 0x04000B50 RID: 2896
	[Token(Token = "0x4000B50")]
	[FieldOffset(Offset = "0x48")]
	public int[] TerrainTextureMask;

	// Token: 0x04000B51 RID: 2897
	[Token(Token = "0x4000B51")]
	[FieldOffset(Offset = "0x50")]
	[Header("Rotation:")]
	public bool RandomizeRotation;

	// Token: 0x04000B52 RID: 2898
	[Token(Token = "0x4000B52")]
	[FieldOffset(Offset = "0x51")]
	public bool AllowRotationX;

	// Token: 0x04000B53 RID: 2899
	[Token(Token = "0x4000B53")]
	[FieldOffset(Offset = "0x52")]
	public bool AllowRotationY;

	// Token: 0x04000B54 RID: 2900
	[Token(Token = "0x4000B54")]
	[FieldOffset(Offset = "0x53")]
	public bool AllowRotationZ;

	// Token: 0x04000B55 RID: 2901
	[Token(Token = "0x4000B55")]
	[FieldOffset(Offset = "0x54")]
	public bool HasCustomActiveValue;

	// Token: 0x04000B56 RID: 2902
	[Token(Token = "0x4000B56")]
	[FieldOffset(Offset = "0x58")]
	[Header("Spawn Chance Curves:")]
	public AnimationCurve CentreOutPlacementChance;

	// Token: 0x04000B57 RID: 2903
	[Token(Token = "0x4000B57")]
	[FieldOffset(Offset = "0x60")]
	public AnimationCurve SplinePlacementChance;

	// Token: 0x04000B58 RID: 2904
	[Token(Token = "0x4000B58")]
	[FieldOffset(Offset = "0x68")]
	[Header("Scaling:")]
	[Range(0.1f, 10f)]
	public float MinimumScaleMultiplier;

	// Token: 0x04000B59 RID: 2905
	[Token(Token = "0x4000B59")]
	[FieldOffset(Offset = "0x6C")]
	[Range(0.1f, 10f)]
	public float MaximumScaleMultiplier;

	// Token: 0x04000B5A RID: 2906
	[Token(Token = "0x4000B5A")]
	[FieldOffset(Offset = "0x70")]
	[Range(0f, 100f)]
	[Tooltip("This is the minimum spacing which is checked at the time of spawning against other instances of this type.")]
	public float MinimumSpacing;

	// Token: 0x04000B5B RID: 2907
	[Token(Token = "0x4000B5B")]
	[FieldOffset(Offset = "0x74")]
	[Range(0f, 100f)]
	[Tooltip("This is the minimum spacing which is checked at the time of spawning against any overlapping zones.")]
	public float MinimumGlobalSpacing;

	// Token: 0x04000B5C RID: 2908
	[Token(Token = "0x4000B5C")]
	[FieldOffset(Offset = "0x78")]
	[Header("Density Scaling:")]
	[Header("Baking on Options:")]
	public bool ScaleBasedOffDensity;

	// Token: 0x04000B5D RID: 2909
	[Token(Token = "0x4000B5D")]
	[FieldOffset(Offset = "0x7C")]
	[Range(0f, 5f)]
	public float DensityCheckRange;

	// Token: 0x04000B5E RID: 2910
	[Token(Token = "0x4000B5E")]
	[FieldOffset(Offset = "0x80")]
	[Range(0f, 2f)]
	public float MinScaleMultiplier;

	// Token: 0x04000B5F RID: 2911
	[Token(Token = "0x4000B5F")]
	[FieldOffset(Offset = "0x84")]
	[Range(0f, 2f)]
	public float MaxScaleMultiplier;

	// Token: 0x04000B60 RID: 2912
	[Token(Token = "0x4000B60")]
	[FieldOffset(Offset = "0x88")]
	[Range(0f, 10f)]
	public int FullDensityCount;

	// Token: 0x04000B61 RID: 2913
	[Token(Token = "0x4000B61")]
	[FieldOffset(Offset = "0x90")]
	public List<GreebleDefinitionModifier> Modifiers;

	// Token: 0x04000B62 RID: 2914
	[Token(Token = "0x4000B62")]
	[FieldOffset(Offset = "0x98")]
	[Header("Modifier Layers to Apply:")]
	[EnumFlags]
	public GreebleDefinitionModifier.ModifierLayers ModifierLayers;

	// Token: 0x04000B63 RID: 2915
	[Token(Token = "0x4000B63")]
	[FieldOffset(Offset = "0x9C")]
	[EnumFlags]
	public GreebleDefinitionModifier.GroupLayers GroupLayers;
}
