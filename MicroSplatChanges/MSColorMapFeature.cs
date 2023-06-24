using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
[ExecuteInEditMode]
public class MSColorMapFeature : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x209A1C0", Offset = "0x20987C0", VA = "0x18209A1C0")]
	public void SetSnowAmount(float amount)
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x209A1D0", Offset = "0x20987D0", VA = "0x18209A1D0")]
	public void SetSnowStartHeight(float snowStartHeight)
	{
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x209A1E0", Offset = "0x20987E0", VA = "0x18209A1E0")]
	public void SetSnowFadeRange(float snowFadeRange)
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x209A1F0", Offset = "0x20987F0", VA = "0x18209A1F0")]
	private bool ValidateMinTessellation(int value)
	{
		return default(bool);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x209A200", Offset = "0x2098800", VA = "0x18209A200")]
	public void UpdateSnowShaderVariables()
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x209AFB0", Offset = "0x20995B0", VA = "0x18209AFB0")]
	private void SetupShadowCasterCulling()
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x209B0D0", Offset = "0x20996D0", VA = "0x18209B0D0")]
	private void SetupRT()
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x209B8E0", Offset = "0x2099EE0", VA = "0x18209B8E0")]
	public void RefreshTessellationValues()
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x209BB20", Offset = "0x209A120", VA = "0x18209BB20")]
	public void RefreshWetnessDetailDistance()
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x209BBE0", Offset = "0x209A1E0", VA = "0x18209BBE0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x209BBF0", Offset = "0x209A1F0", VA = "0x18209BBF0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x209BD00", Offset = "0x209A300", VA = "0x18209BD00")]
	private void ApplyAllUpdates()
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x209BE40", Offset = "0x209A440", VA = "0x18209BE40")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x209BF30", Offset = "0x209A530", VA = "0x18209BF30")]
	private void OnValidate()
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x209BFF0", Offset = "0x209A5F0", VA = "0x18209BFF0")]
	private void SetGlobalTerrainValues()
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x209C3D0", Offset = "0x209A9D0", VA = "0x18209C3D0")]
	public MSColorMapFeature()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	public bool EnableDebug;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x24")]
	public MSColorMapFeature.MSDebugMode DebugMode;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	[Range(0f, 1f)]
	public float SplatToHeightWeights;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x2C")]
	[Space(8f)]
	public bool EnablePerlinNoise;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x30")]
	public Texture TerrainPerlinNoise;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x38")]
	[Range(0f, 1000f)]
	public float Tiling;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x3C")]
	[Range(0f, 0.01f)]
	public float Distortion;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x40")]
	public Vector4 TerrainPerlinNoiseParams;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x50")]
	[Space(8f)]
	[Range(0f, 1f)]
	public float TerrainDetailNormalStrength;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x54")]
	[Range(0f, 4f)]
	public float MaskDetailByPerlin;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x58")]
	[Header("Lightmap")]
	[Space(8f)]
	public float LightmapMultiplier;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int LightmapMultiplierPID;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x5C")]
	[Header("Height based Wetness")]
	[Space(8f)]
	public float Height;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x60")]
	public float Contrast;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x64")]
	public float Frequency;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x68")]
	public float Amplitude;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x6C")]
	[Range(0f, 1f)]
	public float MaxWetness;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x70")]
	[Space(8f)]
	[Range(0.1f, 12f)]
	[Header("Wetness and Puddle Settings")]
	public float PuddleBlend;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x74")]
	public float DefaultPorosity;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x78")]
	[Range(0f, 1f)]
	public float PerlinPuddleInfluence;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x80")]
	[Header("Global Rain Ripple Settings")]
	public Texture RainRippleBaseTex;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x88")]
	public int RenderTextureSize;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x90")]
	public Shader RainRippleCompositeShader;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x98")]
	public float RippleTiling;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x9C")]
	public float RippleAnimSpeed;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0xA0")]
	[Range(0f, 0.5f)]
	public float WetnessRefrectionStrength;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0xA4")]
	[Space(4f)]
	public float WetnessDetailDistance;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0xA8")]
	[Space(8f)]
	[Range(1f, 32f)]
	[Header("Tessellation")]
	public int TerrainTessellationMax;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0xAC")]
	[Range(1f, 3f)]
	public int TerrainTessellationMin;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0xB0")]
	[Range(1f, 32f)]
	public int TerrainTessellationShadowMax;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0xB4")]
	public float TerrainTessellationMaxDistance;

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0xB8")]
	public float TerrainTessellationMinDistance;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0xC0")]
	private RenderTexture RainRipplesRenderTexture;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0xC8")]
	private Material m_material;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int RippleAnimSpeedPID;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int RippleTilingPID;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int WetnessDetailDistancePID;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int WetnessRefrectionStrengthPID;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int PuddleBlendPID;

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int RainRippleBasePID;

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly int TerrainTessellationMaxPID;

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x20")]
	private static readonly int TerrainTessellationMinPID;

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x24")]
	private static readonly int TerrainTessellationShadowMaxPID;

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x28")]
	private static readonly int TerrainTessellationMaxDistancePID;

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x2C")]
	private static readonly int TerrainTessellationMinDistancePID;

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0xD0")]
	[Header("Snow Settings")]
	public float SnowExtrusion;

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0xD8")]
	[Space(8f)]
	private Transform terrainTrans;

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0xE0")]
	[Space(8f)]
	public float SnowMinAngle;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0xE4")]
	public float SnowMaxAngle;

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0xE8")]
	[Space(8f)]
	public float SnowFarFadeStart;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0xEC")]
	public float SnowFarFadeEnd;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0xF0")]
	public float SnowFarFadeMultiplier;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0xF8")]
	public Texture SnowFarPerlinTex;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x100")]
	public float SnowFarPerlinTiling;

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x104")]
	public float SnowFarPerlinExtrusion;

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x108")]
	[Space(8f)]
	[Range(0f, 1f)]
	public float PerPixelNormalInfluence;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x10C")]
	[Range(0f, 1f)]
	public float HeightInfluence;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x110")]
	[Range(0f, 1f)]
	public float Erosion;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x114")]
	[Range(0f, 1f)]
	public float Crystal;

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x118")]
	[Range(0f, 1f)]
	public float Melt;

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x30")]
	private static readonly int SnowAmountPID;

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x34")]
	private static readonly int SnowHeightAngleRangePID;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x38")]
	private static readonly int SnowExtrusionPID;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x3C")]
	private static readonly int SnowPerPixelNormalInfluencePID;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x40")]
	private static readonly int SnowParamsPID;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x44")]
	private static readonly int SnowFarFadeStartPID;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x48")]
	private static readonly int SnowFarFadeRangePID;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x4C")]
	private static readonly int SnowFarFadeMultiplierPID;

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x50")]
	private static readonly int SnowFarPerlinTexPID;

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x54")]
	private static readonly int SnowFarPerlinTilingPID;

	// Token: 0x04000047 RID: 71
	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x58")]
	private static readonly int SnowFarPerlinExtrusionPID;

	// Token: 0x04000048 RID: 72
	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x120")]
	[Space(8f)]
	public Texture GlobalSnowAlbedo;

	// Token: 0x04000049 RID: 73
	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x128")]
	public Texture GlobalSnowMask;

	// Token: 0x0400004A RID: 74
	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x130")]
	[Tooltip("Size of the snow texture in meters.")]
	public float GlobalSnowTexSize;

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x134")]
	public float TerrainSize;

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x138")]
	public Color GlobalSnowColor;

	// Token: 0x0400004D RID: 77
	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x148")]
	[Range(0f, 1f)]
	public float GlobalSnowSmoothness;

	// Token: 0x0400004E RID: 78
	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x14C")]
	[Range(0f, 1f)]
	public float GlobalSnowScatter;

	// Token: 0x0400004F RID: 79
	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x150")]
	[Space(8f)]
	public Texture GlobalSnowSparkles;

	// Token: 0x04000050 RID: 80
	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x158")]
	[Tooltip("Tiling of the sparkle texture relative to the snow texture.")]
	public float GlobalSnowSparklesTiling;

	// Token: 0x04000051 RID: 81
	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x15C")]
	[Range(0f, 1f)]
	public float GlobalSnowSparklesSpecular;

	// Token: 0x04000052 RID: 82
	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x160")]
	[Range(0f, 1f)]
	public float GlobalSnowSparklesSmoothness;

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x164")]
	[Tooltip("Drives the change of the sparkles according to camera movement.")]
	public float GlobalSnowSparklesChangeSpeed;

	// Token: 0x04000054 RID: 84
	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x168")]
	[Range(0f, 1f)]
	[Tooltip("Drives the smoothstep function use to sharpen the sparkles.")]
	public float GlobalSnowSparklesContrast;

	// Token: 0x04000055 RID: 85
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x5C")]
	private static readonly int GlobalSnowTexSizePID;

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x60")]
	private static readonly int GlobalSnowAlbedoPID;

	// Token: 0x04000057 RID: 87
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x64")]
	private static readonly int GlobalSnowMaskPID;

	// Token: 0x04000058 RID: 88
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x68")]
	private static readonly int GlobalSnowColorPID;

	// Token: 0x04000059 RID: 89
	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x6C")]
	private static readonly int GlobalSnowSmoothnessPID;

	// Token: 0x0400005A RID: 90
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x70")]
	private static readonly int GlobalSnowScatterPID;

	// Token: 0x0400005B RID: 91
	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x74")]
	private static readonly int GlobalSnowSparklesPID;

	// Token: 0x0400005C RID: 92
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x78")]
	private static readonly int GlobalSnowSparklesTilingPID;

	// Token: 0x0400005D RID: 93
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x7C")]
	private static readonly int GlobalSnowSparklesSpecularPID;

	// Token: 0x0400005E RID: 94
	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x80")]
	private static readonly int GlobalSnowSparklesSmoothnessPID;

	// Token: 0x0400005F RID: 95
	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x84")]
	private static readonly int GlobalSnowSparklesChangeSpeedPID;

	// Token: 0x04000060 RID: 96
	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x88")]
	private static readonly int GlobalSnowSparklesContrastPID;

	// Token: 0x04000061 RID: 97
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x16C")]
	[Header("Shadow Caster Culling")]
	public float SmallShadowCasterThreshold;

	// Token: 0x04000062 RID: 98
	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x170")]
	public float VerySmallShadowCasterThreshold;

	// Token: 0x04000063 RID: 99
	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x8C")]
	private static readonly int SmallShadowCasterThresholdPID;

	// Token: 0x04000064 RID: 100
	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x90")]
	private static readonly int VerySmallShadowCasterThresholdPID;

	// Token: 0x04000065 RID: 101
	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x174")]
	[Header("Debug")]
	[Space(8f)]
	public bool OverwriteWeatherManager;

	// Token: 0x04000066 RID: 102
	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x178")]
	[Range(0f, 1f)]
	[Tooltip("Drives the amount of accumulated water in puddles.")]
	public float Puddles;

	// Token: 0x04000067 RID: 103
	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x17C")]
	[Range(0f, 1f)]
	[Tooltip("Drives the amount of accumulated wetness and water.")]
	public float Wetness;

	// Token: 0x04000068 RID: 104
	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x180")]
	[Range(0f, 1f)]
	[Tooltip("Drives the amount of static water.")]
	public float StaticWater;

	// Token: 0x04000069 RID: 105
	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x184")]
	[Range(0f, 1f)]
	public float RainIntensity;

	// Token: 0x0400006A RID: 106
	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x188")]
	private float _snowAmount;

	// Token: 0x0400006B RID: 107
	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x18C")]
	private float _snowStartHeight;

	// Token: 0x0400006C RID: 108
	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x190")]
	private float _snowFadeRange;

	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public enum MSDebugMode
	{
		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		MeanColors,
		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		Colormap
	}
}
