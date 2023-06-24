using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
public class SimpleUnderwaterController : MonoBehaviour
{
	// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x31830E0", Offset = "0x31816E0", VA = "0x1831830E0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000020B4 File Offset: 0x000002B4
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x3183220", Offset = "0x3181820", VA = "0x183183220")]
	private bool Initialize()
	{
		return default(bool);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x3183320", Offset = "0x3181920", VA = "0x183183320")]
	private void SetEffectEnabled(bool value)
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x000020CC File Offset: 0x000002CC
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x3183470", Offset = "0x3181A70", VA = "0x183183470")]
	private bool TryGetUnderwaterStreamCustomPass(out UnderwaterStreamCustomPass result)
	{
		return default(bool);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000020E4 File Offset: 0x000002E4
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x31836F0", Offset = "0x3181CF0", VA = "0x1831836F0")]
	private bool TryGetUnifiedUnderwaterPass(out UnifiedUnderwaterPass result)
	{
		return default(bool);
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x3183970", Offset = "0x3181F70", VA = "0x183183970")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x3183E70", Offset = "0x3182470", VA = "0x183183E70")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x3183F70", Offset = "0x3182570", VA = "0x183183F70")]
	public void EnterWaterVolume(ISimpleUnderwaterData trigger)
	{
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x31843B0", Offset = "0x31829B0", VA = "0x1831843B0")]
	private void UpdateParamsFromMaterial(Material source)
	{
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x31849C0", Offset = "0x3182FC0", VA = "0x1831849C0")]
	public void ExitWaterVolume(ISimpleUnderwaterData trigger)
	{
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x31849F0", Offset = "0x3182FF0", VA = "0x1831849F0")]
	private void SetShaderParams(Material source, Material target, bool isWaterSurface)
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public SimpleUnderwaterController()
	{
	}

	// Token: 0x0400004E RID: 78
	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x20")]
	[Header("Shared Materials")]
	[SerializeField]
	private Material _waterSurfaceMaterial;

	// Token: 0x0400004F RID: 79
	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Material _waterCageMaterial;

	// Token: 0x04000050 RID: 80
	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Material _lavaSurfaceMaterial;

	// Token: 0x04000051 RID: 81
	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Material _lavaCageMaterial;

	// Token: 0x04000052 RID: 82
	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool _alwaysUpdateFromMaterial;

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x48")]
	private Material _currentActiveSurfaceMaterial;

	// Token: 0x04000054 RID: 84
	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x50")]
	[Header("Links")]
	private Volume _volumeTarget;

	// Token: 0x04000055 RID: 85
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x58")]
	private CustomPassVolume[] _customPassVolumes;

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x60")]
	private UnderwaterStreamCustomPass _underwaterStreamCustomPass;

	// Token: 0x04000057 RID: 87
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x68")]
	private UnifiedUnderwaterPass _unifiedUnderwaterPass;

	// Token: 0x04000058 RID: 88
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x70")]
	private bool _initialized;

	// Token: 0x04000059 RID: 89
	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x74")]
	private int _activeTriggers;

	// Token: 0x0400005A RID: 90
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int MinDisplacementId;

	// Token: 0x0400005B RID: 91
	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int MaxDisplacementId;

	// Token: 0x0400005C RID: 92
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int NoiseAmplitudeId;

	// Token: 0x0400005D RID: 93
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int FlowMapId;

	// Token: 0x0400005E RID: 94
	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int FlowScaleUVId;

	// Token: 0x0400005F RID: 95
	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int FlowSpeedUVId;

	// Token: 0x04000060 RID: 96
	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int FinalFlowSpeedId;

	// Token: 0x04000061 RID: 97
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly int VAnimSpeedId;

	// Token: 0x04000062 RID: 98
	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x20")]
	private static readonly int VAnimWaveContractionId;

	// Token: 0x04000063 RID: 99
	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x24")]
	private static readonly int VWaveContractionId;

	// Token: 0x04000064 RID: 100
	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x28")]
	private static readonly int VAnimDisplacementId;

	// Token: 0x04000065 RID: 101
	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x2C")]
	private static readonly int _DisplacementFromAlpha;

	// Token: 0x04000066 RID: 102
	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x30")]
	private static readonly int VAnimUvScaleId;

	// Token: 0x04000067 RID: 103
	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x34")]
	private static readonly int ShallowTintId;

	// Token: 0x04000068 RID: 104
	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x38")]
	private static readonly int DeepWaterTintId;

	// Token: 0x04000069 RID: 105
	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x3C")]
	private static readonly int DeepwaterDepthId;

	// Token: 0x0400006A RID: 106
	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x40")]
	private static readonly int UnderwaterFogColorId;

	// Token: 0x0400006B RID: 107
	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x44")]
	private static readonly int UnderwaterFogDensityId;

	// Token: 0x0400006C RID: 108
	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x48")]
	private static readonly int UnderwaterFogBoostId;

	// Token: 0x0400006D RID: 109
	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x4C")]
	private static readonly int TintingCancellationId;

	// Token: 0x0400006E RID: 110
	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x50")]
	private static readonly int CausticsTexId;

	// Token: 0x0400006F RID: 111
	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x54")]
	private static readonly int CausticsTilingId;

	// Token: 0x04000070 RID: 112
	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x58")]
	private static readonly int CausticsStrengthId;

	// Token: 0x04000071 RID: 113
	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x5C")]
	private static readonly int CausticsCancellingId;

	// Token: 0x04000072 RID: 114
	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x60")]
	private static readonly int CageExtrusionId;

	// Token: 0x04000073 RID: 115
	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x64")]
	private static readonly int _Tiling;

	// Token: 0x04000074 RID: 116
	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x68")]
	private static readonly int _Tess;

	// Token: 0x04000075 RID: 117
	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x6C")]
	private static readonly int _LavaHeightMap;

	// Token: 0x04000076 RID: 118
	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x70")]
	private static readonly int _Amplitude;

	// Token: 0x04000077 RID: 119
	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x74")]
	private static readonly int _FlowMapTiling;

	// Token: 0x04000078 RID: 120
	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x78")]
	private static readonly int _Speed;

	// Token: 0x04000079 RID: 121
	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x7C")]
	private static readonly int _FlowMapBtoSpeed;

	// Token: 0x0400007A RID: 122
	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x80")]
	private static readonly int _Interval;

	// Token: 0x0400007B RID: 123
	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x84")]
	private static readonly int _TessellationFactorMinDistance;

	// Token: 0x0400007C RID: 124
	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x88")]
	private static readonly int _TessellationFactorMaxDistance;

	// Token: 0x0400007D RID: 125
	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x8C")]
	private static readonly int _TessellationFactorTriangleSize;

	// Token: 0x0400007E RID: 126
	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x90")]
	private static readonly int _TessellationShapeFactor;

	// Token: 0x0400007F RID: 127
	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x94")]
	private static readonly int _TessellationBackFaceCullEpsilon;

	// Token: 0x04000080 RID: 128
	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x98")]
	private static readonly int _TessellationMaxDisplacement;

	// Token: 0x04000081 RID: 129
	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x9C")]
	private static readonly int _WaterVolumesActive;
}
