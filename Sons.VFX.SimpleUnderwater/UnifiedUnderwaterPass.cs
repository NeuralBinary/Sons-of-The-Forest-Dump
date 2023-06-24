using System;
using Crest;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
public class UnifiedUnderwaterPass : CustomPass
{
	// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002A")]
	[Address(RVA = "0xA1C7B0", Offset = "0xA1ADB0", VA = "0x180A1C7B0")]
	private void DispatchWithGuardBands(CommandBuffer cmd, ComputeShader shader, int kernelId, in Vector2Int size, in int viewCount, in RTHandle sourceRT)
	{
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600002B RID: 43 RVA: 0x00002130 File Offset: 0x00000330
	[Token(Token = "0x17000008")]
	private int tmpTargetCount
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x31890F0", Offset = "0x31876F0", VA = "0x1831890F0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x3189140", Offset = "0x3187740", VA = "0x183189140")]
	public static void SetSkipUnderwaterPost(bool value)
	{
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x31891A0", Offset = "0x31877A0", VA = "0x1831891A0", Slot = "10")]
	protected override void Setup(ScriptableRenderContext renderContext, CommandBuffer cmd)
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x31897F0", Offset = "0x3187DF0", VA = "0x1831897F0", Slot = "11")]
	protected override void Cleanup()
	{
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x3189A70", Offset = "0x3188070", VA = "0x183189A70", Slot = "9")]
	protected override void Execute(CustomPassContext ctx)
	{
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x3181090", Offset = "0x317F690", VA = "0x183181090")]
	private float GetWaterLevel()
	{
		return 0f;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x318CCB0", Offset = "0x318B2B0", VA = "0x18318CCB0")]
	public UnifiedUnderwaterPass()
	{
	}

	// Token: 0x0400009D RID: 157
	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x90")]
	[Space(4f)]
	[Header("Crest Underwater")]
	public bool _copyOceanMaterialParamsEachFrame;

	// Token: 0x0400009E RID: 158
	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x98")]
	[Space(2f)]
	public ClampedIntParameter _filterOceanData;

	// Token: 0x0400009F RID: 159
	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0xA0")]
	public ClampedFloatParameter _horizonSafetyMarginMultiplier;

	// Token: 0x040000A0 RID: 160
	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0xA8")]
	[Space(2f)]
	public bool _scaleSafetyMarginWithDynamicResolution;

	// Token: 0x040000A1 RID: 161
	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0xA9")]
	private bool _firstRender;

	// Token: 0x040000A2 RID: 162
	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0xB0")]
	private Material _underwaterPostProcessMaterial;

	// Token: 0x040000A3 RID: 163
	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0xB8")]
	private PropertyWrapperMaterial _underwaterPostProcessMaterialWrapper;

	// Token: 0x040000A4 RID: 164
	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0xC0")]
	private CrestUnderwaterCustomPassUtils.UnderwaterSphericalHarmonicsData _sphericalHarmonicsData;

	// Token: 0x040000A5 RID: 165
	[Token(Token = "0x40000A5")]
	private const string SHADER = "Hidden/Crest/Underwater/Custom Pass HDRP";

	// Token: 0x040000A6 RID: 166
	[Token(Token = "0x40000A6")]
	private const string ValidCameraTag = "MainCamera";

	// Token: 0x040000A7 RID: 167
	[Token(Token = "0x40000A7")]
	private const string SceneCameraName = "SceneCamera";

	// Token: 0x040000A8 RID: 168
	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int _UnderwaterColorTexture;

	// Token: 0x040000A9 RID: 169
	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int s_CrestDepthFogDensity;

	// Token: 0x040000AA RID: 170
	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int _GlobalUseCrestUnderwater;

	// Token: 0x040000AB RID: 171
	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0xC8")]
	[Header("Simple Underwater")]
	[Space(4f)]
	public bool enableSimpleUnderwater;

	// Token: 0x040000AC RID: 172
	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0xCC")]
	[Space(8f)]
	public float WaterLevel;

	// Token: 0x040000AD RID: 173
	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0xD0")]
	[Range(0f, 1f)]
	[Space(2f)]
	public float TransitionHeight;

	// Token: 0x040000AE RID: 174
	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0xD4")]
	[Space(2f)]
	public bool usesMath;

	// Token: 0x040000AF RID: 175
	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0xD5")]
	[Space(2f)]
	public bool usesMask;

	// Token: 0x040000B0 RID: 176
	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0xD6")]
	[Space(2f)]
	public bool IsWaterSurface;

	// Token: 0x040000B1 RID: 177
	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0xD8")]
	[Space(2f)]
	public Color ShallowWaterTint;

	// Token: 0x040000B2 RID: 178
	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0xE8")]
	[Space(2f)]
	public Color DeepWaterTint;

	// Token: 0x040000B3 RID: 179
	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0xF8")]
	[Space(2f)]
	public float DeepWaterDepth;

	// Token: 0x040000B4 RID: 180
	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0xFC")]
	[Space(2f)]
	public Color AlgeaColor;

	// Token: 0x040000B5 RID: 181
	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x10C")]
	[Space(2f)]
	public float AlgeaDensity;

	// Token: 0x040000B6 RID: 182
	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x110")]
	[Space(2f)]
	public float AlgeaBoost;

	// Token: 0x040000B7 RID: 183
	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x114")]
	[Range(0f, 1f)]
	[Space(2f)]
	public float FogCancelsTinting;

	// Token: 0x040000B8 RID: 184
	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x118")]
	[Space(2f)]
	public bool EnableCaustics;

	// Token: 0x040000B9 RID: 185
	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x120")]
	[Space(2f)]
	public Texture CausticsMap;

	// Token: 0x040000BA RID: 186
	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x128")]
	[Space(2f)]
	public float CausticsStrength;

	// Token: 0x040000BB RID: 187
	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x12C")]
	[Space(2f)]
	public float CausticsTiling;

	// Token: 0x040000BC RID: 188
	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x130")]
	[Space(2f)]
	public float CausticsCancelling;

	// Token: 0x040000BD RID: 189
	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x138")]
	[Space(2f)]
	public Texture UnderwaterNormalMap;

	// Token: 0x040000BE RID: 190
	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x140")]
	[Space(2f)]
	public float UnderwaterNormalDistortion;

	// Token: 0x040000BF RID: 191
	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x144")]
	[Space(2f)]
	public float UnderwaterNormalTiling;

	// Token: 0x040000C0 RID: 192
	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x148")]
	[Header("Lava Inputs")]
	[Space(4f)]
	public Color LavaTint;

	// Token: 0x040000C1 RID: 193
	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x158")]
	public float LavaTintMultiplier;

	// Token: 0x040000C2 RID: 194
	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x15C")]
	[Space(4f)]
	[Header("Render Settings")]
	public float StreamWaterLevelOffset;

	// Token: 0x040000C3 RID: 195
	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x160")]
	private Material m_UnderwaterMaterial;

	// Token: 0x040000C4 RID: 196
	[Token(Token = "0x40000C4")]
	private const string kShaderUnderwaterName = "Hidden/Shader/SimpleUnderwater Pass";

	// Token: 0x040000C5 RID: 197
	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x168")]
	private Vector3[] frustumCorners;

	// Token: 0x040000C6 RID: 198
	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x170")]
	private Matrix4x4 frustumCornersArray;

	// Token: 0x040000C7 RID: 199
	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int SonsFrustumCornersWS;

	// Token: 0x040000C8 RID: 200
	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int SonsCameraWS;

	// Token: 0x040000C9 RID: 201
	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int UnderwaterShallowWaterTintPID;

	// Token: 0x040000CA RID: 202
	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int UnderwaterDeepWaterTintPID;

	// Token: 0x040000CB RID: 203
	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly int UnderwaterDeepWaterDepthPID;

	// Token: 0x040000CC RID: 204
	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x20")]
	private static readonly int UnderwaterAlgeaColorPID;

	// Token: 0x040000CD RID: 205
	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x24")]
	private static readonly int UnderwaterAlgeaDensityPID;

	// Token: 0x040000CE RID: 206
	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x28")]
	private static readonly int UnderwaterAlgeaBoostPID;

	// Token: 0x040000CF RID: 207
	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x2C")]
	private static readonly int _GlobalUnderwaterAlgeaDensity;

	// Token: 0x040000D0 RID: 208
	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x30")]
	private static readonly int _GlobalUnderwaterAlgeaBoost;

	// Token: 0x040000D1 RID: 209
	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x34")]
	private static readonly int UnderwaterFogCancelsTintingPID;

	// Token: 0x040000D2 RID: 210
	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x38")]
	private static readonly int UnderwaterCausticsMapPID;

	// Token: 0x040000D3 RID: 211
	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x3C")]
	private static readonly int UnderwaterCausticsStrengthPID;

	// Token: 0x040000D4 RID: 212
	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0x40")]
	private static readonly int UnderwaterCausticsTilingPID;

	// Token: 0x040000D5 RID: 213
	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0x44")]
	private static readonly int UnderwaterCausticsCancellingPID;

	// Token: 0x040000D6 RID: 214
	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0x48")]
	private static readonly int UnderwaterWaterLevelPID;

	// Token: 0x040000D7 RID: 215
	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0x4C")]
	private static readonly int UnderwaterNormalMapPID;

	// Token: 0x040000D8 RID: 216
	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0x50")]
	private static readonly int UnderwaterNormalDistortionPID;

	// Token: 0x040000D9 RID: 217
	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x54")]
	private static readonly int UnderwaterNormalTilingPID;

	// Token: 0x040000DA RID: 218
	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x58")]
	private static readonly int TransitionHeightPID;

	// Token: 0x040000DB RID: 219
	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x5C")]
	private static readonly int HeightPID;

	// Token: 0x040000DC RID: 220
	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x60")]
	private static readonly int HeightRayUPID;

	// Token: 0x040000DD RID: 221
	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x64")]
	private static readonly int HeightRayVPID;

	// Token: 0x040000DE RID: 222
	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x68")]
	private static readonly int _SonsUnderWaterMaskMode;

	// Token: 0x040000DF RID: 223
	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x6C")]
	private static readonly int _SonsTransitionHeight;

	// Token: 0x040000E0 RID: 224
	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x70")]
	private static readonly int _SonsHeight;

	// Token: 0x040000E1 RID: 225
	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x74")]
	private static readonly int _SonsHeightRayU;

	// Token: 0x040000E2 RID: 226
	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x78")]
	private static readonly int _SonsHeightRayV;

	// Token: 0x040000E3 RID: 227
	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0x7C")]
	private static readonly int _UnderwaterIsLava;

	// Token: 0x040000E4 RID: 228
	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x80")]
	private static readonly int _UnderwaterLavaColor;

	// Token: 0x040000E5 RID: 229
	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0x1B0")]
	[Header("Underwater Transparents")]
	public LayerMask _layerMask;

	// Token: 0x040000E6 RID: 230
	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0x1B8")]
	private RTHandle[] m_ColorBufferCopy;

	// Token: 0x040000E7 RID: 231
	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x1C0")]
	private RTHandle[] m_Underwater;

	// Token: 0x040000E8 RID: 232
	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x1C8")]
	private RTHandle[] m_Copy;

	// Token: 0x040000E9 RID: 233
	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0x1D0")]
	private RTHandle[] m_Blur;

	// Token: 0x040000EA RID: 234
	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x1D8")]
	private MaterialPropertyBlock m_PropertyBlock;

	// Token: 0x040000EB RID: 235
	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x1E0")]
	private Shader m_ColorPyramidPS;

	// Token: 0x040000EC RID: 236
	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x1E8")]
	private Material m_ColorPyramidPSMat;

	// Token: 0x040000ED RID: 237
	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x84")]
	public static readonly int SourcePID;

	// Token: 0x040000EE RID: 238
	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x88")]
	private static readonly int SrcScaleBiasPID;

	// Token: 0x040000EF RID: 239
	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x8C")]
	private static readonly int SourceMipPID;

	// Token: 0x040000F0 RID: 240
	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x90")]
	private static readonly int SrcUvLimitsPID;

	// Token: 0x040000F1 RID: 241
	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x94")]
	private static readonly int BlurredInputTexturePID;

	// Token: 0x040000F2 RID: 242
	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0x98")]
	private static readonly int BlurredInputTextureScalePID;

	// Token: 0x040000F3 RID: 243
	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0x9C")]
	private static readonly int InputTexturePID;

	// Token: 0x040000F4 RID: 244
	[Token(Token = "0x40000F4")]
	private const int k_RTGuardBandSize = 4;

	// Token: 0x040000F5 RID: 245
	[Token(Token = "0x40000F5")]
	[FieldOffset(Offset = "0xA0")]
	private static readonly int OutputTexturePID;

	// Token: 0x040000F6 RID: 246
	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0xA4")]
	private static readonly int TexelSizePID;

	// Token: 0x040000F7 RID: 247
	[Token(Token = "0x40000F7")]
	[FieldOffset(Offset = "0xA8")]
	private static readonly int _OceanHeight;

	// Token: 0x040000F8 RID: 248
	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0x1F0")]
	public ComputeShader bloomBlurCS;

	// Token: 0x040000F9 RID: 249
	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x1F8")]
	private int blurKernel;

	// Token: 0x040000FA RID: 250
	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x200")]
	private Shader m_FinalBlitShader;

	// Token: 0x040000FB RID: 251
	[Token(Token = "0x40000FB")]
	[FieldOffset(Offset = "0x208")]
	private Material m_BlitMaterial;

	// Token: 0x040000FC RID: 252
	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x210")]
	private Material m_BlitMaterialStreams;

	// Token: 0x040000FD RID: 253
	[Token(Token = "0x40000FD")]
	private const string kShaderName = "Hidden/Shader/SimpleUnderwaterBlit";

	// Token: 0x040000FE RID: 254
	[Token(Token = "0x40000FE")]
	[FieldOffset(Offset = "0xAC")]
	private static bool _skipUnderwaterPost;
}
