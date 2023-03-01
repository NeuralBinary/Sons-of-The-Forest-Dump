using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200008C RID: 140
[Token(Token = "0x200008C")]
[AddComponentMenu("")]
public class AmplifyOcclusionBase : MonoBehaviour
{
	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x060004E8 RID: 1256 RVA: 0x000038E8 File Offset: 0x00001AE8
	[Token(Token = "0x170000C7")]
	private bool UsingTemporalFilter
	{
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x2D48CF0", Offset = "0x2D47CF0", VA = "0x182D48CF0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00003900 File Offset: 0x00001B00
	[Token(Token = "0x170000C8")]
	private bool UsingMotionVectors
	{
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x2D48CA0", Offset = "0x2D47CA0", VA = "0x182D48CA0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004EA")]
	[Address(RVA = "0x2D485E0", Offset = "0x2D475E0", VA = "0x182D485E0")]
	private void createCommandBuffer(ref AmplifyOcclusionBase.CmdBuffer aCmdBuffer, string aCmdBufferName, CameraEvent aCameraEvent)
	{
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x2D45EB0", Offset = "0x2D44EB0", VA = "0x182D45EB0")]
	private void cleanupCommandBuffer(ref AmplifyOcclusionBase.CmdBuffer aCmdBuffer)
	{
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x2D48840", Offset = "0x2D47840", VA = "0x182D48840")]
	private void createQuadMesh()
	{
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x2D43B80", Offset = "0x2D42B80", VA = "0x182D43B80")]
	private void PerformBlit(CommandBuffer cb, Material mat, int pass)
	{
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x2D486C0", Offset = "0x2D476C0", VA = "0x182D486C0")]
	private Material createMaterialWithShaderName(string aShaderName, bool aThroughErrorMsg)
	{
		return null;
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x2D455D0", Offset = "0x2D445D0", VA = "0x182D455D0")]
	private void checkMaterials(bool aThroughErrorMsg)
	{
	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x00003918 File Offset: 0x00001B18
	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x2D45E30", Offset = "0x2D44E30", VA = "0x182D45E30")]
	private bool checkRenderTextureFormats()
	{
		return default(bool);
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x2D43510", Offset = "0x2D42510", VA = "0x182D43510")]
	private void OnEnable()
	{
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x2D434C0", Offset = "0x2D424C0", VA = "0x182D434C0")]
	private void Reset()
	{
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x2D434C0", Offset = "0x2D424C0", VA = "0x182D434C0")]
	private void OnDisable()
	{
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x2D48D90", Offset = "0x2D47D90", VA = "0x182D48D90")]
	private void releaseRT()
	{
	}

	// Token: 0x060004F5 RID: 1269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x2D433B0", Offset = "0x2D423B0", VA = "0x182D433B0")]
	private void ClearHistory()
	{
	}

	// Token: 0x060004F6 RID: 1270 RVA: 0x00003930 File Offset: 0x00001B30
	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x2D45840", Offset = "0x2D44840", VA = "0x182D45840")]
	private bool checkParamsChanged()
	{
		return default(bool);
	}

	// Token: 0x060004F7 RID: 1271 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x2D490E0", Offset = "0x2D480E0", VA = "0x182D490E0")]
	private void updateParams()
	{
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x2D44DC0", Offset = "0x2D43DC0", VA = "0x182D44DC0")]
	private void Update()
	{
	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x2D43780", Offset = "0x2D42780", VA = "0x182D43780")]
	private void OnPreRender()
	{
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x2D436C0", Offset = "0x2D426C0", VA = "0x182D436C0")]
	private void OnPostRender()
	{
	}

	// Token: 0x060004FB RID: 1275 RVA: 0x00003948 File Offset: 0x00001B48
	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x2D48F80", Offset = "0x2D47F80", VA = "0x182D48F80")]
	private int safeAllocateTemporaryRT(CommandBuffer cb, string propertyName, int width, int height, RenderTextureFormat format = 7, RenderTextureReadWrite readWrite = 0, FilterMode filterMode = 0)
	{
		return default(int);
	}

	// Token: 0x060004FC RID: 1276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x2D490B0", Offset = "0x2D480B0", VA = "0x182D490B0")]
	private void safeReleaseTemporaryRT(CommandBuffer cb, int id)
	{
	}

	// Token: 0x060004FD RID: 1277 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x2D48E40", Offset = "0x2D47E40", VA = "0x182D48E40")]
	private RenderTexture safeAllocateRT(string name, int width, int height, RenderTextureFormat format, RenderTextureReadWrite readWrite, FilterMode filterMode = 0, int antiAliasing = 1)
	{
		return null;
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x2D49000", Offset = "0x2D48000", VA = "0x182D49000")]
	private void safeReleaseRT(ref RenderTexture rt)
	{
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x2D43380", Offset = "0x2D42380", VA = "0x182D43380")]
	private void BeginSample(CommandBuffer cb, string name)
	{
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000500")]
	[Address(RVA = "0x2D43490", Offset = "0x2D42490", VA = "0x182D43490")]
	private void EndSample(CommandBuffer cb, string name)
	{
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000501")]
	[Address(RVA = "0x2D47AC0", Offset = "0x2D46AC0", VA = "0x182D47AC0")]
	private void commandBuffer_FillComputeOcclusion(CommandBuffer cb)
	{
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000502")]
	[Address(RVA = "0x2D45FC0", Offset = "0x2D44FC0", VA = "0x182D45FC0")]
	private void commandBuffer_Blur(CommandBuffer cb, RenderTargetIdentifier aSourceRT, int aSourceWidth, int aSourceHeight)
	{
	}

	// Token: 0x06000503 RID: 1283 RVA: 0x00003960 File Offset: 0x00001B60
	[Token(Token = "0x6000503")]
	[Address(RVA = "0x2D48C40", Offset = "0x2D47C40", VA = "0x182D48C40")]
	private int getTemporalPass()
	{
		return default(int);
	}

	// Token: 0x06000504 RID: 1284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000504")]
	[Address(RVA = "0x2D482C0", Offset = "0x2D472C0", VA = "0x182D482C0")]
	private void commandBuffer_TemporalFilter(CommandBuffer cb)
	{
	}

	// Token: 0x06000505 RID: 1285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000505")]
	[Address(RVA = "0x2D46860", Offset = "0x2D45860", VA = "0x182D46860")]
	private void commandBuffer_FillApplyDeferred(CommandBuffer cb, bool logTarget)
	{
	}

	// Token: 0x06000506 RID: 1286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000506")]
	[Address(RVA = "0x2D47500", Offset = "0x2D46500", VA = "0x182D47500")]
	private void commandBuffer_FillApplyPostEffect(CommandBuffer cb)
	{
	}

	// Token: 0x06000507 RID: 1287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000507")]
	[Address(RVA = "0x2D46440", Offset = "0x2D45440", VA = "0x182D46440")]
	private void commandBuffer_FillApplyDebug(CommandBuffer cb)
	{
	}

	// Token: 0x06000508 RID: 1288 RVA: 0x00003978 File Offset: 0x00001B78
	[Token(Token = "0x6000508")]
	[Address(RVA = "0x2D48D30", Offset = "0x2D47D30", VA = "0x182D48D30")]
	private bool isStereoSinglePassEnabled()
	{
		return default(bool);
	}

	// Token: 0x06000509 RID: 1289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000509")]
	[Address(RVA = "0x2D44950", Offset = "0x2D43950", VA = "0x182D44950")]
	private void UpdateGlobalShaderConstants()
	{
	}

	// Token: 0x0600050A RID: 1290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600050A")]
	[Address(RVA = "0x2D43C80", Offset = "0x2D42C80", VA = "0x182D43C80")]
	private void UpdateGlobalShaderConstants_AmbientOcclusion()
	{
	}

	// Token: 0x0600050B RID: 1291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600050B")]
	[Address(RVA = "0x2D43DF0", Offset = "0x2D42DF0", VA = "0x182D43DF0")]
	private void UpdateGlobalShaderConstants_Matrices()
	{
	}

	// Token: 0x0600050C RID: 1292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600050C")]
	[Address(RVA = "0x2D45190", Offset = "0x2D44190", VA = "0x182D45190")]
	public AmplifyOcclusionBase()
	{
	}

	// Token: 0x04000412 RID: 1042
	[Token(Token = "0x4000412")]
	[FieldOffset(Offset = "0x20")]
	[Header("Ambient Occlusion")]
	[Tooltip("How to inject the occlusion: Post Effect = Overlay, Deferred = Deferred Injection, Debug - Vizualize.")]
	public AmplifyOcclusionBase.ApplicationMethod ApplyMethod;

	// Token: 0x04000413 RID: 1043
	[Token(Token = "0x4000413")]
	[FieldOffset(Offset = "0x24")]
	[Tooltip("Number of samples per pass.")]
	public AmplifyOcclusionBase.SampleCountLevel SampleCount;

	// Token: 0x04000414 RID: 1044
	[Token(Token = "0x4000414")]
	[FieldOffset(Offset = "0x28")]
	[Tooltip("Source of per-pixel normals: None = All, Camera = Forward, GBuffer = Deferred.")]
	public AmplifyOcclusionBase.PerPixelNormalSource PerPixelNormals;

	// Token: 0x04000415 RID: 1045
	[Token(Token = "0x4000415")]
	[FieldOffset(Offset = "0x2C")]
	[Tooltip("Final applied intensity of the occlusion effect.")]
	[Range(0f, 1f)]
	public float Intensity;

	// Token: 0x04000416 RID: 1046
	[Token(Token = "0x4000416")]
	[FieldOffset(Offset = "0x30")]
	[Tooltip("Color tint for occlusion.")]
	public Color Tint;

	// Token: 0x04000417 RID: 1047
	[Token(Token = "0x4000417")]
	[FieldOffset(Offset = "0x40")]
	[Tooltip("Radius spread of the occlusion.")]
	[Range(0f, 32f)]
	public float Radius;

	// Token: 0x04000418 RID: 1048
	[Token(Token = "0x4000418")]
	[FieldOffset(Offset = "0x44")]
	[Range(0f, 16f)]
	[Tooltip("Power exponent attenuation of the occlusion.")]
	public float PowerExponent;

	// Token: 0x04000419 RID: 1049
	[Token(Token = "0x4000419")]
	[FieldOffset(Offset = "0x48")]
	[Tooltip("Controls the initial occlusion contribution offset.")]
	[Range(0f, 0.99f)]
	public float Bias;

	// Token: 0x0400041A RID: 1050
	[Token(Token = "0x400041A")]
	[FieldOffset(Offset = "0x4C")]
	[Tooltip("Controls the thickness occlusion contribution.")]
	[Range(0f, 1f)]
	public float Thickness;

	// Token: 0x0400041B RID: 1051
	[Token(Token = "0x400041B")]
	[FieldOffset(Offset = "0x50")]
	[Tooltip("Compute the Occlusion and Blur at half of the resolution.")]
	public bool Downsample;

	// Token: 0x0400041C RID: 1052
	[Token(Token = "0x400041C")]
	[FieldOffset(Offset = "0x51")]
	[Header("Distance Fade")]
	[Tooltip("Control parameters at faraway.")]
	public bool FadeEnabled;

	// Token: 0x0400041D RID: 1053
	[Token(Token = "0x400041D")]
	[FieldOffset(Offset = "0x54")]
	[Tooltip("Distance in Unity unities that start to fade.")]
	public float FadeStart;

	// Token: 0x0400041E RID: 1054
	[Token(Token = "0x400041E")]
	[FieldOffset(Offset = "0x58")]
	[Tooltip("Length distance to performe the transition.")]
	public float FadeLength;

	// Token: 0x0400041F RID: 1055
	[Token(Token = "0x400041F")]
	[FieldOffset(Offset = "0x5C")]
	[Tooltip("Final Intensity parameter.")]
	[Range(0f, 1f)]
	public float FadeToIntensity;

	// Token: 0x04000420 RID: 1056
	[Token(Token = "0x4000420")]
	[FieldOffset(Offset = "0x60")]
	public Color FadeToTint;

	// Token: 0x04000421 RID: 1057
	[Token(Token = "0x4000421")]
	[FieldOffset(Offset = "0x70")]
	[Range(0f, 32f)]
	[Tooltip("Final Radius parameter.")]
	public float FadeToRadius;

	// Token: 0x04000422 RID: 1058
	[Token(Token = "0x4000422")]
	[FieldOffset(Offset = "0x74")]
	[Range(0f, 16f)]
	[Tooltip("Final PowerExponent parameter.")]
	public float FadeToPowerExponent;

	// Token: 0x04000423 RID: 1059
	[Token(Token = "0x4000423")]
	[FieldOffset(Offset = "0x78")]
	[Range(0f, 1f)]
	[Tooltip("Final Thickness parameter.")]
	public float FadeToThickness;

	// Token: 0x04000424 RID: 1060
	[Token(Token = "0x4000424")]
	[FieldOffset(Offset = "0x7C")]
	[Header("Bilateral Blur")]
	public bool BlurEnabled;

	// Token: 0x04000425 RID: 1061
	[Token(Token = "0x4000425")]
	[FieldOffset(Offset = "0x80")]
	[Tooltip("Radius in screen pixels.")]
	[Range(1f, 4f)]
	public int BlurRadius;

	// Token: 0x04000426 RID: 1062
	[Token(Token = "0x4000426")]
	[FieldOffset(Offset = "0x84")]
	[Tooltip("Number of times that the Blur will repeat.")]
	[Range(1f, 4f)]
	public int BlurPasses;

	// Token: 0x04000427 RID: 1063
	[Token(Token = "0x4000427")]
	[FieldOffset(Offset = "0x88")]
	[Tooltip("Sharpness of blur edge-detection: 0 = Softer Edges, 20 = Sharper Edges.")]
	[Range(0f, 20f)]
	public float BlurSharpness;

	// Token: 0x04000428 RID: 1064
	[Token(Token = "0x4000428")]
	[FieldOffset(Offset = "0x8C")]
	[Header("Temporal Filter")]
	[Tooltip("Accumulates the effect over the time.")]
	public bool FilterEnabled;

	// Token: 0x04000429 RID: 1065
	[Token(Token = "0x4000429")]
	[FieldOffset(Offset = "0x90")]
	[Tooltip("Controls the accumulation decayment: 0 = More flicker with less ghosting, 1 = Less flicker with more ghosting.")]
	[Range(0f, 1f)]
	public float FilterBlending;

	// Token: 0x0400042A RID: 1066
	[Token(Token = "0x400042A")]
	[FieldOffset(Offset = "0x94")]
	[Range(0f, 1f)]
	[Tooltip("Controls the discard sensitivity based on the motion of the scene and objects.")]
	public float FilterResponse;

	// Token: 0x0400042B RID: 1067
	[Token(Token = "0x400042B")]
	[FieldOffset(Offset = "0x98")]
	[Tooltip("Reduces ghosting effect near the objects's edges while moving.")]
	private bool TemporalDilation;

	// Token: 0x0400042C RID: 1068
	[Token(Token = "0x400042C")]
	[FieldOffset(Offset = "0x99")]
	private bool m_HDR;

	// Token: 0x0400042D RID: 1069
	[Token(Token = "0x400042D")]
	[FieldOffset(Offset = "0x9A")]
	private bool m_MSAA;

	// Token: 0x0400042E RID: 1070
	[Token(Token = "0x400042E")]
	[FieldOffset(Offset = "0x9C")]
	private AmplifyOcclusionBase.PerPixelNormalSource m_prevPerPixelNormals;

	// Token: 0x0400042F RID: 1071
	[Token(Token = "0x400042F")]
	[FieldOffset(Offset = "0xA0")]
	private AmplifyOcclusionBase.ApplicationMethod m_prevApplyMethod;

	// Token: 0x04000430 RID: 1072
	[Token(Token = "0x4000430")]
	[FieldOffset(Offset = "0xA4")]
	private bool m_prevDeferredReflections;

	// Token: 0x04000431 RID: 1073
	[Token(Token = "0x4000431")]
	[FieldOffset(Offset = "0xA8")]
	private AmplifyOcclusionBase.SampleCountLevel m_prevSampleCount;

	// Token: 0x04000432 RID: 1074
	[Token(Token = "0x4000432")]
	[FieldOffset(Offset = "0xAC")]
	private bool m_prevDownsample;

	// Token: 0x04000433 RID: 1075
	[Token(Token = "0x4000433")]
	[FieldOffset(Offset = "0xAD")]
	private bool m_prevBlurEnabled;

	// Token: 0x04000434 RID: 1076
	[Token(Token = "0x4000434")]
	[FieldOffset(Offset = "0xB0")]
	private int m_prevBlurRadius;

	// Token: 0x04000435 RID: 1077
	[Token(Token = "0x4000435")]
	[FieldOffset(Offset = "0xB4")]
	private int m_prevBlurPasses;

	// Token: 0x04000436 RID: 1078
	[Token(Token = "0x4000436")]
	[FieldOffset(Offset = "0xB8")]
	private bool m_prevFilterEnabled;

	// Token: 0x04000437 RID: 1079
	[Token(Token = "0x4000437")]
	[FieldOffset(Offset = "0xB9")]
	private bool m_prevHDR;

	// Token: 0x04000438 RID: 1080
	[Token(Token = "0x4000438")]
	[FieldOffset(Offset = "0xBA")]
	private bool m_prevMSAA;

	// Token: 0x04000439 RID: 1081
	[Token(Token = "0x4000439")]
	[FieldOffset(Offset = "0xC0")]
	private Camera m_targetCamera;

	// Token: 0x0400043A RID: 1082
	[Token(Token = "0x400043A")]
	[FieldOffset(Offset = "0xC8")]
	private RenderTargetIdentifier[] applyDebugTargetsTemporal;

	// Token: 0x0400043B RID: 1083
	[Token(Token = "0x400043B")]
	[FieldOffset(Offset = "0xD0")]
	private RenderTargetIdentifier[] applyDeferredTargets_Log_Temporal;

	// Token: 0x0400043C RID: 1084
	[Token(Token = "0x400043C")]
	[FieldOffset(Offset = "0xD8")]
	private RenderTargetIdentifier[] applyDeferredTargetsTemporal;

	// Token: 0x0400043D RID: 1085
	[Token(Token = "0x400043D")]
	[FieldOffset(Offset = "0xE0")]
	private RenderTargetIdentifier[] applyOcclusionTemporal;

	// Token: 0x0400043E RID: 1086
	[Token(Token = "0x400043E")]
	[FieldOffset(Offset = "0xE8")]
	private RenderTargetIdentifier[] applyPostEffectTargetsTemporal;

	// Token: 0x0400043F RID: 1087
	[Token(Token = "0x400043F")]
	[FieldOffset(Offset = "0xF0")]
	private bool useMRTBlendingFallback;

	// Token: 0x04000440 RID: 1088
	[Token(Token = "0x4000440")]
	[FieldOffset(Offset = "0xF8")]
	private AmplifyOcclusionBase.CmdBuffer m_commandBuffer_Occlusion;

	// Token: 0x04000441 RID: 1089
	[Token(Token = "0x4000441")]
	[FieldOffset(Offset = "0x110")]
	private AmplifyOcclusionBase.CmdBuffer m_commandBuffer_Apply;

	// Token: 0x04000442 RID: 1090
	[Token(Token = "0x4000442")]
	[FieldOffset(Offset = "0x0")]
	private static Mesh m_quadMesh;

	// Token: 0x04000443 RID: 1091
	[Token(Token = "0x4000443")]
	[FieldOffset(Offset = "0x8")]
	private static Material m_occlusionMat;

	// Token: 0x04000444 RID: 1092
	[Token(Token = "0x4000444")]
	[FieldOffset(Offset = "0x10")]
	private static Material m_blurMat;

	// Token: 0x04000445 RID: 1093
	[Token(Token = "0x4000445")]
	[FieldOffset(Offset = "0x18")]
	private static Material m_applyOcclusionMat;

	// Token: 0x04000446 RID: 1094
	[Token(Token = "0x4000446")]
	[FieldOffset(Offset = "0x128")]
	private RenderTextureFormat m_occlusionRTFormat;

	// Token: 0x04000447 RID: 1095
	[Token(Token = "0x4000447")]
	[FieldOffset(Offset = "0x12C")]
	private RenderTextureFormat m_accumTemporalRTFormat;

	// Token: 0x04000448 RID: 1096
	[Token(Token = "0x4000448")]
	[FieldOffset(Offset = "0x130")]
	private RenderTextureFormat m_temporaryEmissionRTFormat;

	// Token: 0x04000449 RID: 1097
	[Token(Token = "0x4000449")]
	[FieldOffset(Offset = "0x134")]
	private bool m_paramsChanged;

	// Token: 0x0400044A RID: 1098
	[Token(Token = "0x400044A")]
	[FieldOffset(Offset = "0x138")]
	private RenderTexture m_occlusionDepthRT;

	// Token: 0x0400044B RID: 1099
	[Token(Token = "0x400044B")]
	[FieldOffset(Offset = "0x140")]
	private RenderTexture[] m_temporalAccumRT;

	// Token: 0x0400044C RID: 1100
	[Token(Token = "0x400044C")]
	[FieldOffset(Offset = "0x148")]
	private uint m_sampleStep;

	// Token: 0x0400044D RID: 1101
	[Token(Token = "0x400044D")]
	[FieldOffset(Offset = "0x14C")]
	private uint m_curStepIdx;

	// Token: 0x0400044E RID: 1102
	[Token(Token = "0x400044E")]
	[FieldOffset(Offset = "0x20")]
	private static readonly int PerPixelNormalSourceCount;

	// Token: 0x0400044F RID: 1103
	[Token(Token = "0x400044F")]
	[FieldOffset(Offset = "0x150")]
	private Matrix4x4 m_prevViewProjMatrixLeft;

	// Token: 0x04000450 RID: 1104
	[Token(Token = "0x4000450")]
	[FieldOffset(Offset = "0x190")]
	private Matrix4x4 m_prevInvViewProjMatrixLeft;

	// Token: 0x04000451 RID: 1105
	[Token(Token = "0x4000451")]
	[FieldOffset(Offset = "0x1D0")]
	private Matrix4x4 m_prevViewProjMatrixRight;

	// Token: 0x04000452 RID: 1106
	[Token(Token = "0x4000452")]
	[FieldOffset(Offset = "0x210")]
	private Matrix4x4 m_prevInvViewProjMatrixRight;

	// Token: 0x04000453 RID: 1107
	[Token(Token = "0x4000453")]
	[FieldOffset(Offset = "0x28")]
	private static readonly float[] m_temporalRotations;

	// Token: 0x04000454 RID: 1108
	[Token(Token = "0x4000454")]
	[FieldOffset(Offset = "0x30")]
	private static readonly float[] m_spatialOffsets;

	// Token: 0x04000455 RID: 1109
	[Token(Token = "0x4000455")]
	[FieldOffset(Offset = "0x250")]
	private readonly RenderTargetIdentifier[] m_applyDeferredTargets;

	// Token: 0x04000456 RID: 1110
	[Token(Token = "0x4000456")]
	[FieldOffset(Offset = "0x258")]
	private readonly RenderTargetIdentifier[] m_applyDeferredTargets_Log;

	// Token: 0x04000457 RID: 1111
	[Token(Token = "0x4000457")]
	[FieldOffset(Offset = "0x260")]
	private AmplifyOcclusionBase.TargetDesc m_target;

	// Token: 0x0200008D RID: 141
	[Token(Token = "0x200008D")]
	public enum ApplicationMethod
	{
		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4000459")]
		PostEffect,
		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x400045A")]
		Deferred,
		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		Debug
	}

	// Token: 0x0200008E RID: 142
	[Token(Token = "0x200008E")]
	public enum PerPixelNormalSource
	{
		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x400045D")]
		None,
		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		Camera,
		// Token: 0x0400045F RID: 1119
		[Token(Token = "0x400045F")]
		GBuffer,
		// Token: 0x04000460 RID: 1120
		[Token(Token = "0x4000460")]
		GBufferOctaEncoded
	}

	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	public enum SampleCountLevel
	{
		// Token: 0x04000462 RID: 1122
		[Token(Token = "0x4000462")]
		Low,
		// Token: 0x04000463 RID: 1123
		[Token(Token = "0x4000463")]
		Medium,
		// Token: 0x04000464 RID: 1124
		[Token(Token = "0x4000464")]
		High,
		// Token: 0x04000465 RID: 1125
		[Token(Token = "0x4000465")]
		VeryHigh
	}

	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	private struct CmdBuffer
	{
		// Token: 0x04000466 RID: 1126
		[Token(Token = "0x4000466")]
		[FieldOffset(Offset = "0x0")]
		public CommandBuffer cmdBuffer;

		// Token: 0x04000467 RID: 1127
		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x8")]
		public CameraEvent cmdBufferEvent;

		// Token: 0x04000468 RID: 1128
		[Token(Token = "0x4000468")]
		[FieldOffset(Offset = "0x10")]
		public string cmdBufferName;
	}

	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	private struct TargetDesc
	{
		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0x0")]
		public int fullWidth;

		// Token: 0x0400046A RID: 1130
		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0x4")]
		public int fullHeight;

		// Token: 0x0400046B RID: 1131
		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0x8")]
		public int width;

		// Token: 0x0400046C RID: 1132
		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0xC")]
		public int height;

		// Token: 0x0400046D RID: 1133
		[Token(Token = "0x400046D")]
		[FieldOffset(Offset = "0x10")]
		public float oneOverWidth;

		// Token: 0x0400046E RID: 1134
		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0x14")]
		public float oneOverHeight;
	}

	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	private static class ShaderPass
	{
		// Token: 0x0400046F RID: 1135
		[Token(Token = "0x400046F")]
		public const int CombineDownsampledOcclusionDepth = 16;

		// Token: 0x04000470 RID: 1136
		[Token(Token = "0x4000470")]
		public const int BlurHorizontal1 = 0;

		// Token: 0x04000471 RID: 1137
		[Token(Token = "0x4000471")]
		public const int BlurVertical1 = 1;

		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x4000472")]
		public const int BlurHorizontal2 = 2;

		// Token: 0x04000473 RID: 1139
		[Token(Token = "0x4000473")]
		public const int BlurVertical2 = 3;

		// Token: 0x04000474 RID: 1140
		[Token(Token = "0x4000474")]
		public const int BlurHorizontal3 = 4;

		// Token: 0x04000475 RID: 1141
		[Token(Token = "0x4000475")]
		public const int BlurVertical3 = 5;

		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4000476")]
		public const int BlurHorizontal4 = 6;

		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4000477")]
		public const int BlurVertical4 = 7;

		// Token: 0x04000478 RID: 1144
		[Token(Token = "0x4000478")]
		public const int ApplyDebug = 0;

		// Token: 0x04000479 RID: 1145
		[Token(Token = "0x4000479")]
		public const int ApplyDebugTemporal = 1;

		// Token: 0x0400047A RID: 1146
		[Token(Token = "0x400047A")]
		public const int ApplyDeferred = 5;

		// Token: 0x0400047B RID: 1147
		[Token(Token = "0x400047B")]
		public const int ApplyDeferredTemporal = 6;

		// Token: 0x0400047C RID: 1148
		[Token(Token = "0x400047C")]
		public const int ApplyDeferredLog = 10;

		// Token: 0x0400047D RID: 1149
		[Token(Token = "0x400047D")]
		public const int ApplyDeferredLogTemporal = 11;

		// Token: 0x0400047E RID: 1150
		[Token(Token = "0x400047E")]
		public const int ApplyPostEffect = 15;

		// Token: 0x0400047F RID: 1151
		[Token(Token = "0x400047F")]
		public const int ApplyPostEffectTemporal = 16;

		// Token: 0x04000480 RID: 1152
		[Token(Token = "0x4000480")]
		public const int ApplyPostEffectTemporalMultiply = 20;

		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4000481")]
		public const int ApplyDeferredTemporalMultiply = 21;

		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		public const int OcclusionLow_None = 0;

		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4000483")]
		public const int OcclusionLow_Camera = 1;

		// Token: 0x04000484 RID: 1156
		[Token(Token = "0x4000484")]
		public const int OcclusionLow_GBuffer = 2;

		// Token: 0x04000485 RID: 1157
		[Token(Token = "0x4000485")]
		public const int OcclusionLow_GBufferOctaEncoded = 3;
	}

	// Token: 0x02000093 RID: 147
	[Token(Token = "0x2000093")]
	private static class PropertyID
	{
		// Token: 0x04000486 RID: 1158
		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int _AO_Radius;

		// Token: 0x04000487 RID: 1159
		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int _AO_PowExponent;

		// Token: 0x04000488 RID: 1160
		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int _AO_Bias;

		// Token: 0x04000489 RID: 1161
		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int _AO_Levels;

		// Token: 0x0400048A RID: 1162
		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int _AO_ThicknessDecay;

		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x14")]
		public static readonly int _AO_BlurSharpness;

		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int _AO_CameraViewLeft;

		// Token: 0x0400048D RID: 1165
		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly int _AO_CameraViewRight;

		// Token: 0x0400048E RID: 1166
		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0x20")]
		public static readonly int _AO_ProjMatrixLeft;

		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0x24")]
		public static readonly int _AO_ProjMatrixRight;

		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0x28")]
		public static readonly int _AO_InvViewProjMatrixLeft;

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0x2C")]
		public static readonly int _AO_PrevViewProjMatrixLeft;

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0x30")]
		public static readonly int _AO_PrevInvViewProjMatrixLeft;

		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0x34")]
		public static readonly int _AO_InvViewProjMatrixRight;

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x38")]
		public static readonly int _AO_PrevViewProjMatrixRight;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x3C")]
		public static readonly int _AO_PrevInvViewProjMatrixRight;

		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0x40")]
		public static readonly int _AO_GBufferNormals;

		// Token: 0x04000497 RID: 1175
		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0x44")]
		public static readonly int _AO_Target_TexelSize;

		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x48")]
		public static readonly int _AO_TemporalCurveAdj;

		// Token: 0x04000499 RID: 1177
		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x4C")]
		public static readonly int _AO_TemporalMotionSensibility;

		// Token: 0x0400049A RID: 1178
		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x50")]
		public static readonly int _AO_CurrOcclusionDepth;

		// Token: 0x0400049B RID: 1179
		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0x54")]
		public static readonly int _AO_TemporalAccumm;

		// Token: 0x0400049C RID: 1180
		[Token(Token = "0x400049C")]
		[FieldOffset(Offset = "0x58")]
		public static readonly int _AO_TemporalDirections;

		// Token: 0x0400049D RID: 1181
		[Token(Token = "0x400049D")]
		[FieldOffset(Offset = "0x5C")]
		public static readonly int _AO_TemporalOffsets;

		// Token: 0x0400049E RID: 1182
		[Token(Token = "0x400049E")]
		[FieldOffset(Offset = "0x60")]
		public static readonly int _AO_OcclusionTexture;

		// Token: 0x0400049F RID: 1183
		[Token(Token = "0x400049F")]
		[FieldOffset(Offset = "0x64")]
		public static readonly int _AO_GBufferAlbedo;

		// Token: 0x040004A0 RID: 1184
		[Token(Token = "0x40004A0")]
		[FieldOffset(Offset = "0x68")]
		public static readonly int _AO_GBufferEmission;

		// Token: 0x040004A1 RID: 1185
		[Token(Token = "0x40004A1")]
		[FieldOffset(Offset = "0x6C")]
		public static readonly int _AO_UVToView;

		// Token: 0x040004A2 RID: 1186
		[Token(Token = "0x40004A2")]
		[FieldOffset(Offset = "0x70")]
		public static readonly int _AO_HalfProjScale;

		// Token: 0x040004A3 RID: 1187
		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0x74")]
		public static readonly int _AO_FadeParams;

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0x78")]
		public static readonly int _AO_FadeValues;

		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0x7C")]
		public static readonly int _AO_FadeToTint;

		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0x80")]
		public static readonly int _AO_Source_TexelSize;

		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x84")]
		public static readonly int _AO_Source;
	}
}
