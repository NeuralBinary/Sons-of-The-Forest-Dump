using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
[VolumeComponentMenu("Post-processing/Custom/SimpleUnderwater Post Process Volume")]
[Serializable]
public sealed class SimpleUnderwater : CustomPostProcessVolumeComponent, IPostProcessComponent
{
	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	[Address(RVA = "0xA1C7B0", Offset = "0xA1ADB0", VA = "0x180A1C7B0")]
	private void DispatchWithGuardBands(CommandBuffer cmd, ComputeShader shader, int kernelId, in Vector2Int size, in int viewCount, in RTHandle sourceRT)
	{
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000004 RID: 4 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x17000003")]
	private int tmpTargetCount
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x317E610", Offset = "0x317CC10", VA = "0x18317E610")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000206C File Offset: 0x0000026C
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x317E660", Offset = "0x317CC60", VA = "0x18317E660", Slot = "13")]
	public bool IsActive()
	{
		return default(bool);
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000006 RID: 6 RVA: 0x00002084 File Offset: 0x00000284
	[Token(Token = "0x17000004")]
	public override CustomPostProcessInjectionPoint injectionPoint
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x6A2B30", Offset = "0x6A1130", VA = "0x1806A2B30", Slot = "8")]
		get
		{
			return CustomPostProcessInjectionPoint.AfterOpaqueAndSky;
		}
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x317E750", Offset = "0x317CD50", VA = "0x18317E750", Slot = "10")]
	public override void Setup()
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x317EDE0", Offset = "0x317D3E0", VA = "0x18317EDE0", Slot = "11")]
	public override void Render(CommandBuffer cmd, HDCamera camera, RTHandle source, RTHandle destination)
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x0000209C File Offset: 0x0000029C
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x3181090", Offset = "0x317F690", VA = "0x183181090")]
	private float GetWaterLevel()
	{
		return 0f;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x31810A0", Offset = "0x317F6A0", VA = "0x1831810A0", Slot = "12")]
	public override void Cleanup()
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void ResetBlurRTs()
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x3181180", Offset = "0x317F780", VA = "0x183181180")]
	public SimpleUnderwater()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x40")]
	public BoolParameter isEnabled;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x48")]
	public FloatParameter WaterLevel;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x50")]
	public ClampedFloatParameter TransitionHeight;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x58")]
	public BoolParameter usesMath;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x60")]
	public BoolParameter usesMask;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x68")]
	[Header("Material Inputs")]
	public ColorParameter ShallowWaterTint;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x70")]
	public ColorParameter DeepWaterTint;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x78")]
	public FloatParameter DeepWaterDepth;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x80")]
	public ColorParameter AlgeaColor;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x88")]
	public FloatParameter AlgeaDensity;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x90")]
	public FloatParameter AlgeaBoost;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x98")]
	public ClampedFloatParameter FogCancelsTinting;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0xA0")]
	public BoolParameter EnableCaustics;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0xA8")]
	public TextureParameter CausticsMap;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0xB0")]
	public FloatParameter CausticsStrength;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0xB8")]
	public FloatParameter CausticsTiling;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0xC0")]
	public FloatParameter CausticsCancelling;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0xC8")]
	public TextureParameter UnderwaterNormalMap;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0xD0")]
	public FloatParameter UnderwaterNormalDistortion;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0xD8")]
	public FloatParameter UnderwaterNormalTiling;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0xE0")]
	public BoolParameter IsWaterSurface;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0xE8")]
	[Header("Lava Inputs")]
	public ColorParameter LavaTint;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0xF0")]
	[Header("Render Settings")]
	public FloatParameter StreamWaterLevelOffset;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int SourcePID;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0xF8")]
	private Material m_BlitMaterial;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x100")]
	private RTHandle[] m_Underwater;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x108")]
	private Material m_UnderwaterMaterial;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	private const string kShaderUnderwaterName = "Hidden/Shader/SimpleUnderwater";

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x110")]
	private Vector3[] frustumCorners;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x118")]
	private Matrix4x4 frustumCornersArray;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int SonsFrustumCornersWS;

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int SonsCameraWS;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int SrcScaleBiasPID;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int SourceMipPID;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int SrcUvLimitsPID;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int InputTexturePID;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly int UnderwaterShallowWaterTintPID;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x20")]
	private static readonly int UnderwaterDeepWaterTintPID;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x24")]
	private static readonly int UnderwaterDeepWaterDepthPID;

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x28")]
	private static readonly int UnderwaterAlgeaColorPID;

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x2C")]
	private static readonly int UnderwaterAlgeaDensityPID;

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x30")]
	private static readonly int UnderwaterAlgeaBoostPID;

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x34")]
	private static readonly int UnderwaterFogCancelsTintingPID;

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x38")]
	private static readonly int UnderwaterCausticsMapPID;

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x3C")]
	private static readonly int UnderwaterCausticsStrengthPID;

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x40")]
	private static readonly int UnderwaterCausticsTilingPID;

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x44")]
	private static readonly int UnderwaterCausticsCancellingPID;

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x48")]
	private static readonly int UnderwaterWaterLevelPID;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x4C")]
	private static readonly int UnderwaterNormalMapPID;

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x50")]
	private static readonly int UnderwaterNormalDistortionPID;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x54")]
	private static readonly int UnderwaterNormalTilingPID;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x58")]
	private static readonly int TransitionHeightPID;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x5C")]
	private static readonly int HeightPID;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x60")]
	private static readonly int HeightRayUPID;

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x64")]
	private static readonly int HeightRayVPID;

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x68")]
	private static readonly int BlurredInputTexturePID;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x6C")]
	private static readonly int BlurredInputTextureScalePID;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x70")]
	private static readonly int _SonsUnderWaterMaskMode;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x74")]
	private static readonly int _SonsTransitionHeight;

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x78")]
	private static readonly int _SonsHeight;

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x7C")]
	private static readonly int _SonsHeightRayU;

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x80")]
	private static readonly int _SonsHeightRayV;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x84")]
	private static readonly int _UnderwaterIsLava;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x88")]
	private static readonly int _UnderwaterLavaColor;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x158")]
	private RTHandle[] m_Copy;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x160")]
	private RTHandle[] m_Blur;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x168")]
	private MaterialPropertyBlock m_PropertyBlock;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x170")]
	private Shader m_ColorPyramidPS;

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x178")]
	private Material m_ColorPyramidPSMat;

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x4000046")]
	private const int k_RTGuardBandSize = 4;

	// Token: 0x04000047 RID: 71
	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x8C")]
	private static readonly int InputTexPID;

	// Token: 0x04000048 RID: 72
	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x90")]
	private static readonly int OutputTexPID;

	// Token: 0x04000049 RID: 73
	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x94")]
	private static readonly int TexelSizePID;

	// Token: 0x0400004A RID: 74
	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x180")]
	public ComputeShader bloomBlurCS;

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x188")]
	private int blurKernel;

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x190")]
	private ProfilingSampler SimpleUnderWaterProfile;

	// Token: 0x0400004D RID: 77
	[Token(Token = "0x400004D")]
	private const string kShaderName = "Hidden/Shader/SimpleUnderwaterBlit";
}
