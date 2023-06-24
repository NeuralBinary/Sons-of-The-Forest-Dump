using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
[RequireComponent(typeof(Terrain))]
public class TerrainShaderGlobals : MonoBehaviour
{
	// Token: 0x0600000E RID: 14 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2F8E4F0", Offset = "0x2F8CAF0", VA = "0x182F8E4F0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void OnValidate()
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2F8E610", Offset = "0x2F8CC10", VA = "0x182F8E610")]
	public void SetRefractionEnabled(bool enabled)
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2F8E6D0", Offset = "0x2F8CCD0", VA = "0x182F8E6D0")]
	public void SetCausticsEnabled(bool enabled)
	{
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2F8E790", Offset = "0x2F8CD90", VA = "0x182F8E790")]
	protected void ApplyAllUpdates()
	{
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2F8F6B0", Offset = "0x2F8DCB0", VA = "0x182F8F6B0")]
	public TerrainShaderGlobals()
	{
	}

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _enableRefractionOnWater;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	private bool _enableCausticsOnWater;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x24")]
	[Space(8f)]
	[SerializeField]
	private Vector3 _terrainPosition;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector3 _terrainSize;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Texture _terrainHeightNormalMap;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x48")]
	[Space(8f)]
	[SerializeField]
	private Texture2DArray _terrainAlbedoArray;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Texture2DArray _terrainNSOArray;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Texture2DArray _terrainHeightArray;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x60")]
	[Space(8f)]
	[SerializeField]
	private Texture _terrainNormalNoiseMap;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float _terrainNormalNoiseTiling;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[Range(0f, 0.05f)]
	private float _terrainNormalNoiseParallax;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float[] _terrainNormalNoiseStrengths;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float[] _terrainParallaxStrengths;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x80")]
	[Header("Terrain Displacement - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -")]
	[Space(8f)]
	[SerializeField]
	private float _terrainMaxDisplacement;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	private float _diggingDisplacementCutoff;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x88")]
	[Space(4f)]
	[SerializeField]
	private float _terrainMaxSandDisplacement;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x8C")]
	[Space(4f)]
	[SerializeField]
	private float _snowExtrusion;

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x90")]
	[Space(8f)]
	[SerializeField]
	private float _snowkicksMaxDisplacement;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Header("Terrain Textures - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -")]
	[Space(8f)]
	private Texture _terrainFxMap;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Space(8f)]
	private bool _applyGlobalLightmaps;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Texture _terrainLightMap;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private Texture _terrainDirLightMap;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private Texture _terrainLightMapSmall;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Texture _terrainDirLightMapSmall;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0xC8")]
	[Space(8f)]
	[SerializeField]
	private Texture _streamsWetnessDepthCache;

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private float _streamsWetnessBlendWidth;

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0xD4")]
	[SerializeField]
	private float _streamsWetnessDepthShift;

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private float _streamsSnowShift;

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0xDC")]
	[SerializeField]
	private float _streamsWetnessDrawDistance;

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private float _streamsWetnessFadeDistance;

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Space(8f)]
	private Texture3D _global3DNoiseTexture;

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0xF0")]
	[Space(8f)]
	[SerializeField]
	private Texture2D _globalSheenGradient;

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int TerrainPos;

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int TerrainSize;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int TerrainHeightNormal;

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int TerrainAlbedoArray;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int TerrainNSOArray;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int TerrainHeightArray;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int TerrainNormalNoise;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly int TerrainNormalNoiseTiling;

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x20")]
	private static readonly int TerrainNormalNoiseParallax;

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x24")]
	private static readonly int TerrainNormalNoiseStrengths;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x28")]
	private static readonly int TerrainParallaxStrengths;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x2C")]
	private static readonly int TerrainMaxdisplacement;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x30")]
	private static readonly int _DiggingDisplacementCutoff;

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x34")]
	private static readonly int _SandDisplacement;

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x38")]
	private static readonly int _SnowExtrusion;

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x3C")]
	private static readonly int SnowkicksMaxdisplacement;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x40")]
	private static readonly int TerrainFx;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x44")]
	private static readonly int TerrainLightMap;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x48")]
	private static readonly int TerrainDirLightMap;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x4C")]
	private static readonly int TerrainLightMapSmall;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x50")]
	private static readonly int TerrainDirLightMapSmall;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x54")]
	private static readonly int StreamsWetnessDepthCache;

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x58")]
	private static readonly int StreamsWetnessOneOverBlendWidth;

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x5C")]
	private static readonly int StreamsWetnessDepthShift;

	// Token: 0x04000047 RID: 71
	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x60")]
	private static readonly int StreamsSnowShift;

	// Token: 0x04000048 RID: 72
	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x64")]
	private static readonly int StreamsWetnessDrawFadeDistance;

	// Token: 0x04000049 RID: 73
	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x68")]
	private static readonly int SonsGlobal3DNoiseTexture;

	// Token: 0x0400004A RID: 74
	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x6C")]
	private static readonly int _WeatherLocalizedInverseFogFactor;

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x70")]
	private static readonly int _GlobalSheenGradientMap;

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0xF8")]
	private Terrain ter;

	// Token: 0x0400004D RID: 77
	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x74")]
	private static readonly int _TerrainBaseMapDist;

	// Token: 0x0400004E RID: 78
	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x78")]
	private static readonly int _Sons_EnableRefractionOnWater;

	// Token: 0x0400004F RID: 79
	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x7C")]
	private static readonly int _Sons_EnableCausticsOnWater;
}
